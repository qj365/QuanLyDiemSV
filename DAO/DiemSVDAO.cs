using QuanLyDiemSV.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemSV.DAO
{
    public class DiemSVDAO
    {
        private static DiemSVDAO instance; //Ctrl + R + E
        public static DiemSVDAO Instance
        {
            get { if (instance == null) instance = new DiemSVDAO(); return DiemSVDAO.instance; }
            private set { DiemSVDAO.instance = value; }
        }
        private DiemSVDAO() { }
        public List<DiemSV> GetListDiemSV()
        {
            List<DiemSV> list = new List<DiemSV>();
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetDiemSVList");

            foreach (DataRow item in data.Rows)
            {
                DiemSV diemsv = new DiemSV(item);
                list.Add(diemsv);
            }
            return list;
        }
        public bool InsertDiemSV(string masv, string malophp, double diemcc, double diemtx, double diemthi)
        {
            string query = string.Format("insert dbo.BANGDIEMCT ( MASV, MALOPHP, DIEMCC, DIEMTX, DIEMTHI ) values" +
                " ( N'{0}', N'{1}',{2},{3},{4})", masv, malophp, diemcc, diemtx, diemthi);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateDiemSV( double diemcc, double diemtx, double diemthi, string malophp, string masv)
        {
            string query = string.Format("update dbo.BANGDIEMCT set  DIEMCC={0},DIEMTX={1},DIEMTHI={2}, MALOPHP=N'{3}'" +
                "where MASV=N'{4}'", diemcc, diemtx, diemthi, malophp, masv);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteDiemSV(string masv)
        {

            string query = string.Format(" delete from dbo.BANGDIEMCT where MASV = N'{0}' ", masv);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public List<DiemSV> SearchDiemSVByMaSV(string masv)
        {
            List<DiemSV> list = new List<DiemSV>();
            string query = string.Format("select * from BANGDIEMCT where [dbo].[GetUnsignString](MASV) " +
                "like N'%'+[dbo].[GetUnsignString](N'{0}')+'%' ", masv);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                DiemSV diemsv = new DiemSV(item);
                list.Add(diemsv);
            }
            return list;
        }
        public List<DiemSV> SearchDiemSVByMaLopHP(string malophp)
        {
            List<DiemSV> list = new List<DiemSV>();
            string query = string.Format("select * from BANGDIEMCT where [dbo].[GetUnsignString](MALOPHP) " +
                "like N'%'+[dbo].[GetUnsignString](N'{0}')+'%' ", malophp);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                DiemSV diemsv = new DiemSV(item);
                list.Add(diemsv);
            }
            return list;
        }
        public void DeleteDiemSVByMaLopHP(string malophp)
        {
            DataProvider.Instance.ExecuteQuery("delete from dbo.BANGDIEMCT where MALOPHP = " + malophp);
        }

        public void DeleteDiemSvByMaSV(string masv)
        {
            DataProvider.Instance.ExecuteQuery("delete from dbo.BANGDIEMCT where MASV = " + masv);
        }
    }
}
