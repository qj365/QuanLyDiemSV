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
using QuanLyDiemSV.DTO;

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
            LoadMalopcnIntoComboBox(cbTenlopcn);
            
        }
        void LoadListSinhVien()
        {
            sinhvienList.DataSource = SinhVienDAO.Instance.GetListSinhVien();
        }
        #endregion

        private void btnThem_Click(object sender, EventArgs e)
        {
            frSinhVien sv = new frSinhVien();
            sv.Show();
        }
        void LoadMalopcnIntoComboBox(ComboBox cb)
        {
            cb.DataSource = LopCNDAO.Instance.GetListLopCN();
            cb.DisplayMember = "TenLopCN";
        }


        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {
            LoadListSinhVien();
        }
        List<SinhVien> SearchSvByTenSv(string tensv, string malopcn)
        {
            List<SinhVien> listSinhVien = SinhVienDAO.Instance.SearchSvByTenSv(tensv, malopcn);
            return listSinhVien;
        }

        List<SinhVien> SearchSvByTenLop(string malopcn)
        {
            List<SinhVien> listSinhVien = SinhVienDAO.Instance.SearchSvByTenLop(malopcn);
            return listSinhVien;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

            if (txbTenSv.Text == "")
            {
                sinhvienList.DataSource = SearchSvByTenLop((cbTenlopcn.SelectedItem as LopCN).MaLopCN);

            }
            else
            {
                sinhvienList.DataSource = SearchSvByTenSv(txbTenSv.Text, (cbTenlopcn.SelectedItem as LopCN).MaLopCN);
            }
        }
    }
}
