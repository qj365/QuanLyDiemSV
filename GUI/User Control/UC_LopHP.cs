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
    public partial class UC_LopHP : UserControl
    {
        BindingSource lophpList = new BindingSource();
        public UC_LopHP()
        {
            InitializeComponent();
            Load();
        }
        void Load()
        {
            dtgvLopHP.DataSource = lophpList;
            LoadListLopHP();
            LoadMaHPIntoComboBox(cbHP);
            LoadMaHPIntoComboBox(cbFindTenHP);
            AddLopHPBinding();
        }
        void LoadMaHPIntoComboBox(ComboBox cb)
        {
            cb.DataSource = HocPhanDAO.Instance.GetListHocPhan();
            cb.DisplayMember = "TenHocPhan";
        }
        void LoadListLopHP()
        {
            lophpList.DataSource = LopHPDAO.Instance.GetListLopHP();
        }
        void AddLopHPBinding()
        {
            txbMaLopHP.DataBindings.Add(new Binding("Text", dtgvLopHP.DataSource, "MaLopHP", true, DataSourceUpdateMode.Never));
            txbGD.DataBindings.Add(new Binding("Text", dtgvLopHP.DataSource, "GiangDuong", true, DataSourceUpdateMode.Never));
            txbSiSo.DataBindings.Add(new Binding("Text", dtgvLopHP.DataSource, "SiSo", true, DataSourceUpdateMode.Never));           
        }

        private void txbMaLopHP_TextChanged(object sender, EventArgs e)
        {
                if (dtgvLopHP.SelectedCells.Count > 0)
                {

                    string mahocphan = Convert.ToString(dtgvLopHP.SelectedCells[0].OwningRow.Cells["MaHocPhan"].Value);
                    HocPhan hocphan = HocPhanDAO.Instance.GetHPByMaHP(mahocphan);
                    cbHP.SelectedItem = mahocphan;
                    int index = -1;
                    int i = 0;
                    foreach (HocPhan item in cbHP.Items)
                    {
                        if (item.MaHocPhan == hocphan.MaHocPhan)
                        {
                            index = i;
                            break;
                        }
                        i++;
                    }
                    cbHP.SelectedIndex = index;
                }
        }


        List<LopHP> SearchLopHPByTenHP(string mahocphan)
        {
            List<LopHP> listLopHP = LopHPDAO.Instance.SearchLopHPByTenHP(mahocphan);
            return listLopHP;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            lophpList.DataSource = SearchLopHPByTenHP((cbFindTenHP.SelectedItem as HocPhan).MaHocPhan);
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            LoadListLopHP();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string malophp = txbMaLopHP.Text;
            string giangduong = txbGD.Text;
            int siso = Int32.Parse(txbSiSo.Text);
            string mahocphan = (cbHP.SelectedItem as HocPhan).MaHocPhan;
            try
            {
                if (LopHPDAO.Instance.InsertLopHP(malophp, giangduong, siso, mahocphan))
                {
                    MessageBox.Show("Thêm lớp học phần thành công");
                    LoadListLopHP();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi thêm lớp học phần");
                }
            }
            catch
            {

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string malophp = txbMaLopHP.Text;
            string giangduong = txbGD.Text;
            int siso = Int32.Parse(txbSiSo.Text);
            string mahocphan = (cbHP.SelectedItem as HocPhan).MaHocPhan;
            try
            {
                if (LopHPDAO.Instance.UpdateLopHP(giangduong, siso, mahocphan, malophp))
                {
                    MessageBox.Show("Sửa lớp học phần thành công");
                    LoadListLopHP();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi sửa lớp học phần");
                }
            }
            catch
            {

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string malophp = txbMaLopHP.Text;
            try
            {
                if (LopHPDAO.Instance.DeleteLopHP(malophp))
                {
                    MessageBox.Show("Xóa lớp học phần thành công");
                    LoadListLopHP();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi xóa lớp học phần");
                }
            }
            catch
            {

            }
        }
    }
}
