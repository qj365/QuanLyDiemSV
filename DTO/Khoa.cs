using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemSV.DTO
{
    public class Khoa
    {
        public Khoa( string makhoa, string tenkhoa)
        {
            this.MaKhoa = makhoa;
            this.TenKhoa = tenkhoa;
        }
        public Khoa(DataRow row)
        {
            this.MaKhoa = row["makhoa"].ToString();
            this.TenKhoa = row["tenkhoa"].ToString();
        }
        private string maKhoa;
        private string tenKhoa;

        public string MaKhoa { get => maKhoa; set => maKhoa = value; }
        public string TenKhoa { get => tenKhoa; set => tenKhoa = value; }
    }
}

