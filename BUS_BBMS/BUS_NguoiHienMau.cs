using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL_BBMS;
using DTO_BBMS;
namespace BUS_BBMS
{
    public class BUS_NguoiHienMau
    {
        DAL_NguoiHienMau dalNHM = new DAL_NguoiHienMau();
        public DataTable getNHM()
        {
            return dalNHM.getNHM();
        }
        public bool addNHM(DTO_NguoiHienMau nhm)
        {
            return dalNHM.addNHM(nhm);
        }
        public bool modNHM(DTO_NguoiHienMau nhm)
        {
            return dalNHM.modNHM(nhm);
        }
        public bool delNHM(int MaNHM)
        {
            return dalNHM.delNHM(MaNHM);
        }
        static void Main() { }
    }
}