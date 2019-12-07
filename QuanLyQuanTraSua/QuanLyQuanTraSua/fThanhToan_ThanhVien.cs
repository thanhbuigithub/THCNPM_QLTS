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
        bool Point = true;
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

        }

        private void rbtnYes_CheckedChanged_1(object sender, EventArgs e)
        {
            Point = true;
        }

        private void rbtnNo_CheckedChanged(object sender, EventArgs e)
        {
            Point = false;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            fThanhToan_Thuong fThanhToan_Thuong = new fThanhToan_Thuong();
            this.Hide();
            fThanhToan_Thuong.ShowDialog();
            this.Show();
        }
    }
}
