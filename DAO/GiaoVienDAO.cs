using QuanLyDiemSV.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemSV.DAO
{
    public class GiaoVienDAO
    {
        private static GiaoVienDAO instance; //Ctrl + R + E

        public static GiaoVienDAO Instance
        {
            get { if (instance == null) instance = new GiaoVienDAO(); return GiaoVienDAO.instance; }
            private set { GiaoVienDAO.instance = value; }
        }

        private GiaoVienDAO() { }

        public List<GiaoVien> GetListGiaoVien()
        {
            List<GiaoVien> list = new List<GiaoVien>();
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetGiaoVienList");

            foreach (DataRow item in data.Rows)
            {
                GiaoVien giaovien = new GiaoVien(item);
                list.Add(giaovien);
            }
            return list;
        }
        public void DeleteGiaoVienByMaKhoa(string makhoa)
        {
            DataProvider.Instance.ExecuteQuery("delete from dbo.GIAOVIEN where MAKHOA = " + makhoa);
        }
    }
}
