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
    public partial class fTrangChu : Form
    {
        public static Boolean Finish = false;
        public static Int16 mProductID;
        public fTrangChu()
        {
            InitializeComponent();
        }

        private void fTrangChu_Load(object sender, EventArgs e)
        {
            Finish = false;
            populateItem();
            int vertScrollWidth = SystemInformation.VerticalScrollBarWidth;
            int hozScrollHeight = SystemInformation.HorizontalScrollBarHeight;
            panel4.Height = panel4.Height - hozScrollHeight;
            panel4.Width = panel4.Width - vertScrollWidth;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            fDatHang fDatHang = new fDatHang();
            this.Hide();
            fDatHang.ShowDialog();
            this.Show();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            fKhachHang fKhachHang = new fKhachHang();
            this.Hide();
            fKhachHang.ShowDialog();
            this.Show();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            fSanPham fSanPham = new fSanPham();
            this.Hide();
            fSanPham.ShowDialog();
            this.Show();
        }

        private void fTrangChu_Activated(object sender, EventArgs e)
        {
            Finish = false;
        }

        private void btnSpecNext_Click(object sender, EventArgs e)
        {
            int change = fLPSpecial.HorizontalScroll.Value + fLPSpecial.HorizontalScroll.SmallChange * 20;
            fLPSpecial.AutoScrollPosition = new Point(change, 0);
        }
        private void btnSpecPrevious_Click(object sender, EventArgs e)
        {
            int change = fLPSpecial.HorizontalScroll.Value - fLPSpecial.HorizontalScroll.SmallChange * 20;
            fLPSpecial.AutoScrollPosition = new Point(change, 0);

        }
        private void btnReport_Click(object sender, EventArgs e)
        {
            fBaocao fBaocao = new fBaocao();
            this.Hide();
            fBaocao.ShowDialog();
            this.Show();
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void populateItem()
        {
            Product[] product = new Product[20];
            for (int i = 0; i < product.Length; i++)
            {
                product[i] = new Product();
                product[i].ProductName = "SP " + i.ToString();
                product[i].Image = Image.FromFile(@"E:\Hoc_Tap\Nam_3\CNPM\QLTS\QuanLyQuanTraSua\QuanLyQuanTraSua\img\" + "pic.png");
                fLPSpecial.Controls.Add(product[i]);
            }
        }
        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {

        }

        private void fLPSpecial_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
