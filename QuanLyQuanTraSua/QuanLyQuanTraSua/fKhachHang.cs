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
    public partial class fKhachHang : Form
    {
        #region method
        void ShowListCustomer()
        {
            List<DTOKhachHang> table = DAOKhachHang.Instance.LoadData();
          //  dataGridView1.DataSource = table;
            foreach(DTOKhachHang item in table)
            {
                Console.WriteLine(item.ID + item.HoTen + item.NgaySinh + item.LoaiKH + item.Sdt + item.DiaChi + item.DiemTichLuy);
            }
                
        }
        DTOKhachHang GetCustomerById(int id)
        {
            List<DTOKhachHang> table = DAOKhachHang.Instance.LoadData();
            DTOKhachHang temp = null;
            foreach(DTOKhachHang item in table)
            {
                if(item.ID==id)
                {
                    temp = item;
                }
            }
            return temp;
        }
        
        #endregion
        #region event
        public fKhachHang()
        {
            InitializeComponent();
            ShowListCustomer();//test list customer bang cach in ra

            //Console.WriteLine(GetCustomerById(2).HoTen);// In ra ho ten cua khach hang co id la 2
        }

        private void fKhachHang_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddCloseCustomer_Click_1(object sender, EventArgs e)
        {
            fKhachhang_ThemSua fKhachHang_themsua = new fKhachhang_ThemSua();
            this.Hide();
            fKhachHang_themsua.ShowDialog();
            this.Show();
        }

        #endregion

        private void Button1_Click(object sender, EventArgs e)// Chinh du lieu de sua
        {
            string name = "Hà Duy Tân".ToString();//neu co du lieu tu user nhap vao thi lay du lieu ra gan vao name, tuong tu cho du lieu khac
            string sdt = "0918975845".ToString();
            DateTime birthday = Convert.ToDateTime("1999-08-07");
            string mail = "dreamleage1999@gmail.com".ToString();
            string address = "Đồng Tháp".ToString();
            float point = 100;
            if (DAOKhachHang.Instance.upadateCustomer(name, sdt, mail, address, point, 12, birthday)) //11 sau nay se thay bang id khach hang
            {
                MessageBox.Show("Sửa thông tin khách hàng thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Sửa thông tin khách hàng thất bại");
                this.Close();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (DAOKhachHang.Instance.deleteCustomer(12))//11 la id khach hang, sau nay muon xoa se lay id thay vao 11
            {
                MessageBox.Show("Xóa thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
                this.Close();
            }
        }

       
    }
}
