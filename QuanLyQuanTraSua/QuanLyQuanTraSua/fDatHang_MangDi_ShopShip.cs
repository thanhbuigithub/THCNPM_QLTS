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

        private void btnTiep_Click(object sender, EventArgs e)
        {
            fDatHang fDatHang = new fDatHang();
            this.Hide();
            fDatHang.ShowDialog();
            this.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            fTrangChu.Finish = true; 
            this.Close(); //
        }

        private void fDatHang_MangDi_ShopShip_Load(object sender, EventArgs e)
        {
            btnMangDi.Enabled = false;
        }

        private void fDatHang_MangDi_ShopShip_Activated(object sender, EventArgs e)
        {
            if (fTrangChu.Finish)
                this.Close();
        }
    }
}
