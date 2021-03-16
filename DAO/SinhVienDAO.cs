using QuanLyDiemSV.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemSV.DAO
{
    public class SinhVienDAO
    {
        private static SinhVienDAO instance; //Ctrl + R + E

        public static SinhVienDAO Instance
        {
            get { if (instance == null) instance = new SinhVienDAO(); return SinhVienDAO.instance; }
            private set { SinhVienDAO.instance = value; }
        }

        private SinhVienDAO() { }

        public List<SinhVien> GetListLopCN()
        {
            List<SinhVien> list = new List<SinhVien>();
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetSinhVienList");

            foreach (DataRow item in data.Rows)
            {
                SinhVien sinhvien = new SinhVien(item);
                list.Add(sinhvien);
            }
            return list;
        }
        public void DeleteSinhVienByMaLopCN(string malopcn)
        {
            DataProvider.Instance.ExecuteQuery("delete from dbo.SINHVIEN where MALOPCN = " + malopcn);
        }
    }
}
