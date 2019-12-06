using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanTraSua.DataTO
{
    public class DTOSanPham
    {
        public DTOSanPham(int id, string name, string size, float price, int is_spec, int is_trend, string link)
        {
            this.ID = id;
            this.TenMon = name;
            this.Size = size;
            this.Gia = price;
            this.KT_DacBiet = is_spec;
            this.KT_BanChay = is_trend;
            this.LinkAnh = link;
        }
        public DTOSanPham(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.TenMon = row["TenMon"].ToString();
            this.Size = row["Size"].ToString();
            this.Gia = (float)row["Gia"];
            this.KT_DacBiet = (int)row["KT_DacBiet"];
            this.KT_BanChay = (int)row["KT_BanChay"];
            this.LinkAnh = row["LinkAnh"].ToString();
        }
        private int iD;
        private string tenMon;
        private string size;
        private float gia;
        private int kT_DacBiet;
        private int kT_BanChay;
        private string linkAnh;

        public int ID { get => iD; set => iD = value; }
        public string TenMon { get => tenMon; set => tenMon = value; }
        public string Size { get => size; set => size = value; }
        public float Gia { get => gia; set => gia = value; }
        public int KT_DacBiet { get => kT_DacBiet; set => kT_DacBiet = value; }
        public int KT_BanChay { get => kT_BanChay; set => kT_BanChay = value; }
        public string LinkAnh { get => linkAnh; set => linkAnh = value; }
    }
}
