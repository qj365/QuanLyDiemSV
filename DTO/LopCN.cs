using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemSV.DTO
{
    public class LopCN
    {
        public LopCN(string malopcn, string tenlopcn, int siso, string makhoa, string magv)
        {
            this.MaLopCN = malopcn;
            this.TenLopCN = tenlopcn;
            this.SiSo = siso;
            this.MaKhoa = makhoa;
            this.MaGV = magv;
        }
        public LopCN(DataRow row)
        {
            this.MaLopCN = row["malopcn"].ToString();
            this.TenLopCN = row["tenlopcn"].ToString();
            this.SiSo = (int)row["siso"];
            this.MaKhoa = row["makhoa"].ToString();
            this.MaGV = row["magv"].ToString();
        }
        private string maLopCN;
        private string tenLopCN;
        private int siSo;
        private string maKhoa;
        private string maGV;

        public string MaKhoa { get => maKhoa; set => maKhoa = value; }
        public string MaLopCN { get => maLopCN; set => maLopCN = value; }
        public string TenLopCN { get => tenLopCN; set => tenLopCN = value; }
        public int SiSo { get => siSo; set => siSo = value; }
        public string MaGV { get => maGV; set => maGV = value; }
    }
}

