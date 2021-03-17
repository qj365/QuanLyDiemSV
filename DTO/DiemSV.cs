using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemSV.DTO
{
    public class DiemSV
    {
        public DiemSV(string masv, string malophp, double diemcc, double diemtx, double diemthi, double diemtb)
        {
            this.MaSV = masv;
            this.MaLopHP = malophp;
            this.DiemCC = diemcc;
            this.DiemTX = diemtx;
            this.DiemThi = diemthi;
            this.DiemTB = diemtb;
        }
        public DiemSV(DataRow row)
        {
            this.MaSV = row["masv"].ToString();
            this.MaLopHP = row["malophp"].ToString();
            this.DiemCC = (double)row["diemcc"];
            this.DiemTX = (double)row["diemtx"];
            this.DiemThi = (double)row["diemthi"];
            this.DiemTB = (double)row["diemtb"];
        }

        private string maSV;
        private string maLopHP;
        private double diemCC;
        private double diemTX;
        private double diemThi;
        private double diemTB;


        public string MaSV { get => maSV; set => maSV = value; }
        public string MaLopHP { get => maLopHP; set => maLopHP = value; }

        public double DiemCC { get => diemCC; set => diemCC = value; }

        public double DiemTX { get => diemTX; set => diemTX = value; }
        public double DiemThi { get => diemThi; set => diemThi = value; }
        public double DiemTB { get => diemTB; set => diemTB = value; }


    }
}
