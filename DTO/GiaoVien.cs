using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemSV.DTO
{
    public class GiaoVien
    {
        public GiaoVien(string magv, string tengv, string gioitinh, string ngaysinh, string diachi, string sdt, string matkhau, string makhoa)
        {
            this.MaGV = magv;
            this.TenGV = tengv;
            this.GioiTinh = gioitinh;
            this.NgaySinh = ngaysinh;
            this.DiaChi = diachi;
            this.SDT = sdt;
            this.MatKhau = matkhau;
            this.MaKhoa = makhoa;
        }
        public GiaoVien(DataRow row)
        {
            this.MaGV = row["magv"].ToString();
            this.TenGV = row["tengv"].ToString();
            this.GioiTinh = row["gioitinh"].ToString();
            this.NgaySinh = row["ngaysinh"].ToString();
            this.DiaChi = row["diachi"].ToString();
            this.SDT = row["sdt"].ToString();
            this.MatKhau = row["matkhau"].ToString();
            this.MaKhoa = row["makhoa"].ToString();
        }
        private string maGV;
        private string tenGV;
        private string gioiTinh;
        private string ngaySinh;
        private string diaChi;
        private string sDT;
        private string matKhau;
        private string maKhoa;

        public string MaGV { get => maGV; set => maGV = value; }
        public string TenGV { get => tenGV; set => tenGV = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string MaKhoa { get => maKhoa; set => maKhoa = value; }
    }
}
