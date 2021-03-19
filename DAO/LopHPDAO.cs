using QuanLyDiemSV.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemSV.DAO
{
    public class LopHPDAO
    {
        private static LopHPDAO instance; //Ctrl + R + E

        public static LopHPDAO Instance
        {
            get { if (instance == null) instance = new LopHPDAO(); return LopHPDAO.instance; }
            private set { LopHPDAO.instance = value; }
        }

        private LopHPDAO() { }

        public List<LopHP> GetListLopHP()
        {
            List<LopHP> list = new List<LopHP>();
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetLopHPList");

            foreach (DataRow item in data.Rows)
            {
                LopHP lophp = new LopHP(item);
                list.Add(lophp);
            }
            return list;
        }

        public void DeleteLopHPByMaHP(string mahocphan)
        {
            DataProvider.Instance.ExecuteQuery("delete from dbo.LopHP where MAHOCPHAN = " + mahocphan);
        }

        public List<LopHP> SearchLopHPByTenHP(string mahocphan)
        {
            List<LopHP> list = new List<LopHP>();
            string query = string.Format("select * from LOPHP where [dbo].[GetUnsignString](MAHOCPHAN) " +
                "like N'%'+[dbo].[GetUnsignString](N'{0}')+'%' ", mahocphan);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                LopHP lophp = new LopHP(item);
                list.Add(lophp);
            }
            return list;
        }

        public bool InsertLopHP(string malophp, string giangduong, int siso, string mahocphan)
        {
            string query = string.Format("insert into LOPHP(MALOPHP, GIANGDUONG, SISO, MAHOCPHAN) " +
                "values (N'{0}',N'{1}',{2},N'{3}')", malophp, giangduong, siso, mahocphan);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateLopHP(string giangduong, int siso, string mahocphan, string malophp)
        {
            string query = string.Format("update LOPHP set GIANGDUONG=N'{0}',SISO = {1}, MAHOCPHAN=N'{2}'" +
                "where MALOPHP=N'{3}' ", giangduong, siso, mahocphan, malophp);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteLopHP(string malophp)
        {
            DiemSVDAO.Instance.DeleteDiemSVByMaLopHP(malophp);
            string query = string.Format(" delete from dbo.LOPHP where MALOPHP = N'{0}' ", malophp);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

    }
}
