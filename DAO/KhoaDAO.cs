using QuanLyDiemSV.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemSV.DAO
{
    public class KhoaDAO
    {
        private static KhoaDAO instance; //Ctrl + R + E

        public static KhoaDAO Instance
        {
            get { if (instance == null) instance = new KhoaDAO(); return KhoaDAO.instance; }
            private set { KhoaDAO.instance = value; }
        }

        private KhoaDAO() { }

        public List<Khoa> GetListKhoa()
        {
            List<Khoa> list = new List<Khoa>();
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetKhoaList");

            foreach (DataRow item in data.Rows)
            {
                Khoa khoa = new Khoa(item);
                list.Add(khoa);
            }
            return list;
        }

        public bool InsertKhoa( string makhoa, string tenkhoa)
        {
            string query = string.Format("insert dbo.KHOA ( MAKHOA, TENKHOA ) values ( N'{0}', N'{1}' )", makhoa, tenkhoa);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateKhoa( string tenkhoa, string makhoa)
        {
            string query = string.Format("update dbo.KHOA set TENKHOA = N'{0}' where MAKHOA = N'{1}' ", tenkhoa, makhoa);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteKhoa(string makhoa)
        {
            GiaoVienDAO.Instance.DeleteGiaoVienByMaKhoa(makhoa);
            LopCNDAO.Instance.DeleteLopCNByMaKhoa(makhoa);
            string query = string.Format(" delete from dbo.KHOA where MAKHOA = N'{0}' ",makhoa );
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}

