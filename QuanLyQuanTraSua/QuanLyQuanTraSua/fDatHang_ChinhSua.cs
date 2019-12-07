using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyQuanTraSua.DataA0;
using QuanLyQuanTraSua.DataAO;
using QuanLyQuanTraSua.DataTO;

namespace QuanLyQuanTraSua
{
    public partial class fDatHang_ChinhSua : Form
    {
        private DTOTrangChu product;
        private Boolean update = false;
        public fDatHang_ChinhSua()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int size = cboBoxSize.SelectedIndex;
            int amount = (int)numericAmount.Value;
            if (size != 0)
            {
                product = DAOTrangChu.Instance.getProductByID(fDatHang.mProductID + size);
            }
            DAOChiTietHoaDon.Instance.InsertNewDetailBill(fDatHang.mBillID, fDatHang.mProductID, amount, txtbNote.Text);
            for (int i = 0; i < amount; i++)
            {
                DetailBill detailBill = new DetailBill();
                detailBill.IDBill = fDatHang.mBillID;
                detailBill.IDProduct = product.ID - size;
                detailBill.Name = product.TenMon;
                detailBill.Price = product.Gia.ToString() + "đ";
                detailBill.Amount = amount;
                detailBill.BtnEdit.Click += editDetailBill;
                detailBill.BtnEdit.Tag = detailBill;
                detailBill.BtnDelete.Click += deleteDetailBill;
                detailBill.BtnDelete.Tag = detailBill;
                fDatHang.flpHoaDon.Controls.Add(detailBill);
            }
            this.Close();
        }

        private void deleteDetailBill(object sender, EventArgs e)
        {
            DetailBill detailBill = (sender as Button).Tag as DetailBill;
            fDatHang.flpHoaDon.Controls.Remove(detailBill);
            if (detailBill.Amount == 1)
            {
                DAOChiTietHoaDon.Instance.DeleteDetailBillByID(detailBill.IDBill, detailBill.IDProduct);
            }
            else
            {
                DAOChiTietHoaDon.Instance.UpdateDetailBillAmountByID(detailBill.IDBill, detailBill.IDProduct,detailBill.Amount-1);
            }
        }

        private void editDetailBill(object sender, EventArgs e)
        {
            DetailBill detailBill = (sender as Button).Tag as DetailBill;
            fDatHang.mProductID = detailBill.IDProduct;
            fDatHang_ChinhSua f = new fDatHang_ChinhSua();
            f.ShowDialog();
        }

        private void fDatHang_ChinhSua_Load(object sender, EventArgs e)
        {
            product = DAOTrangChu.Instance.getProductByID(fDatHang.mProductID);
            pictureBoxProduct.Image = Image.FromFile(@"E:\Hoc_Tap\Nam_3\CNPM\QLTS\QuanLyQuanTraSua\QuanLyQuanTraSua\img\" + product.LinkAnh);
            lbProductName.Text = product.TenMon;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            fTrangChu.Finish = true; //
            this.Close(); //
        }

        private void btnMangDi_Click(object sender, EventArgs e)
        {
            fDatHang_MangDi fDatHangMangDi = new fDatHang_MangDi();
            this.Hide();
            fDatHangMangDi.ShowDialog();
            this.Show();

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            fThanhToan fThanhToan = new fThanhToan();
            this.Hide();
            fThanhToan.ShowDialog();
            this.Show();
        }

        private void fDatHang_ChinhSua_Activated(object sender, EventArgs e)
        {
            if (fTrangChu.Finish)
                this.Close();
        }
    }
}
