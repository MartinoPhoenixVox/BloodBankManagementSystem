using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace DTO_BBMS
{
    public class DTO_NguoiHienMau
    {
        private int _NHM_MaNHM;
        private string _NHM_Ho;
        private string _NHM_Ten;
        private DateTime _NHM_NgaySinh;
        private string _NHM_DiaChi;
        private int _NHM_GioiTinh;
        private string _NHM_SDT;
        private string _NHM_Email;

        public int NHM_MaNHM
        {
            get
            {
                return _NHM_MaNHM;
            }
            set
            {
                _NHM_MaNHM = value;
            }
        }

        public string NHM_Ho
        {
            get
            {
                return _NHM_Ho;
            }
            set
            {
                _NHM_Ho = value;
            }
        }
        public string NHM_Ten
        {
            get
            {
                return _NHM_Ten;
            }
            set
            {
                _NHM_Ten = value;
            }
        }
        public DateTime NHM_NgaySinh
        {
            get
            {
                return _NHM_NgaySinh;
            }
            set
            {
                _NHM_NgaySinh = value;
            }
        }
        public string NHM_DiaChi
        {
            get
            {
                return _NHM_DiaChi;
            }
            set
            {
                _NHM_DiaChi = value;
            }
        }
        public int NHM_GioiTinh
        {
            get
            {
                return _NHM_GioiTinh;
            }
            set
            {
                _NHM_GioiTinh = value;
            }
        }
        public string NHM_SDT
        {
            get
            {
                return _NHM_SDT;
            }
            set
            {
                _NHM_SDT= value;
            }
        }
        public string NHM_Email
        {
            get
            {
                return _NHM_Email;
            }
            set
            {
                _NHM_Email = value;
            }
        }
        private string TachHo(string HoTen)
        {
            int i = HoTen.LastIndexOf(" ");
            string Ho = HoTen.Substring(0, i);
            return Ho;
        }
        private string TachTen(string HoTen)
        {
            int i = HoTen.LastIndexOf(" ");
            string Ten = HoTen.Substring(i + 1);
            return Ten;
        }

        public DTO_NguoiHienMau()
        {

        }
        public DTO_NguoiHienMau(int MaNHM, string HoTen, DateTime NgaySinh, string DiaChi, int GioiTinh, string SDT, string Email)
        {
            this.NHM_MaNHM = MaNHM;
            this.NHM_Ho = TachHo(HoTen);
            this.NHM_Ten = TachTen(HoTen);
            this.NHM_NgaySinh = NgaySinh.Date;
            this.NHM_DiaChi = DiaChi;
            this.NHM_GioiTinh = GioiTinh;
            this._NHM_SDT = SDT;
            this._NHM_Email = Email;
        }
        static void Main() { }
    }
}