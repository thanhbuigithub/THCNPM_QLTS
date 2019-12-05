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

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rbtnNormalCustomer_CheckedChanged(object sender, EventArgs e)
        {
            normalCustomer = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbtnNormalCustomer_CheckedChanged_1(object sender, EventArgs e)
        {
            normalCustomer = false;
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            if (normalCustomer)
            {
                fThanhToan_Thuong fThanhToan_thuong = new fThanhToan_Thuong();
                this.Close();
                fThanhToan_thuong.ShowDialog();
                this.Show();
            }
            else
            {
                fThanhToan_ThanhVien fThanhToan_thanhvien = new fThanhToan_ThanhVien();
                this.Close();
                fThanhToan_thanhvien.ShowDialog();
                this.Show();
            }
        }

    }
}
