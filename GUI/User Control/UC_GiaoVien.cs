using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyDiemSV.DAO;

namespace QuanLyDiemSV.GUI.User_Control
{
    public partial class UC_GiaoVien : UserControl
    {
        BindingSource giaovienList = new BindingSource();

        public UC_GiaoVien()
        {
            InitializeComponent();
            Load();
        }
        #region Method
        void Load()
        {
            dtgvGiaoVien.DataSource = giaovienList;
            LoadListGiaoVien();
            AddKhoaBinding();
        }
        void LoadListGiaoVien()
        {
            giaovienList.DataSource = GiaoVienDAO.Instance.GetListGiaoVien();
        }
        void AddKhoaBinding()
        {
            //txbMaKhoa.DataBindings.Add(new Binding("Text", dtgvKhoa.DataSource, "MaKhoa", true, DataSourceUpdateMode.Never));
            //txbTenKhoa.DataBindings.Add(new Binding("Text", dtgvKhoa.DataSource, "TenKhoa", true, DataSourceUpdateMode.Never));
        }
        #endregion

    }
}
