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
    public partial class fDatHang : Form
    {
        public fDatHang()
        {
            InitializeComponent();
        }

        private void btnMangDi_Click(object sender, EventArgs e)
        {
            fDatHang_MangDi fDatHangMangDi = new fDatHang_MangDi();
            this.Hide();
            fDatHangMangDi.ShowDialog();
            this.Show();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            fThanhToan fThanhToan = new fThanhToan();
            fThanhToan.ShowDialog();
            this.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            this.Close(); //
        }

        private void fDatHang_Activated(object sender, EventArgs e)
        {
            if (fTrangChu.Finish)
                this.Close();
        }

        private void fDatHang_Load(object sender, EventArgs e)
        {

        }
    }

}
