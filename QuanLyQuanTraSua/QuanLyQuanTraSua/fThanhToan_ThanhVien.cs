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
    public partial class fThanhToan_ThanhVien : Form
    {
        public fThanhToan_ThanhVien()
        {
            InitializeComponent();
        }

        private void lbNote_Click(object sender, EventArgs e)
        {

        }

        private void txtbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbtnCloseCustomer_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void fThanhToan_ThanhVien_Load(object sender, EventArgs e)
        {
            btnThanhToan.Enabled = false;
        }

        private void rbtnYes_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            fThanhToan_Thuong fThanhToan_Thuong = new fThanhToan_Thuong();
            this.Hide();
            fThanhToan_Thuong.ShowDialog();
            this.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            fTrangChu fTrangChu = new fTrangChu();
            this.Hide();
            fTrangChu.ShowDialog();
            fTrangChu.Finish = true; 
            this.Close(); //
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMangDi_Click(object sender, EventArgs e)
        {
        }

        private void fThanhToan_ThanhVien_Activated(object sender, EventArgs e)
        {
            if (fTrangChu.Finish)
                this.Close();
        }
    }
}
