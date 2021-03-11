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
    }
}




