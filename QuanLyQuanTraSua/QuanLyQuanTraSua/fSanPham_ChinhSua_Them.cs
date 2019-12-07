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
    public partial class fSanPham_ChinhSua_Them : Form
    {
        public fSanPham_ChinhSua_Them()
        {
            InitializeComponent();
        }

        private void lbSize_Click(object sender, EventArgs e)
        {

        }

        private void rbBestSeller_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdSpecial_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbNormal_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnStatusProduct_Click_1(object sender, EventArgs e)
        {
            fTinhTrangKho fTinhtrangkho = new fTinhTrangKho();
            this.Hide();
            fTinhtrangkho.ShowDialog();
            this.Show();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            fTrangChu.Finish = true;
            this.Close();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            string name = txtbName.Text.ToString();
            string link = txtbPictureLink.Text.ToString();
            float price_S = float.Parse(txtbSizeS.Text.ToString());
            float price_M = float.Parse(txtbSizeS.Text.ToString());
            float price_L = float.Parse(txtbSizeS.Text.ToString());
            int check_spec = 0;
            int check_trend = 0;
            if (rbNormal.Checked)
            {
                check_spec = 0;
                check_trend = 0;
            }
            else if (rbBestSeller.Checked)
            {
                check_trend = 1;
                check_spec = 0;
            }
            else
            {
                check_spec = 1;
                check_trend = 0;
            }
            // Console.WriteLine(name + link + price_S + check_trend + check_spec);
            if (DAOSanPham.Instance.insertProduct(name, "S", price_S, check_spec, check_trend, link) && DAOSanPham.Instance.insertProduct(name, "M", price_M, check_spec, check_trend, link)
                && DAOSanPham.Instance.insertProduct(name, "L", price_L, check_spec, check_trend, link))
            {
                MessageBox.Show("Thêm món thành công");

                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm món thất bại");
                this.Close();

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonModified1_Click(object sender, EventArgs e)
        {
            string name = txtbName.Text.ToString();
            string link = txtbPictureLink.Text.ToString();
            float price_S = float.Parse(txtbSizeS.Text.ToString());
            float price_M = float.Parse(txtbSizeS.Text.ToString());
            float price_L = float.Parse(txtbSizeS.Text.ToString());
            int check_spec = 0;
            int check_trend = 0;
            if (rbNormal.Checked)
            {
                check_spec = 0;
                check_trend = 0;
            }
            else if (rbBestSeller.Checked)
            {
                check_trend = 1;
                check_spec = 0;
            }
            else
            {
                check_spec = 1;
                check_trend = 0;
            }
            // Console.WriteLine(name + link + price_S + check_trend + check_spec);
            if (DAOSanPham.Instance.insertProduct(name, "S", price_S, check_spec, check_trend, link) && DAOSanPham.Instance.insertProduct(name, "M", price_M, check_spec, check_trend, link)
                && DAOSanPham.Instance.insertProduct(name, "L", price_L, check_spec, check_trend, link))
            {
                MessageBox.Show("Thêm món thành công");

                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm món thất bại");
                this.Close();

            }
        }
    }
}
