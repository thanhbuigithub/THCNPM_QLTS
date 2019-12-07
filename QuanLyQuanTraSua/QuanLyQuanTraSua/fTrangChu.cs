using QuanLyQuanTraSua.DataA0;
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
    public partial class fTrangChu : Form
    {
        public static Boolean Finish = false;
        public static Int16 mProductID;

        #region method
        void LoadListDrink()     // Tra ve list mon
        {

            //int[] a = DAOTrangChu.Instance.LoadData();
            //for (int i = 0; i < a.Length; i++)
            //{
            //    if (a[i] != 0)
            //        Console.WriteLine(a[i]);
            //}
            //dataGridView1.DataSource = DAOTrangChu.Instance.LoadData();
            List<DTOTrangChu> table = DAOTrangChu.Instance.LoadData();
            foreach (DTOTrangChu item in table)
            {
                Console.WriteLine(item.ID + item.Size + item.TenMon + item.Gia + ' ' + item.KT_BanChay + ' ' + item.KT_DatBiet + item.LinkAnh);  //test
            }

        }

        DTOTrangChu ShowDetail(int id)
        {
            List<DTOTrangChu> table = DAOTrangChu.Instance.LoadData();
            DTOTrangChu temp=null;
            foreach (DTOTrangChu item in table)
            {
                if (item.ID == id)
                {
                    Console.WriteLine(item.ID + item.TenMon + item.Gia + ' ' + item.KT_BanChay + ' ' + item.KT_DatBiet + item.LinkAnh);
                    temp = item;
                }
            }
            return temp;
        }// tra ve thong tin cu the cua mon thong qua id
        #endregion
        #region event
        public fTrangChu()
        {
            InitializeComponent();

            LoadListDrink(); // test danh sach mon bang console.writeline
          // ShowDetail(2); //test id mon  bang console.writeline
        }

        private void fTrangChu_Load(object sender, EventArgs e)
        {
            //Finish = false;
            //populateItem();
            //int vertScrollWidth = SystemInformation.VerticalScrollBarWidth;
            //int hozScrollHeight = SystemInformation.HorizontalScrollBarHeight;
            //panel4.Height = panel4.Height - hozScrollHeight;
            //panel4.Width = panel4.Width - vertScrollWidth;
        }

        private void fTrangChu_Activated(object sender, EventArgs e)
        {
            Finish = false;
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

      
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

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

        private void btnOrder_Click_1(object sender, EventArgs e)
        {
            fDatHang fDatHang = new fDatHang();
            this.Hide();
            fDatHang.ShowDialog();
            this.Show();
        }

        private void btnCustomer_Click_1(object sender, EventArgs e)
        {
            fKhachHang fKhachHang = new fKhachHang();
            this.Hide();
            fKhachHang.ShowDialog();
            this.Show();
        }

        private void btnReport_Click_1(object sender, EventArgs e)
        {
            fBaocao fBaocao = new fBaocao();
            this.Hide();
            fBaocao.ShowDialog();
            this.Show();
        }

        private void btnProduct_Click_1(object sender, EventArgs e)
        {
            fSanPham fSanPham = new fSanPham();
            this.Hide();
            fSanPham.ShowDialog();
            this.Show();
        }

        private void btnSpecNext_Click_1(object sender, EventArgs e)
        {
            int change = fLPSpecial.HorizontalScroll.Value + fLPSpecial.HorizontalScroll.SmallChange * 20;
            fLPSpecial.AutoScrollPosition = new Point(change, 0);
        }

        private void btnSpecPrevious_Click_1(object sender, EventArgs e)
        {
            int change = fLPSpecial.HorizontalScroll.Value - fLPSpecial.HorizontalScroll.SmallChange * 20;
            fLPSpecial.AutoScrollPosition = new Point(change, 0);
        }
        #endregion


    }
}
