﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanTraSua
{
    public partial class fThanhToan : Form
    {
        public fThanhToan()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rbtnNormalCustomer_CheckedChanged(object sender, EventArgs e)
        {
            fThanhToan_Thuong fThanhToan_Thuong = new fThanhToan_Thuong();
            this.Hide();
            fThanhToan_Thuong.ShowDialog();
            this.Show();
        }

        private void btnCloseCuctomer_Click(object sender, EventArgs e)
        {
            fThanhToan_ThanhVien fThanhToan_ThanhVien = new fThanhToan_ThanhVien();
            this.Hide();
            fThanhToan_ThanhVien.ShowDialog();
            this.Show();
        }

        private void btnMangDi_Click(object sender, EventArgs e)
        {

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            fTrangChu fTrangChu = new fTrangChu();
            this.Hide();
            fTrangChu.ShowDialog();
            fTrangChu.Finish = true; 
            this.Close(); //
        }

        private void btnNormalCustomer_Click(object sender, EventArgs e)
        {
            fThanhToan_Thuong fThanhToan_Thuong = new fThanhToan_Thuong();
            this.Hide();
            fThanhToan_Thuong.ShowDialog();
            this.Show();
        }

        private void fThanhToan_Load(object sender, EventArgs e)
        {
            btnThanhToan.Enabled = false;
        }

        private void fThanhToan_Activated(object sender, EventArgs e)
        {
            if (fTrangChu.Finish)
                this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
