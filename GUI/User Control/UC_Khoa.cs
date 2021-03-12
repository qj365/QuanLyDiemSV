using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyDiemSV.DTO;
using QuanLyDiemSV.DAO;

namespace QuanLyDiemSV.GUI.User_Control
{
    public partial class UC_Khoa : UserControl
    {
        BindingSource khoaList = new BindingSource();

        public UC_Khoa()
        {
            InitializeComponent();
            Load();
        }
        #region Method
        void Load()
        {
            dtgvKhoa.DataSource = khoaList;
            LoadListKhoa();
            AddKhoaBinding();
        }
        void LoadListKhoa()
        {
            khoaList.DataSource = KhoaDAO.Instance.GetListKhoa();
        }
        void AddKhoaBinding()
        {
            txbMaKhoa.DataBindings.Add(new Binding("Text",dtgvKhoa.DataSource,"MaKhoa", true, DataSourceUpdateMode.Never));
            txbTenKhoa.DataBindings.Add(new Binding("Text", dtgvKhoa.DataSource, "TenKhoa", true, DataSourceUpdateMode.Never));
        }
        #endregion

        #region Event
        private void btnThemKhoa_Click(object sender, EventArgs e)
        {
            string makhoa = txbMaKhoa.Text;
            string tenkhoa = txbTenKhoa.Text;
            if (KhoaDAO.Instance.InsertKhoa(makhoa, tenkhoa))
            {
                MessageBox.Show("Thêm khoa thành công");
                LoadListKhoa();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm khoa");
            }    
        }

        private void btnSuaKhoa_Click(object sender, EventArgs e)
        {          
            string tenkhoa = txbTenKhoa.Text;
            string makhoa = txbMaKhoa.Text;
            if (KhoaDAO.Instance.UpdateKhoa(tenkhoa, makhoa))
            {
                MessageBox.Show("Sửa khoa thành công");
                LoadListKhoa();
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa khoa");
            }
        }

        private void btnXoaKhoa_Click(object sender, EventArgs e)
        {
            string makhoa = txbMaKhoa.Text;
            if (KhoaDAO.Instance.DeleteKhoa(makhoa))
            {
                MessageBox.Show("Xóa khoa thành công");
                LoadListKhoa();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa khoa");
            }
        }
        #endregion
    }
}
