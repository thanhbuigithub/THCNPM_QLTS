using QuanLyQuanTraSua.DAO;
using QuanLyQuanTraSua.DataTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanTraSua.DataAO
{
    public class DAOKhachHang
    {
        private static DAOKhachHang instance;

        public static DAOKhachHang Instance {
            get { if (instance == null)
                    DAOKhachHang.instance = new DAOKhachHang();
                return DAOKhachHang.instance;
            }

            private set { DAOKhachHang.instance = value; } }

        private DAOKhachHang() { }

        public List<DTOKhachHang> LoadData()
        {
            List<DTOKhachHang> tableList = new List<DTOKhachHang>();
            DataTable data = DataProvider.Instance.ExcuteQuery("USP_GetListCustomer");
            foreach (DataRow item in data.Rows)
            {
                DTOKhachHang table = new DTOKhachHang(item);
                //if (item["NgaySinh"].ToString().Length != 0)
                //{
                //    Console.WriteLine(Convert.ToDateTime(item["NgaySinh"].ToString()));
                //}
                tableList.Add(table);  //ngay sinh null se in ra 1/1/0001
            }
            return tableList;
        }
        
        public bool insertCustomer(string name,string phone,string mail,string address,float point, DateTime birthday)
        {

            string query = String.Format("INSERT INTO KHACHHANG VALUES (N'{0}',N'{1}','{2}','{3}',{4},'{5}',{6})",name,address,birthday,phone,1,mail,point);
            int res = DataProvider.Instance.ExcuteNonQuery(query);
            return res > 0;
        }

        public bool upadateCustomer(string name, string phone, string mail, string address, float point, int id,DateTime birthday)
        { 

            string query = String.Format("UPDATE KHACHHANG SET HoTen=N'{0}',DiaChi=N'{1}',NgaySinh='{2}',SDT='{3}',LoaiKH={4},Email='{5}',DiemTichLuy={6} WHERE ID={7}", name, address,birthday, phone, 1, mail, point,id);
            int res = DataProvider.Instance.ExcuteNonQuery(query);// tra ve so dong duoc update, neu >0 la update thanh cong
            return res > 0;
        }

        public bool deleteCustomer(int id)
        {
            DAOHoaDon.Instance.DeleteBillByIdCustomer(id); //xoa bang hoa don chua id khach hang khi xoa khach ahng nay
            string query = String.Format("DELETE KHACHHANG WHERE ID={0}",id);
            int res = DataProvider.Instance.ExcuteNonQuery(query); // tra ve so dong bi xoa
            return res > 0;
        }
    }
}
