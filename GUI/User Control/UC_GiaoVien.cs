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
        public UC_GiaoVien()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (frGiaoVien frgv = new frGiaoVien())
            {
                frgv.ShowDialog();
            }
        }
      
    }
}
