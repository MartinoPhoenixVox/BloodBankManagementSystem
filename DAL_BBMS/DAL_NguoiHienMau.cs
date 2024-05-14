using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO_BBMS;
namespace DAL_BBMS
{
    public class DAL_NguoiHienMau : DBConnect
    {
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
                string SQL = string.Format("INSERT INTO NguoiHienMau(Ho, Ten, NgaySinh, DiaChi, GioiTinh, SDT, Email) VALUES ('{0}', '{1}', '{2}', '{3}', {4}, '{5}, '{6}')", nhm.NHM_Ho, nhm.NHM_Ten, nhm.NHM_NgaySinh.ToString(), nhm.NHM_DiaChi, nhm.NHM_GioiTinh, nhm.NHM_SDT, nhm.NHM_Email);
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
                string SQL = string.Format("UPDATE NguoiHienMau SET Ho = '{0}', Ten = '{1}', NgaySinh = '{2}', DiaChi = '{3}', GioiTinh = {4}, SDT = '{5}', Email = '{6}' WHERE SV_ID = {7}", nhm.NHM_Ho, nhm.NHM_Ten, nhm.NHM_NgaySinh.ToString(), nhm.NHM_DiaChi, nhm.NHM_GioiTinh, nhm.NHM_SDT, nhm.NHM_Email, nhm.NHM_MaNHM);
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