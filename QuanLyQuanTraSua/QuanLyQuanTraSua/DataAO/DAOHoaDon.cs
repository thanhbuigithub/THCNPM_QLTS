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
    public class DAOHoaDon
    {
        private static DAOHoaDon instance;

        public static DAOHoaDon Instance
        {
            get
            {
                if (instance == null)
                    DAOHoaDon.instance = new DAOHoaDon();
                return DAOHoaDon.instance;
            }
            set { DAOHoaDon.instance = value; }
        }
        private DAOHoaDon() { }
        public void DeleteBillByIdCustomer(int id)
        {
            DataTable x = DataProvider.Instance.ExcuteQuery("SELECT ID FROM HOADON WHERE ID_KhachHang=" + id);
            int []res = new int[100];
            int dem = 0;
            foreach(DataRow i in x.Rows)
            {
                res[dem] = (int)i["ID"];
            }
            Console.WriteLine(res);
            DAOChiTietHoaDon.Instance.DeleteDetailBill(res);
            string query = "DELETE HOADON WHERE ID_KhachHang="+id;
            DataProvider.Instance.ExcuteQuery(query);
        }


       

    }
}
