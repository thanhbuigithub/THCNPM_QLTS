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
    public partial class fDatHang_MangDi_BenThu3 : Form
    {
        public static string doiTac;
        public fDatHang_MangDi_BenThu3()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void btnVato_Click(object sender, EventArgs e)
        {
            doiTac = "Vato";
        }

        private void btnGrab_Click(object sender, EventArgs e)
        {
            doiTac = "Grab";
        }

        private void btnGoViet_Click(object sender, EventArgs e)
        {
            doiTac = "GoViet";
        }

        private void btnBeamin_Click(object sender, EventArgs e)
        {
            doiTac = "Baemin";
        }
    }
}
