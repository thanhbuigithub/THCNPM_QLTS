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
    public partial class fDatHang_ChinhSua : Form
    {
        public fDatHang_ChinhSua()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fDatHang_ChinhSua_Load(object sender, EventArgs e)
        {
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            fTrangChu.Finish = true; //
            this.Close(); //
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
            this.Hide();
            fThanhToan.ShowDialog();
            this.Show();
        }

        private void fDatHang_ChinhSua_Activated(object sender, EventArgs e)
        {
            if (fTrangChu.Finish)
                this.Close();
        }
    }
}
