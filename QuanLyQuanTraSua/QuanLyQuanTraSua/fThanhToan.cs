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
    public partial class fThanhToan : Form
    {
        bool normalCustomer;
        public fThanhToan()
        {
            InitializeComponent();
        }

        private void fThanhToan_Load(object sender, EventArgs e)
        {
            btnThanhToan.Enabled = false;
        }

        private void fThanhToan_Activated(object sender, EventArgs e)
        {
            if (fTrangChu.Finish)
                this.Close();
        }

        private void btnCloseCuctomer_Click(object sender, EventArgs e)
        {
            fThanhToan_ThanhVien fThanhToan_ThanhVien = new fThanhToan_ThanhVien();
            this.Hide();
            fThanhToan_ThanhVien.ShowDialog();
            this.Show();
        }


        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCloseCuctomer_Click_1(object sender, EventArgs e)
        {
            normalCustomer = false;
        }

        private void buttonModified1_Click(object sender, EventArgs e)
        {
            normalCustomer = true;
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            if (normalCustomer)
            {
                fThanhToan_Thuong fThanhToan_thuong = new fThanhToan_Thuong();
                fThanhToan_thuong.ShowDialog();
            }
            else
            {
                fThanhToan_ThanhVien fThanhToan_thanhvien = new fThanhToan_ThanhVien();
                fThanhToan_thanhvien.ShowDialog();
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            fTrangChu.Finish = true;
            this.Close(); //
        }


    }
}
