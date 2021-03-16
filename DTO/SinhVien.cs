using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemSV.DTO
{
    public class SinhVien
    {
        public SinhVien(string masv, string tensv, string gioitinh, string ngaysinh, string quequan, string sdt, double gpa, string malopcn)
        {
            this.MaSV = masv;
            this.TenSV = tensv;
            this.GioiTinh = gioitinh;
            this.NgaySinh = ngaysinh;
            this.QueQuan = quequan;
            this.SDT = sdt;
            this.GPA = gpa;
            this.MaLopCN = malopcn;
        }
        public SinhVien(DataRow row)
        {
            this.MaSV = row["masv"].ToString();
            this.TenSV = row["tensv"].ToString();
            this.GioiTinh = row["gioitinh"].ToString();
            this.NgaySinh = row["ngaysinh"].ToString();
            this.QueQuan = row["quequan"].ToString();
            this.SDT= row["sdt"].ToString();
            this.GPA = (double)row["gpa"];
            this.MaLopCN= row["malopcn"].ToString();
        }
        private string maSV;
        private string tenSV;
        private string gioiTinh;
        private string ngaySinh;
        private string queQuan;
        private string sDT;
        private double gPA;
        private string maLopCN;

        public string MaSV { get => maSV; set => maSV = value; }
        public string TenSV { get => tenSV; set => tenSV = value; }
        
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string QueQuan { get => queQuan; set => queQuan = value; }
        public string SDT { get => sDT; set => sDT = value; }
        
        public string MaLopCN { get => maLopCN; set => maLopCN = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public double GPA { get => gPA; set => gPA = value; }
    }
}
