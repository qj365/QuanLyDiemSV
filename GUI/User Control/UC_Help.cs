using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiemSV
{
    public partial class UC_Help : UserControl
    {
        private int findTabPage { get; set; }
        public UC_Help()
        {
            InitializeComponent();
            PageHelp.SelectTab(0);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            switch(findTabPage)
            {
                case 0: break;
                case 1: PageHelp.SelectTab(0); break;
                case 2: PageHelp.SelectTab(1); break;
                case 3: PageHelp.SelectTab(2); break;
                case 4: PageHelp.SelectTab(3); break;
                case 5: PageHelp.SelectTab(4); break;
                case 6: PageHelp.SelectTab(5); break;
            }    
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            switch (findTabPage)
            {
                case 0: PageHelp.SelectTab(1); break;
                case 1: PageHelp.SelectTab(2); break;
                case 2: PageHelp.SelectTab(3); break;
                case 3: PageHelp.SelectTab(4); break;
                case 4: PageHelp.SelectTab(5); break;
                case 5: PageHelp.SelectTab(6); break;
                case 6: break;
            }
        }

        private void PageHelp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PageHelp.SelectedTab == tabPageKhoa)
                findTabPage = 0;
            if (PageHelp.SelectedTab == tabPageLopCN)
                findTabPage = 1;
            if (PageHelp.SelectedTab == tabPageHP)
                findTabPage = 2;
            if (PageHelp.SelectedTab == tabPageLopHP)
                findTabPage = 3;
            if (PageHelp.SelectedTab == tabPageGV)
                findTabPage = 4;
            if (PageHelp.SelectedTab == tabPageSV)
                findTabPage = 5;
            if (PageHelp.SelectedTab == tabPageDSV)
                findTabPage = 6;
        }
    }
}
