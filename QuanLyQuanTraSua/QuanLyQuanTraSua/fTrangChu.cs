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
    public partial class fTrangChu : Form
    {
        public static Boolean Finish = false;
        public fTrangChu()
        {
            InitializeComponent();
        }

        private void fTrangChu_Load(object sender, EventArgs e)
        {
            Finish = false;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            fDatHang fDatHang = new fDatHang();
            this.Hide();
            fDatHang.ShowDialog();
            this.Show();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            fKhachHang fKhachHang = new fKhachHang();
            this.Hide();
            fKhachHang.ShowDialog();
            this.Show();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            fSanPham fSanPham = new fSanPham();
            this.Hide();
            fSanPham.ShowDialog();
            this.Show();
        }

        private void fTrangChu_Activated(object sender, EventArgs e)
        {
            Finish = false;
        }
    }
}
