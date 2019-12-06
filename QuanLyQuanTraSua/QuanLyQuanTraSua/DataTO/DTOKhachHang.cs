using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanTraSua.DataTO
{
    public class DTOKhachHang
    {
        public DTOKhachHang(int id, string name,string address,string phone,string type,string email, float point, DateTime birthday)
        {
            this.ID = id;
            this.HoTen = name;
            this.DiaChi = address;
            this.NgaySinh = birthday;
            this.Sdt = phone;
            this.LoaiKH = type;
            this.Email = email;
            this.DiemTichLuy = point;
        }
        public DTOKhachHang(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.HoTen = row["HoTen"].ToString();
            this.DiaChi = row["DiaChi"].ToString();
            if (row["NgaySinh"].ToString().Length != 0)
            {
                this.NgaySinh = Convert.ToDateTime(row["NgaySinh"].ToString()); // Convert birthday which is not null, null is defined with 1/1/1
            }
            this.Sdt = row["SDT"].ToString();
            this.LoaiKH =row["LoaiKhachHang"].ToString();
            this.Email = row["Email"].ToString();
            this.DiemTichLuy = float.Parse(row["DiemTichLuy"].ToString());
        }
        private int iD;
        private string hoTen;
        private string diaChi;
        private DateTime ngaySinh;
        private string sdt;
        private string loaiKH ;
        private string email;
        private float diemTichLuy;

        public int ID { get => iD; set => iD = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string LoaiKH { get => loaiKH; set => loaiKH = value; }
        public string Email { get => email; set => email = value; }
        public float DiemTichLuy { get => diemTichLuy; set => diemTichLuy = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
    }
}
