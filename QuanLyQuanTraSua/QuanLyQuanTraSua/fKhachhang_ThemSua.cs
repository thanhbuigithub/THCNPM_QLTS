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
    public partial class fKhachhang_ThemSua : Form
    {

        public fKhachhang_ThemSua()
        {
            InitializeComponent();
        }

        private void fKhachhang_ThemSua_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            string name = txtbName.Text.ToString();
            string sdt = txtbPhone.Text.ToString();
            DateTime birthday = dtpDateOfBirth.Value.Date; //ADD VALUE FROM  FORM
            string mail = txtbMail.Text.ToString();
            string address = null;
            float point = float.Parse(txtbAccumulatedPoints.Text.ToString());
            Console.WriteLine(name + sdt + mail + address + point);
            if (DAOKhachHang.Instance.insertCustomer(name, sdt, mail, address, point, birthday))
            {
                MessageBox.Show("Thêm khách hàng thành công");

                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
                this.Close();

            }
        }// sau khi diem xong click "OK" se them vao

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
