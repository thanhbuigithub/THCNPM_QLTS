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
    public partial class fDatHang_MangDi_ShopShip : Form
    {
        public fDatHang_MangDi_ShopShip()
        {
            InitializeComponent();
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            fTrangChu.Finish = true;
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
