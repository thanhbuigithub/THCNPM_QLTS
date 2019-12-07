using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanTraSua
{
    public partial class fDatHang_MangDi_ShopShip : Form
    {
        public fDatHang_MangDi_ShopShip()
        {
            InitializeComponent();
        }

        private void fDatHang_MangDi_ShopShip_Activated(object sender, EventArgs e)
        {
            if (fTrangChu.Finish)
                this.Close();
        }

        private void fDatHang_MangDi_ShopShip_Load(object sender, EventArgs e)
        {
            btnMangDi.Enabled = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            fDatHang fDatHang = new fDatHang();
            this.Hide();
            fDatHang.ShowDialog();
            fTrangChu.Finish = true;
            this.Close();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            fTrangChu.Finish = true;
            this.Close(); //
        }




    }
}
