using QuanLyDiemSV.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDiemSV.DTO;
namespace QuanLyDiemSV.DAO
{
    public class HocPhanDAO
    {
        private static HocPhanDAO instance; //Ctrl + R + E

        public static HocPhanDAO Instance
        {
            get { if (instance == null) instance = new HocPhanDAO(); return HocPhanDAO.instance; }
            private set { HocPhanDAO.instance = value; }
        }

        private HocPhanDAO() { }

        public List<HocPhan> GetListHocPhan()
        {
            List<HocPhan> list = new List<HocPhan>();
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetHocPhanList");

            foreach (DataRow item in data.Rows)
            {
                HocPhan hocphan = new HocPhan(item);
                list.Add(hocphan);
            }
            return list;
        }
        public HocPhan GetHPByMaHP(string mahocphan)
        {
            HocPhan hocphan = null;
            string query = "select * from HOCPHAN where MAHOCPHAN = " + mahocphan;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                hocphan = new HocPhan(item);
                return hocphan;
            }

            return hocphan;
        }

        public List<HocPhan> SearchHPByTenHP(string tenhocphan, string makhoa)
        {
            List<HocPhan> list = new List<HocPhan>();
            string query = string.Format("select * from HOCPHAN where [dbo].[GetUnsignString](TENHOCPHAN) like N'%'" +
                "+[dbo].[GetUnsignString](N'{0}')+'%'and[dbo].[GetUnsignString](MAKHOA) " +
                "like N'%' +[dbo].[GetUnsignString](N'{1}') + '%'", tenhocphan, makhoa);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                HocPhan hocphan = new HocPhan(item);
                list.Add(hocphan);
            }
            return list;
        }

        public List<HocPhan> SearchHPByTenKhoa(string makhoa)
        {
            List<HocPhan> list = new List<HocPhan>();
            string query = string.Format("select * from HOCPHAN where [dbo].[GetUnsignString](MAKHOA) " +
                "like N'%'+[dbo].[GetUnsignString](N'{0}')+'%' ", makhoa);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                HocPhan hocphan = new HocPhan(item);
                list.Add(hocphan);
            }
            return list;
        }
        public void DeleteHocPhanByMaKhoa(string makhoa)
        {
            DataProvider.Instance.ExecuteQuery("delete from dbo.HOCPHAN where MAKHOA = " + makhoa);
        }
        public bool InsertHocPhan(string mahocphan, string tenhocphan, int sotinchi, int sotiet, string hinhthucthi, string makhoa)
        {
            string query = string.Format("insert into HOCPHAN(MAHOCPHAN, TENHOCPHAN, SOTINCHI, SOTIET, HINHTHUCTHI, MAKHOA) " +
                "values (N'{0}',N'{1}',{2},{3},N'{4}',N'{5}')", mahocphan, tenhocphan, sotinchi, sotiet, hinhthucthi, makhoa);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateHocPhan(string tenhocphan, int sotinchi, int sotiet, string hinhthucthi, string makhoa, string mahocphan)
        {
            string query = string.Format("update HOCPHAN set TENHOCPHAN=N'{0}',SOTINCHI = {1}, SOTIET = {2}, HINHTHUCTHI=N'{3}',MAKHOA=N'{4}' " +
                "where MAHOCPHAN=N'{5}' ", tenhocphan, sotinchi, sotiet, hinhthucthi, makhoa, mahocphan);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteHocPhan(string mahocphan)
        {
            LopHPDAO.Instance.DeleteLopHPByMaHP(mahocphan);
            string query = string.Format(" delete from dbo.HOCPHAN where MAHOCPHAN = N'{0}' ", mahocphan);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
