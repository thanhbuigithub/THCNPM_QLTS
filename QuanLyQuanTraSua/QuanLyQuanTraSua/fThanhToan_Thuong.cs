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
    public partial class fThanhToan_Thuong : Form
    {
        bool thanhtoanThe = true;
        public fThanhToan_Thuong()
        {
            InitializeComponent();
        }

        private void rbtnCast_CheckedChanged(object sender, EventArgs e)
        {
            thanhtoanThe = false;
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            fDatHang fDatHang = new fDatHang();
            this.Hide();
            fDatHang.ShowDialog();
            fTrangChu.Finish = true;
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            fTrangChu.Finish = true;
            this.Close();
        }

    }
}
