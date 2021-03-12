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
    public partial class UC_LopCN : UserControl
    {
        BindingSource lopcnList = new BindingSource();

        public UC_LopCN()
        {
            InitializeComponent();
            Load();
        }
        #region Method
        void Load()
        {
            dtgvLopCN.DataSource = lopcnList;
            LoadListLopCN();
            LoadMaKhoaIntoComboBox(cbEditKhoa);
            AddLopCNBinding();
        }
        void LoadMaKhoaIntoComboBox(ComboBox cb)
        {
            cb.DataSource = KhoaDAO.Instance.GetListKhoa();
            cb.DisplayMember = "TenKhoa";
        }
        void LoadListLopCN()
        {
            lopcnList.DataSource = LopCNDAO.Instance.GetListLopCN();
        }
        void AddLopCNBinding()
        {
            txbEditMaLopCN.DataBindings.Add(new Binding("Text", dtgvLopCN.DataSource, "MaLopCN", true, DataSourceUpdateMode.Never));
            txbTenLopCN.DataBindings.Add(new Binding("Text", dtgvLopCN.DataSource, "TenLopCN", true, DataSourceUpdateMode.Never));
            txbSiSo.DataBindings.Add(new Binding("Text", dtgvLopCN.DataSource, "SiSo", true, DataSourceUpdateMode.Never));
            txbMaGV.DataBindings.Add(new Binding("Text", dtgvLopCN.DataSource, "MaGV", true, DataSourceUpdateMode.Never));
        }

        private void txbEditMaLopCN_TextChange(object sender, EventArgs e)
        {
            try
            {
                if (dtgvLopCN.SelectedCells.Count > 0)
                {

                    string makhoa = Convert.ToString(dtgvLopCN.SelectedCells[0].OwningRow.Cells["MaKhoa"].Value);
                    Khoa khoa = KhoaDAO.Instance.GetKhoaByMaKhoa(makhoa);
                    cbEditKhoa.SelectedItem = khoa;
                    int index = -1;
                    int i = 0;
                    foreach (Khoa item in cbEditKhoa.Items)
                    {
                        if (item.MaKhoa == khoa.MaKhoa)
                        {
                            index = i;
                            break;
                        }
                        i++;
                    }
                    cbEditKhoa.SelectedIndex = index;
                }
            }
            catch
            {

            }    
        }
        #endregion

        #region Event
        private void btnInsertLopCN_Click(object sender, EventArgs e)
        {
            string malopcn = txbEditMaLopCN.Text;
            string tenlopcn = txbTenLopCN.Text;
            string magv = txbMaGV.Text;
            int siso = Int32.Parse(txbSiSo.Text);
            string makhoa = (cbEditKhoa.SelectedItem as Khoa).MaKhoa;
            if (LopCNDAO.Instance.InsertLopCN(malopcn, tenlopcn, siso, makhoa, magv))
            {
                MessageBox.Show("Thêm lớp chuyên ngành thành công");
                LoadListLopCN();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm lớp chuyên ngành");
            }
        }

        private void btnUpdateLopCN_Click(object sender, EventArgs e)
        {
            string malopcn = txbEditMaLopCN.Text;
            string tenlopcn = txbTenLopCN.Text;
            string magv = txbMaGV.Text;
            int siso = Int32.Parse(txbSiSo.Text);
            string makhoa = (cbEditKhoa.SelectedItem as Khoa).MaKhoa;
            if (LopCNDAO.Instance.UpdateLopCN(tenlopcn, siso, makhoa, magv, malopcn))
            {
                MessageBox.Show("Sửa lớp chuyên ngành thành công");
                LoadListLopCN();
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa lớp chuyên ngành");
            }
        }

        private void btnDeleteLopCN_Click(object sender, EventArgs e)
        {
            string malopcn = txbEditMaLopCN.Text;
            if (LopCNDAO.Instance.DeleteLopCN(malopcn))
            {
                MessageBox.Show("Xóa lớp chuyên ngành thành công");
                LoadListLopCN();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa lớp chuyên ngành");
            }
        }

        //Tim kiem
        List<LopCN> SearchLopCNByTenLopCN(string tenlopcn)
        {
            List<LopCN> listLopCN = LopCNDAO.Instance.SearchLopCNByTenLopCN(tenlopcn);
            return listLopCN;
        }
        
        private void btnFindTenLopCN_Click(object sender, EventArgs e)
        {
            lopcnList.DataSource = SearchLopCNByTenLopCN(txbFindLopCN.Text);
        }


        #endregion
    }
}
