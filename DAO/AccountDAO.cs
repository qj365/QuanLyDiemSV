using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemSV.DAO
{
    class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        { 
            get { if (instance == null) instance = new AccountDAO();return instance; }
            private set { instance = value; }
        }
        private AccountDAO() { }
        public bool Login(string username,string password)
        {
            string q = "select * from GIAOVIEN where MAGV = '"+@username+"' and MATKHAU = '"+@password+"'";
            DataTable s = DataProvider.Instance.executeQuery(q,new object[] { username, password });
            return s.Rows.Count > 0;
        }
    }
}
