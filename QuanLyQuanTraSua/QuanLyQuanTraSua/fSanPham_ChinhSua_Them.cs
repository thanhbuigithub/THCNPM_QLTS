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
    public partial class fSanPham_ChinhSua_Them : Form
    {
        public fSanPham_ChinhSua_Them()
        {
            InitializeComponent();
        }

        private void lbSize_Click(object sender, EventArgs e)
        {

        }

        private void rbBestSeller_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdSpecial_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbNormal_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnBackMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStatusProduct_Click(object sender, EventArgs e)
        {
            fTinhTrangKho fTinhtrangkho = new fTinhTrangKho();
            this.Hide();
            fTinhtrangkho.ShowDialog();
            this.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {

        }
    }
}
