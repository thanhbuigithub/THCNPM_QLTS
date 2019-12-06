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
    public class DAOChiTietHoaDon
    {
        private static DAOChiTietHoaDon instance;

        public static DAOChiTietHoaDon Instance {
            get { if (instance == null)
                    DAOChiTietHoaDon.instance = new DAOChiTietHoaDon();


                        return DAOChiTietHoaDon.instance; }
            set { DAOChiTietHoaDon.instance = value; } }
        private DAOChiTietHoaDon() { }
        public void DeleteDetailBill(int []res)
        {
            for (int i = 0; i < res.Length; i++)
            { DataProvider.Instance.ExcuteQuery("DELETE CHITIETHOADON WHERE ID_HOADON=" + i);
            }
        }
       
    }
}
