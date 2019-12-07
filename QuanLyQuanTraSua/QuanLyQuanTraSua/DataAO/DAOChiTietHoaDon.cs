using QuanLyQuanTraSua.DAO;
using QuanLyQuanTraSua.DataTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
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
        public void DeleteAllDetailBillByIDCustomer(int []res)
        {
            for (int i = 0; i < res.Length; i++)
            { DataProvider.Instance.ExcuteQuery("DELETE CHITIETHOADON WHERE ID_HOADON=" + i);
            }
        }

        public void DeleteAllDetailBillByIDBill(int IDBill)
        {
            DataProvider.Instance.ExcuteNonQuery("DELETE CHITIETHOADON WHERE ID_HOADON = " + IDBill);
        }

        public void InsertNewDetailBill(int idBill, int idProduct, int amount, string note)
        {
            DataProvider.Instance.ExcuteNonQuery("INSERT INTO CHITIETHOADON VALUES (" + idBill + ", " + idProduct +
                                                 ", " + amount + ", '" + note + "')");
        }

        public void DeleteDetailBillByID(int idBill, int idProduct)
        {
            DataProvider.Instance.ExcuteNonQuery("DELETE FROM CHITIETHOADON WHERE ID_HoaDon = " + idBill + " AND ID_Mon = " + idProduct);
        }

        public void UpdateDetailBillAmountByID(int idBill, int idProduct, int amount)
        {
            DataProvider.Instance.ExcuteNonQuery("UPDATE CHITIETHOADON SET SoLuong = " + amount +
                                                 " WHERE ID_HoaDon = " + idBill + " AND ID_Mon = " + idProduct);
        }

    }
}
