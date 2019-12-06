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
    public class DAOTinhTrangKho
    {
        private static DAOTinhTrangKho instance;

        public static DAOTinhTrangKho Instance
        {
            get
            {
                if (instance == null)
                    DAOTinhTrangKho.instance = new DAOTinhTrangKho();
                return DAOTinhTrangKho.instance;
            }

            private set { DAOTinhTrangKho.instance = value; }
        }

        private DAOTinhTrangKho() { }

        public bool insertMaterial(string name, string address, DateTime date,string status)
        {

            string query = String.Format("INSERT INTO NGUYENLIEU VALUES (N'{0}',N'{1}','{2}',N'{3}')", name, address, date,status);
            int res = DataProvider.Instance.ExcuteNonQuery(query);
            return res > 0;
        }

        public bool updateMaterial(string name, string address, DateTime date, string status,int id)
        {

            string query = String.Format("UPDATE NGUYENLIEU SET TenNguyenLieu=N'{0}',XuatXu=N'{1}',NgayNhap='{2}',TinhTrang='{3}' WHERE ID={4}", name, address, date,status, id);
            int res = DataProvider.Instance.ExcuteNonQuery(query);// tra ve so dong duoc update, neu >0 la update thanh cong
            return res > 0;
        }
        public List<DTOTinhTrangKho> LoadData()
        {
            List<DTOTinhTrangKho> tableList = new List<DTOTinhTrangKho>();
            DataTable data = DataProvider.Instance.ExcuteQuery("USP_GetListMaterial");
            foreach (DataRow item in data.Rows)
            {
                DTOTinhTrangKho table = new DTOTinhTrangKho(item);
                tableList.Add(table);
            }
            return tableList;
        }
    }
}
