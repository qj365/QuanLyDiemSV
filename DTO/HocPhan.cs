using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemSV.DTO
{
    public class HocPhan
    {
        public HocPhan(string mahocphan, string tenhocphan, int sotinchi, int sotiet, string hinhthucthi, string makhoa)
        {
            this.MaHocPhan = mahocphan;
            this.TenHocPhan = tenhocphan;
            this.SoTinChi = sotinchi;
            this.SoTiet = sotiet;
            this.HinhThucThi = hinhthucthi;
            this.MaKhoa = makhoa;
        }
        public HocPhan(DataRow row)
        {
            this.MaHocPhan = row["mahocphan"].ToString();
            this.TenHocPhan = row["tenhocphan"].ToString();
            this.SoTinChi = (int)row["sotinchi"];
            this.SoTiet = (int)row["sotiet"];
            this.HinhThucThi = row["hinhthucthi"].ToString();
            this.MaKhoa = row["makhoa"].ToString();
        }
        private string maHocPhan;
        private string tenHocPhan;
        private int soTinChi;
        private int soTiet;
        private string hinhThucThi;
        private string maKhoa;

        public string MaHocPhan { get => maHocPhan; set => maHocPhan = value; }
        public string TenHocPhan { get => tenHocPhan; set => tenHocPhan = value; }
        public int SoTinChi { get => soTinChi; set => soTinChi = value; }
        public int SoTiet { get => soTiet; set => soTiet = value; }
        public string HinhThucThi { get => hinhThucThi; set => hinhThucThi = value; }
        public string MaKhoa { get => maKhoa; set => maKhoa = value; }
    }
}
