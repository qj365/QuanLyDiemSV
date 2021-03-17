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
        public bool InsertGV(string magv, string tengv, string gioitinh, string ngaysinh, string diachi, string sdt, string matkhau, string makhoa)
        {
            string query = string.Format("insert dbo.GIAOVIEN ( MAGV, TENGV, GIOITINH, NGAYSINH, DIACHI, SDT, MATKHAU, MAKHOA ) values" +
                " ( N'{0}', N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}' )", magv, tengv, gioitinh, ngaysinh, diachi, sdt, matkhau, makhoa);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateGiaoVien(string tengv, string gioitinh, string ngaysinh, string diachi, string sdt, string matkhau, string makhoa, string magv)
        {
            string query = string.Format("update dbo.GIAOVIEN set  TENGV= N'{0}',GIOITINH=N'{1}',NGAYSINH=N'{2}',DIACHI=N'{3}',SDT=N'{4}',MATKHAU=N'{5}',MAKHOA=N'{6}' where MAGV = N'{7}' ",
                 tengv, gioitinh, ngaysinh, diachi, sdt, matkhau, makhoa, magv);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteGiaoVien(string magv)
        {
            LopCNDAO.Instance.DeleteLopCNByMaGV(magv);
            string query = string.Format(" delete from dbo.GIAOVIEN where MAGV = N'{0}' ", magv);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public List<GiaoVien> SearchGvByTenGv(string tengv, string makhoa)
        {
            List<GiaoVien> list = new List<GiaoVien>();
            string query = string.Format("select * from GIAOVIEN where [dbo].[GetUnsignString](TENGV) like N'%'" +
                "+[dbo].[GetUnsignString](N'{0}')+'%'and[dbo].[GetUnsignString](MAKHOA) " +
                "like N'%' +[dbo].[GetUnsignString](N'{1}') + '%'", tengv, makhoa);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                GiaoVien giaovien = new GiaoVien(item);
                list.Add(giaovien);
            }
            return list;
        }

        public List<GiaoVien> SearchGvByTenKhoa(string makhoa)
        {
            List<GiaoVien> list = new List<GiaoVien>();
            string query = string.Format("select * from GIAOVIEN where [dbo].[GetUnsignString](MAKHOA) " +
                "like N'%'+[dbo].[GetUnsignString](N'{0}')+'%' ", makhoa);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                GiaoVien giaovien = new GiaoVien(item);
                list.Add(giaovien);
            }
            return list;
        }
    }
}
