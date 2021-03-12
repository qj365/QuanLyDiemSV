using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyDiemSV.DAO;

namespace QuanLyDiemSV.GUI.User_Control
{
    public partial class UC_HocPhan : UserControl
    {
        BindingSource hocphanList = new BindingSource();

        public UC_HocPhan()
        {
            InitializeComponent();
            Load();
        }
        #region Method
        void Load()
        {
            dtgvHocPhan.DataSource = hocphanList;
            LoadListHocPhan();
            AddKhoaBinding();
        }
        void LoadListHocPhan()
        {
            hocphanList.DataSource = HocPhanDAO.Instance.GetListHocPhan();
        }
        void AddKhoaBinding()
        {
            //txbMaKhoa.DataBindings.Add(new Binding("Text", dtgvKhoa.DataSource, "MaKhoa", true, DataSourceUpdateMode.Never));
            //txbTenKhoa.DataBindings.Add(new Binding("Text", dtgvKhoa.DataSource, "TenKhoa", true, DataSourceUpdateMode.Never));
        }
        #endregion
    }
}
