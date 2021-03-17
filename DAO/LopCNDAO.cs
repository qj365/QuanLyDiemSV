using QuanLyDiemSV.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemSV.DAO
{
    public class LopCNDAO
    {
        private static LopCNDAO instance; //Ctrl + R + E

        public static LopCNDAO Instance
        {
            get { if (instance == null) instance = new LopCNDAO(); return LopCNDAO.instance; }
            private set { LopCNDAO.instance = value; }
        }

        private LopCNDAO() { }

        public List<LopCN> GetListLopCN()
        {
            List<LopCN> list = new List<LopCN>();
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetLopCNList");

            foreach (DataRow item in data.Rows)
            {
                LopCN lopcn = new LopCN(item);
                list.Add(lopcn);
            }
            return list;
        }

        //Tim kiem
        public List<LopCN> SearchLopCNByTenLopCN(string tenlopcn, string makhoa)
        {
            List<LopCN> list = new List<LopCN>();
            string query = string.Format("select * from LOPCN where [dbo].[GetUnsignString](TENLOPCN) like N'%'" +
                "+[dbo].[GetUnsignString](N'{0}')+'%'and[dbo].[GetUnsignString](MAKHOA) " +
                "like N'%' +[dbo].[GetUnsignString](N'{1}') + '%'", tenlopcn, makhoa);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                LopCN lopcn = new LopCN(item);
                list.Add(lopcn);
            }
            return list;
        }

        public List<LopCN> SearchLopCNByTenKhoa(string makhoa)
        {
            List<LopCN> list = new List<LopCN>();
            string query = string.Format("select * from LOPCN where [dbo].[GetUnsignString](MAKHOA) " +
                "like N'%'+[dbo].[GetUnsignString](N'{0}')+'%' ", makhoa);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                LopCN lopcn = new LopCN(item);
                list.Add(lopcn);
            }
            return list;
        }

        public void DeleteLopCNByMaKhoa(string makhoa)
        {
            DataProvider.Instance.ExecuteQuery("delete from dbo.LopCN where MAKHOA = " + makhoa);
        }
        public void DeleteLopCNByMaGV(string magv)
        {
            DataProvider.Instance.ExecuteQuery("delete from dbo.LopCN where MAGV = " + magv);
        }

        public bool InsertLopCN(string malopcn, string tenlopcn, int siso, string makhoa, string magv)
        {
            string query = string.Format("insert into LOPCN(MALOPCN, TENLOPCN, SISO, MAKHOA, MAGV) " +
                "values (N'{0}',N'{1}',{2},N'{3}',N'{4}')", malopcn, tenlopcn, siso, makhoa, magv);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateLopCN(string tenlopcn, int siso, string makhoa, string magv, string malopcn)
        {
            string query = string.Format("update LOPCN set TENLOPCN=N'{0}',SISO = {1}, MAKHOA=N'{2}',MAGV=N'{3}' " +
                "where MALOPCN=N'{4}' ", tenlopcn, siso, makhoa, magv, malopcn);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteLopCN(string malopcn)
        {
            SinhVienDAO.Instance.DeleteSinhVienByMaLopCN(malopcn);
            string query = string.Format(" delete from dbo.LOPCN where MALOPCN = N'{0}' ", malopcn);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}




