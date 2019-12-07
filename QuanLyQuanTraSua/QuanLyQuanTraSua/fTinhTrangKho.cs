using QuanLyQuanTraSua.DataAO;
using QuanLyQuanTraSua.DataTO;
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
    public partial class fTinhTrangKho : Form
    {
        void loadListMaterial()
        {
            List<DTOTinhTrangKho> table = DAOTinhTrangKho.Instance.LoadData();
            foreach (DTOTinhTrangKho item in table)
            {
                Console.WriteLine(item.ID +item.TenNguyenLieu + item.TinhTrang + item.NgayNhap + item.XuatXu + item.TinhTrang);
            }
        }
        DTOTinhTrangKho getMaterialById(int id)
        {
            List<DTOTinhTrangKho> table = DAOTinhTrangKho.Instance.LoadData();
            DTOTinhTrangKho temp = null;
            foreach (DTOTinhTrangKho item in table)
            {
               if(item.ID==id)
                {
                    temp = item;
                }
            }
            return temp;
        }
        public fTinhTrangKho()
        {
            InitializeComponent();
            loadListMaterial();
            //Console.WriteLine(getMaterialById(1).TenNguyenLieu);
        }

        //Thieu sua,xoa cho nguyen lieu
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fThemNguyenLieu fThemNguyenLieu = new fThemNguyenLieu();
            fThemNguyenLieu.ShowDialog();
            this.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
