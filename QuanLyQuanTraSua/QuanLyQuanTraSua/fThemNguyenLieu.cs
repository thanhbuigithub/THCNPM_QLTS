using QuanLyQuanTraSua.DataAO;
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
    public partial class fThemNguyenLieu : Form
    {
        public fThemNguyenLieu()
        {
            InitializeComponent();
        }

        private void LbName_Click(object sender, EventArgs e)
        {

        }

        private void LbMail_Click(object sender, EventArgs e)
        {

        }

        private void LbDateOfBirth_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDone_Click_1(object sender, EventArgs e)
        {
            string name = txtbName.Text.ToString();
            string address = txtbAddressImport.Text.ToString();
            DateTime date = dtpDateImport.Value.Date;
            if (DAOTinhTrangKho.Instance.insertMaterial(name, address, date, "Còn hàng"))
            {
                MessageBox.Show("Thêm nguyên liệu thành công");

                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
                this.Close();

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
