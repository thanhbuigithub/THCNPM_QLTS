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

        private void btnNext_Click(object sender, EventArgs e)
        {

            fTrangChu.Finish = true;
            this.Close();
        }

        private void rbtnCast_CheckedChanged(object sender, EventArgs e)
        {
            thanhtoanThe = false;
        }

    }
}
