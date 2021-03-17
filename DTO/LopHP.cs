using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemSV.DTO
{
    public class LopHP
    {
        public LopHP(string malophp, string giangduong, int siso, string mahocphan)
        {
            this.MaLopHP = malophp;
            this.GiangDuong = giangduong;
            this.SiSo = siso;
            this.MaHocPhan = mahocphan;
        }
        public LopHP(DataRow row)
        {
            this.MaLopHP = row["malophp"].ToString();
            this.GiangDuong= row["giangduong"].ToString();
            this.SiSo = (int)row["siso"];
            this.MaHocPhan = row["mahocphan"].ToString();
        }
        private string maLopHP;
        private string giangDuong;
        private int siSo;
        private string maHocPhan;

        public string MaLopHP { get => maLopHP; set => maLopHP = value; }
        public string GiangDuong { get => giangDuong; set => giangDuong = value; }
        public int SiSo { get => siSo; set => siSo = value; }
        public string MaHocPhan { get => maHocPhan; set => maHocPhan = value; }
    }
}
