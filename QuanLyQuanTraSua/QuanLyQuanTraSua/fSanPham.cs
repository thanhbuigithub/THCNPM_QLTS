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
    public partial class fSanPham : Form
    {
        public fSanPham()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

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

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            fSanPham_ChinhSua_Them fSanPham_ChinhSua_Them = new fSanPham_ChinhSua_Them();
            this.Hide();
            fSanPham_ChinhSua_Them.ShowDialog();
            this.Show();
        }

        private void fSanPham_Activated(object sender, EventArgs e)
        {
            if (fTrangChu.Finish == true)
            {
                this.Close();
            }
        }
    }
}
