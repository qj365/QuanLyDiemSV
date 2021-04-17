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
using ClosedXML.Excel;

namespace QuanLyDiemSV.GUI.User_Control
{
    public partial class UC_DiemSV : UserControl
    {
        BindingSource diemsvList = new BindingSource();
        public UC_DiemSV()
        {
            InitializeComponent();
            Load();
        }

        private void btnTuyChon_Click(object sender, EventArgs e)
        {
            using (frBangDiemCT bdct = new frBangDiemCT())
            {
                bdct.ShowDialog();
            }
        }
        void LoadMaSVIntoComboBox(ComboBox cb)
        {
            cb.DataSource = SinhVienDAO.Instance.GetListSinhVien();
            cb.DisplayMember = "TenSV";
        }
        void LoadMaLopHPIntoComboBox(ComboBox cb)
        {
            cb.DataSource = LopHPDAO.Instance.GetListLopHP();
            cb.DisplayMember = "MaLopHP";
        }
        void LoadListDiemSV()
        {
            diemsvList.DataSource = DiemSVDAO.Instance.GetListDiemSV();
        }
        void Load()
        {
            dtgvDiemSV.DataSource = diemsvList;
            LoadListDiemSV();
            LoadMaSVIntoComboBox(cbFindSV);
            LoadMaLopHPIntoComboBox(cbFindLopHP);
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            LoadListDiemSV();
        }
        List<DiemSV> SearchDiemSVByMaSV(string masv)
        {
            List<DiemSV> listDiemSV = DiemSVDAO.Instance.SearchDiemSVByMaSV(masv);
            return listDiemSV;
        }

        List<DiemSV> SearchDiemSVByMaLopHP(string malophp)
        {
            List<DiemSV> listDiemSV = DiemSVDAO.Instance.SearchDiemSVByMaLopHP(malophp);
            return listDiemSV;
        }

        private void btnFindLopHP_Click(object sender, EventArgs e)
        {
            diemsvList.DataSource = SearchDiemSVByMaLopHP((cbFindLopHP.SelectedItem as LopHP).MaLopHP);
        }

        private void btnFindSV_Click(object sender, EventArgs e)
        {
            diemsvList.DataSource = SearchDiemSVByMaSV((cbFindSV.SelectedItem as SinhVien).MaSV);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            using (frDiemExcel save = new frDiemExcel())
            {
                save.ShowDialog();
            }
        }
    }
}
