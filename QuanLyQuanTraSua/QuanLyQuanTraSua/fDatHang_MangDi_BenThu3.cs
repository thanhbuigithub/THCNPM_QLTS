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
    public partial class fDatHang_MangDi_BenThu3 : Form
    {
        public static string doiTac;
        public fDatHang_MangDi_BenThu3()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void btnVato_Click(object sender, EventArgs e)
        {
            doiTac = "Vato";
        }

        private void btnGrab_Click(object sender, EventArgs e)
        {
            doiTac = "Grab";
        }

        private void btnGoViet_Click(object sender, EventArgs e)
        {
            doiTac = "GoViet";
        }

        private void btnBeamin_Click(object sender, EventArgs e)
        {
            doiTac = "Baemin";
            fDatHang fDatHang = new fDatHang();
            this.Hide();
            fDatHang.ShowDialog();
            this.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            fTrangChu fTrangChu = new fTrangChu();
            this.Hide();
            fTrangChu.ShowDialog();
            fTrangChu.Finish = true; //
            this.Close(); //
        }

        private void btnMangDi_Click(object sender, EventArgs e)
        {

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fDatHang_MangDi_BenThu3_Load(object sender, EventArgs e)
        {
            btnMangDi.Enabled = false;
        }

        private void fDatHang_MangDi_BenThu3_Activated(object sender, EventArgs e)
        {
            if (fTrangChu.Finish)
                this.Close();
        }
    }
}
