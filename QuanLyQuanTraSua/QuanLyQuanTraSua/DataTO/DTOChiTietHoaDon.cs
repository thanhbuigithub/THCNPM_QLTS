using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanTraSua.DataTO
{
    class DTOChiTietHoaDon
    {
        public DTOChiTietHoaDon(int idHoaDon, int idMon, int soLuong, string note)
        {
            this.IDHoaDon = idHoaDon;
            this.IDMon = idMon;
            this.SoLuong = soLuong;
            this.Note = note;
        }
        public DTOChiTietHoaDon(DataRow row)
        {
            this.IDHoaDon = (int)row["ID_HoaDon"];
            this.IDMon = (int)row["ID_Mon"];
            this.SoLuong = (int)row["SoLuong"];
            this.Note = row["GhiChu"].ToString();
        }
        private int idHoaDon;
        private int idMon;
        private int soLuong;
        private string note;

        public int IDHoaDon { get => idHoaDon; set => idHoaDon = value; }
        public int IDMon { get => idMon; set => idMon = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public string Note { get => note; set => note = value; }
        
    }
}
