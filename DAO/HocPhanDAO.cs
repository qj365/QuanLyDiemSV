using QuanLyDiemSV.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public void DeleteHocPhanByMaKhoa(string makhoa)
        {
            DataProvider.Instance.ExecuteQuery("delete from dbo.HOCPHAN where MAKHOA = " + makhoa);
        }
    }
}
