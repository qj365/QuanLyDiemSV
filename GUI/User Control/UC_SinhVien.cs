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
    public partial class UC_SinhVien : UserControl
    {
        BindingSource sinhvienList = new BindingSource();

        public UC_SinhVien()
        {
            InitializeComponent();
            Load();
        }
        #region Method
        void Load()
        {
            dtgvSinhVien.DataSource = sinhvienList;
            LoadListSinhVien();
        }
        void LoadListSinhVien()
        {
            sinhvienList.DataSource = SinhVienDAO.Instance.GetListLopCN();
        }
        #endregion
    }
}
