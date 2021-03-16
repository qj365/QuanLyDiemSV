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
using QuanLyDiemSV.DTO;

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
        void Load()
        {

            dtgvGiaoVien.DataSource = giaovienList;
            LoadListGiaoVien();
            LoadMaKhoaIntoComboBox(cbKhoa);

        }
        void LoadMaKhoaIntoComboBox(ComboBox cb)
        {
            cb.DataSource = KhoaDAO.Instance.GetListKhoa();
            cb.DisplayMember = "TenKhoa";
        }
        
         

        void LoadListGiaoVien()
        {
            giaovienList.DataSource = GiaoVienDAO.Instance.GetListGiaoVien();
        }

        

        private void btnThem_Click(object sender, EventArgs e)
        {
            frGiaoVien gv = new frGiaoVien();
            gv.Show();


        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            LoadListGiaoVien();
        }
        List<GiaoVien> SearchGvByTenGv(string tengv, string makhoa)
        {
            List<GiaoVien> listGiaoVien = GiaoVienDAO.Instance.SearchGvByTenGv(tengv, makhoa);
            return listGiaoVien;
        }

        List<GiaoVien> SearchGvByTenKhoa(string makhoa)
        {
            List<GiaoVien> listGiaoVien = GiaoVienDAO.Instance.SearchGvByTenKhoa(makhoa);
            return listGiaoVien;
        }



        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {

            if (txbTengv.Text == "")
            {
                giaovienList.DataSource = SearchGvByTenKhoa((cbKhoa.SelectedItem as Khoa).MaKhoa);

            }
            else
            {
                giaovienList.DataSource = SearchGvByTenGv(txbTengv.Text, (cbKhoa.SelectedItem as Khoa).MaKhoa);
            }
        }
    }
}
