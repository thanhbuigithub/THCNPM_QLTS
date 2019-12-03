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
    public partial class fDatHang_MangDi : Form
    {
        public fDatHang_MangDi()
        {
            InitializeComponent();
        }

        private void fDatHang_MangDi_Load(object sender, EventArgs e)
        {
            btnMangDi.Enabled = false;

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            fThanhToan fThanhToan = new fThanhToan();
            this.Close();
            fThanhToan.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBenThu3_Click(object sender, EventArgs e)
        {
            fDatHang_MangDi_BenThu3 fDatHangMangDiBenThu3 = new fDatHang_MangDi_BenThu3();
            fDatHangMangDiBenThu3.ShowDialog();
        }

        private void btnQuan_Click(object sender, EventArgs e)
        {
            fDatHang_MangDi_ShopShip fDatHangMangDiShopShip = new fDatHang_MangDi_ShopShip();
            fDatHangMangDiShopShip.ShowDialog();
        }

        private void fDatHang_MangDi_Activated(object sender, EventArgs e)
        {
            if (fTrangChu.Finish)
                this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
