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
    }
}

