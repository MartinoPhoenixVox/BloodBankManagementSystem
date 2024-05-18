using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO_BBMS;
using Microsoft.VisualBasic.Logging;
using System.Windows.Forms;
namespace DAL_BBMS
{
    public class DAL_NguoiHienMau : DBConnect
    {
        private static string  GetPath()
        {
            string location = System.Reflection.Assembly.GetEntryAssembly().Location;
            string executableDirectory = System.IO.Path.GetDirectoryName(location);
            System.IO.DirectoryInfo directoryInfo = System.IO.Directory.GetParent(System.IO.Directory.GetParent(System.IO.Directory.GetParent(System.IO.Directory.GetParent(executableDirectory).FullName).FullName).FullName);
            return directoryInfo.FullName;
        }
        public bool Restore()
        {
            try
            {
                string path = GetPath();
                conn.Open();
                string SQL = string.Format(@"DECLARE @dbname nvarchar(128) SET @dbname = N'BBMS' IF NOT EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE ('[' + name + ']' = @dbname OR name = @dbname)) BEGIN RESTORE DATABASE BBMS FILE = 'BBMS_Primary' FROM DISK = '{0}\Database\BBMS.bak' WITH NORECOVERY RESTORE LOG BBMS FROM DISK = '{0}\Database\BBMS_log.trn' WITH RECOVERY END", path);
                SqlCommand cmd = new SqlCommand(SQL, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        public bool Backup()
        {
            try
            {
                string path = GetPath();
                _conn.Open();
                string SQL = string.Format(@"DECLARE @dbname nvarchar(128) SET @dbname = N'BBMS' IF EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE ('[' + name + ']' = @dbname OR name = @dbname)) BEGIN BACKUP DATABASE BBMS TO DISK = '{0}\Database\BBMS.bak' BACKUP LOG BBMS TO DISK = '{0}\Database\BBMS_log.trn' END", path);
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {

            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
        public DataTable getNHM()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM NguoiHienMau", _conn);
            DataTable dtNHM = new DataTable();
            da.Fill(dtNHM);
            return dtNHM;
        }
        public bool addNHM(DTO_NguoiHienMau nhm)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("INSERT INTO NguoiHienMau (Ho, Ten, NgaySinh, DiaChi, GioiTinh, SDT, Email) VALUES (N'{0}', N'{1}', '{2}', N'{3}', {4}, '{5}', '{6}')", nhm.NHM_Ho, nhm.NHM_Ten, nhm.NHM_NgaySinh.ToString("yyyy-MM-dd"), nhm.NHM_DiaChi, Convert.ToInt32(nhm.NHM_GioiTinh), nhm.NHM_SDT, nhm.NHM_Email);
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {

            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
        public bool modNHM(DTO_NguoiHienMau nhm)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("UPDATE NguoiHienMau SET Ho = N'{0}', Ten = N'{1}', NgaySinh = '{2}', DiaChi = N'{3}', GioiTinh = {4}, SDT = '{5}', Email = '{6}' WHERE MaNHM = {7}", nhm.NHM_Ho, nhm.NHM_Ten, nhm.NHM_NgaySinh.ToString("yyyy-MM-dd"), nhm.NHM_DiaChi, Convert.ToInt32(nhm.NHM_GioiTinh), nhm.NHM_SDT, nhm.NHM_Email, nhm.NHM_MaNHM);
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {

            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
        public bool delNHM(int MaNHM)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("DELETE FROM NguoiHIenMau WHERE MaNHM = {0}", MaNHM);
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {

            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
        static void Main() { }
    }
}