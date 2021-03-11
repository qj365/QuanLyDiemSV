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
        public UC_Khoa()
        {
            InitializeComponent();
            LoadListKhoa();
        }
        #region Method
        void LoadListKhoa()
        {
            dtgvKhoa.DataSource = KhoaDAO.Instance.GetListKhoa();
        }
        #endregion

        #region Event
        #endregion
    }
}
