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
        }


        private void btnBenThu3_Click(object sender, EventArgs e)
        {
            fDatHang_MangDi_BenThu3 fDatHangMangDiBenThu3 = new fDatHang_MangDi_BenThu3();
            this.Hide();
            fDatHangMangDiBenThu3.ShowDialog();
            this.Show();
        }

        private void btnQuan_Click(object sender, EventArgs e)
        {
            fDatHang_MangDi_ShopShip fDatHangMangDiShopShip = new fDatHang_MangDi_ShopShip();
            this.Hide();
            fDatHangMangDiShopShip.ShowDialog();
            this.Show();
        }

        private void fDatHang_MangDi_Activated(object sender, EventArgs e)
        {
            if (fTrangChu.Finish)
                this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMangDi_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            fTrangChu fTrangChu = new fTrangChu();
            this.Hide();
            fTrangChu.ShowDialog();
            fTrangChu.Finish = true; //
            this.Close(); //

        }
    }
}
