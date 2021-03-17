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
        public List<SinhVien> SearchSvByTenSv(string tensv, string malopcn)
        {
            List<SinhVien> list = new List<SinhVien>();
            string query = string.Format("select * from SINHVIEN where [dbo].[GetUnsignString](TENSV) like N'%'" +
                "+[dbo].[GetUnsignString](N'{0}')+'%'and[dbo].[GetUnsignString](MALOPCN) " +
                "like N'%' +[dbo].[GetUnsignString](N'{1}') + '%'", tensv, malopcn);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                SinhVien sinhvien = new SinhVien(item);
                list.Add(sinhvien);
            }
            return list;
        }

        public List<SinhVien> SearchSvByTenLop(string malopcn)
        {
            List<SinhVien> list = new List<SinhVien>();
            string query = string.Format("select * from SINHVIEN where [dbo].[GetUnsignString](MALOPCN) " +
                "like N'%'+[dbo].[GetUnsignString](N'{0}')+'%' ", malopcn);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                SinhVien sinhvien = new SinhVien(item);
                list.Add(sinhvien);
            }
            return list;
        }
        public List<SinhVien> GetListSinhVien()
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
        public bool InsertSV(string masv, string tensv, string gioitinh, string ngaysinh, string quequan, string sdt, string malopcn, string gpa)
        {
            string query = string.Format("insert dbo.SINHVIEN ( MASV, TENSV, GIOITINH, NGAYSINH, QUEQUAN, SDT, MALOPCN, GPA ) values" +
                " ( N'{0}', N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}' )", masv, tensv, gioitinh, ngaysinh, quequan, sdt, malopcn, gpa);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateSinhVien(string tensv, string gioitinh, string ngaysinh, string quequan, string sdt, string malopcn, string gpa, string masv)
        {
            string query = string.Format(
            "update dbo.SINHVIEN set  TENSV= N'{0}', GIOITINH=N'{1}', NGAYSINH=N'{2}', QUEQUAN=N'{3}', SDT=N'{4}', MALOPCN=N'{5}', GPA=N'{6}' where MASV = N'{7}' ",
            tensv, gioitinh, ngaysinh, quequan, sdt, malopcn, gpa, masv);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteSinhVien(string masv)
        {
            string query = string.Format(" delete from dbo.SINHVIEN where MASV = N'{0}' ", masv);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

    }
}
