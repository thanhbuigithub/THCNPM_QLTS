using QuanLyQuanTraSua.DAO;
using QuanLyQuanTraSua.DataTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanTraSua.DataA0
{
    public class DAOTrangChu
    {
        private static DAOTrangChu instance;

        public static DAOTrangChu Instance {
            get { if (instance == null)
                    instance = new DAOTrangChu();
                return DAOTrangChu.instance; }
            private set { DAOTrangChu.instance = value; } }

        private DAOTrangChu() { }

        //public int[] LoadData()
        //{
        //    string query = "SELECT * FROM MON";
        //    DataTable x = new DataTable();
        //    x = DataProvider.Instance.ExcuteQuery(query);
        //    DataRow[]x1= x.Select();
        //    int[] a = new int[100];
        //    int dem = 0;
        //    for(int i=0;i<x1.Length;i++)
        //    {
        //        //Console.WriteLine(x1[i]["ID"]);
        //        a[i] = Convert.ToInt32(x1[i]["ID"]);
        //        dem++;
        //    }
          
        //    return a;
        //}
        public List<DTOTrangChu>LoadData()
        {
            List<DTOTrangChu> tableList = new List<DTOTrangChu>();
            DataTable data = DataProvider.Instance.ExcuteQuery("USP_GetListDrink");  //Procedure in sql, also can use select *...
            foreach(DataRow item in data.Rows)
            {
                DTOTrangChu table = new DTOTrangChu(item);
                tableList.Add(table);
            }
            return tableList;
        }
    }
}
