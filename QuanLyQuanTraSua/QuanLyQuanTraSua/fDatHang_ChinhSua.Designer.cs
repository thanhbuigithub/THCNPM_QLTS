﻿namespace QuanLyQuanTraSua
{
    partial class fDatHang_ChinhSua
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtbNote = new System.Windows.Forms.TextBox();
            this.cboBoxTopping = new System.Windows.Forms.ComboBox();
            this.cboBoxToppingSugar = new System.Windows.Forms.ComboBox();
            this.lbNote = new System.Windows.Forms.Label();
            this.lbTopping = new System.Windows.Forms.Label();
            this.lbSugar = new System.Windows.Forms.Label();
            this.cboBoxToppingIce = new System.Windows.Forms.ComboBox();
            this.lbIce = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboBoxSmell = new System.Windows.Forms.ComboBox();
            this.cboBoxSize = new System.Windows.Forms.ComboBox();
            this.numericAmount = new System.Windows.Forms.NumericUpDown();
            this.lbSmell = new System.Windows.Forms.Label();
            this.lbSize = new System.Windows.Forms.Label();
            this.lbAmount = new System.Windows.Forms.Label();
            this.lbProductName = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBoxProduct = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lvDonHang = new System.Windows.Forms.ListView();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.lbIDDonHang = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnMangDi = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAmount)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 768);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnAdd);
            this.panel4.Controls.Add(this.btnBack);
            this.panel4.Location = new System.Drawing.Point(11, 674);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(720, 45);
            this.panel4.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(591, 3);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(124, 40);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(0, 2);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(124, 40);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtbNote);
            this.panel3.Controls.Add(this.cboBoxTopping);
            this.panel3.Controls.Add(this.cboBoxToppingSugar);
            this.panel3.Controls.Add(this.lbNote);
            this.panel3.Controls.Add(this.lbTopping);
            this.panel3.Controls.Add(this.lbSugar);
            this.panel3.Controls.Add(this.cboBoxToppingIce);
            this.panel3.Controls.Add(this.lbIce);
            this.panel3.Location = new System.Drawing.Point(16, 216);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(720, 456);
            this.panel3.TabIndex = 6;
            // 
            // txtbNote
            // 
            this.txtbNote.Location = new System.Drawing.Point(128, 199);
            this.txtbNote.Margin = new System.Windows.Forms.Padding(2);
            this.txtbNote.Multiline = true;
            this.txtbNote.Name = "txtbNote";
            this.txtbNote.Size = new System.Drawing.Size(587, 84);
            this.txtbNote.TabIndex = 3;
            // 
            // cboBoxTopping
            // 
            this.cboBoxTopping.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBoxTopping.FormattingEnabled = true;
            this.cboBoxTopping.Items.AddRange(new object[] {
            "0%",
            "25%",
            "50%",
            "75%",
            "100%"});
            this.cboBoxTopping.Location = new System.Drawing.Point(128, 132);
            this.cboBoxTopping.Margin = new System.Windows.Forms.Padding(2);
            this.cboBoxTopping.Name = "cboBoxTopping";
            this.cboBoxTopping.Size = new System.Drawing.Size(587, 34);
            this.cboBoxTopping.TabIndex = 2;
            // 
            // cboBoxToppingSugar
            // 
            this.cboBoxToppingSugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBoxToppingSugar.FormattingEnabled = true;
            this.cboBoxToppingSugar.Items.AddRange(new object[] {
            "0%",
            "25%",
            "50%",
            "75%",
            "100%"});
            this.cboBoxToppingSugar.Location = new System.Drawing.Point(128, 67);
            this.cboBoxToppingSugar.Margin = new System.Windows.Forms.Padding(2);
            this.cboBoxToppingSugar.Name = "cboBoxToppingSugar";
            this.cboBoxToppingSugar.Size = new System.Drawing.Size(587, 34);
            this.cboBoxToppingSugar.TabIndex = 2;
            // 
            // lbNote
            // 
            this.lbNote.AutoSize = true;
            this.lbNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNote.Location = new System.Drawing.Point(2, 199);
            this.lbNote.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNote.Name = "lbNote";
            this.lbNote.Size = new System.Drawing.Size(98, 26);
            this.lbNote.TabIndex = 0;
            this.lbNote.Text = "Ghi Chú:";
            // 
            // lbTopping
            // 
            this.lbTopping.AutoSize = true;
            this.lbTopping.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTopping.Location = new System.Drawing.Point(2, 135);
            this.lbTopping.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTopping.Name = "lbTopping";
            this.lbTopping.Size = new System.Drawing.Size(95, 26);
            this.lbTopping.TabIndex = 0;
            this.lbTopping.Text = "Topping:";
            // 
            // lbSugar
            // 
            this.lbSugar.AutoSize = true;
            this.lbSugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSugar.Location = new System.Drawing.Point(2, 70);
            this.lbSugar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSugar.Name = "lbSugar";
            this.lbSugar.Size = new System.Drawing.Size(82, 26);
            this.lbSugar.TabIndex = 0;
            this.lbSugar.Text = "Đường:";
            // 
            // cboBoxToppingIce
            // 
            this.cboBoxToppingIce.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBoxToppingIce.FormattingEnabled = true;
            this.cboBoxToppingIce.Items.AddRange(new object[] {
            "0%",
            "25%",
            "50%",
            "75%",
            "100%"});
            this.cboBoxToppingIce.Location = new System.Drawing.Point(128, 5);
            this.cboBoxToppingIce.Margin = new System.Windows.Forms.Padding(2);
            this.cboBoxToppingIce.Name = "cboBoxToppingIce";
            this.cboBoxToppingIce.Size = new System.Drawing.Size(587, 34);
            this.cboBoxToppingIce.TabIndex = 2;
            // 
            // lbIce
            // 
            this.lbIce.AutoSize = true;
            this.lbIce.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIce.Location = new System.Drawing.Point(2, 7);
            this.lbIce.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbIce.Name = "lbIce";
            this.lbIce.Size = new System.Drawing.Size(46, 26);
            this.lbIce.TabIndex = 0;
            this.lbIce.Text = "Đá:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cboBoxSmell);
            this.panel2.Controls.Add(this.cboBoxSize);
            this.panel2.Controls.Add(this.numericAmount);
            this.panel2.Controls.Add(this.lbSmell);
            this.panel2.Controls.Add(this.lbSize);
            this.panel2.Controls.Add(this.lbAmount);
            this.panel2.Controls.Add(this.lbProductName);
            this.panel2.Location = new System.Drawing.Point(208, 8);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(528, 204);
            this.panel2.TabIndex = 5;
            // 
            // cboBoxSmell
            // 
            this.cboBoxSmell.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBoxSmell.FormattingEnabled = true;
            this.cboBoxSmell.Items.AddRange(new object[] {
            "S",
            "M",
            "L"});
            this.cboBoxSmell.Location = new System.Drawing.Point(128, 157);
            this.cboBoxSmell.Margin = new System.Windows.Forms.Padding(2);
            this.cboBoxSmell.Name = "cboBoxSmell";
            this.cboBoxSmell.Size = new System.Drawing.Size(383, 34);
            this.cboBoxSmell.TabIndex = 2;
            // 
            // cboBoxSize
            // 
            this.cboBoxSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBoxSize.FormattingEnabled = true;
            this.cboBoxSize.Items.AddRange(new object[] {
            "S",
            "M",
            "L"});
            this.cboBoxSize.Location = new System.Drawing.Point(128, 110);
            this.cboBoxSize.Margin = new System.Windows.Forms.Padding(2);
            this.cboBoxSize.Name = "cboBoxSize";
            this.cboBoxSize.Size = new System.Drawing.Size(383, 34);
            this.cboBoxSize.TabIndex = 2;
            // 
            // numericAmount
            // 
            this.numericAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericAmount.Location = new System.Drawing.Point(128, 67);
            this.numericAmount.Margin = new System.Windows.Forms.Padding(2);
            this.numericAmount.Name = "numericAmount";
            this.numericAmount.Size = new System.Drawing.Size(382, 32);
            this.numericAmount.TabIndex = 1;
            // 
            // lbSmell
            // 
            this.lbSmell.AutoSize = true;
            this.lbSmell.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSmell.Location = new System.Drawing.Point(3, 159);
            this.lbSmell.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSmell.Name = "lbSmell";
            this.lbSmell.Size = new System.Drawing.Size(104, 26);
            this.lbSmell.TabIndex = 0;
            this.lbSmell.Text = "Hương vị:";
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSize.Location = new System.Drawing.Point(3, 115);
            this.lbSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(61, 26);
            this.lbSize.TabIndex = 0;
            this.lbSize.Text = "Size:";
            // 
            // lbAmount
            // 
            this.lbAmount.AutoSize = true;
            this.lbAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAmount.Location = new System.Drawing.Point(3, 72);
            this.lbAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(104, 26);
            this.lbAmount.TabIndex = 0;
            this.lbAmount.Text = "Số lượng:";
            // 
            // lbProductName
            // 
            this.lbProductName.AutoSize = true;
            this.lbProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProductName.Location = new System.Drawing.Point(2, 16);
            this.lbProductName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(127, 31);
            this.lbProductName.TabIndex = 0;
            this.lbProductName.Text = "Tên món";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pictureBoxProduct);
            this.panel5.Location = new System.Drawing.Point(16, 8);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(188, 203);
            this.panel5.TabIndex = 4;
            // 
            // pictureBoxProduct
            // 
            this.pictureBoxProduct.Location = new System.Drawing.Point(21, 16);
            this.pictureBoxProduct.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxProduct.Name = "pictureBoxProduct";
            this.pictureBoxProduct.Size = new System.Drawing.Size(150, 162);
            this.pictureBoxProduct.TabIndex = 0;
            this.pictureBoxProduct.TabStop = false;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Location = new System.Drawing.Point(2, 2);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(75, 54);
            this.pictureBoxLogo.TabIndex = 1;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.lvDonHang);
            this.panel8.Controls.Add(this.lbTongTien);
            this.panel8.Controls.Add(this.lbIDDonHang);
            this.panel8.Location = new System.Drawing.Point(2, 62);
            this.panel8.Margin = new System.Windows.Forms.Padding(2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(237, 508);
            this.panel8.TabIndex = 2;
            // 
            // lvDonHang
            // 
            this.lvDonHang.HideSelection = false;
            this.lvDonHang.Location = new System.Drawing.Point(0, 49);
            this.lvDonHang.Margin = new System.Windows.Forms.Padding(2);
            this.lvDonHang.Name = "lvDonHang";
            this.lvDonHang.Size = new System.Drawing.Size(235, 412);
            this.lvDonHang.TabIndex = 1;
            this.lvDonHang.UseCompatibleStateImageBehavior = false;
            // 
            // lbTongTien
            // 
            this.lbTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongTien.Location = new System.Drawing.Point(68, 463);
            this.lbTongTien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(100, 37);
            this.lbTongTien.TabIndex = 0;
            this.lbTongTien.Text = "label1";
            this.lbTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbIDDonHang
            // 
            this.lbIDDonHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbIDDonHang.AutoSize = true;
            this.lbIDDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDDonHang.Location = new System.Drawing.Point(68, 9);
            this.lbIDDonHang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbIDDonHang.Name = "lbIDDonHang";
            this.lbIDDonHang.Size = new System.Drawing.Size(100, 37);
            this.lbIDDonHang.TabIndex = 0;
            this.lbIDDonHang.Text = "label1";
            this.lbIDDonHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnXoa);
            this.panel7.Controls.Add(this.btnThanhToan);
            this.panel7.Controls.Add(this.btnMangDi);
            this.panel7.Location = new System.Drawing.Point(2, 574);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(237, 154);
            this.panel7.TabIndex = 3;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(2, 124);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(112, 28);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(2, 48);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(2);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(166, 28);
            this.btnThanhToan.TabIndex = 0;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnMangDi
            // 
            this.btnMangDi.Location = new System.Drawing.Point(2, 15);
            this.btnMangDi.Margin = new System.Windows.Forms.Padding(2);
            this.btnMangDi.Name = "btnMangDi";
            this.btnMangDi.Size = new System.Drawing.Size(166, 28);
            this.btnMangDi.TabIndex = 0;
            this.btnMangDi.Text = "Mang đi";
            this.btnMangDi.UseVisualStyleBackColor = true;
            this.btnMangDi.Click += new System.EventHandler(this.btnMangDi_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.pictureBoxLogo);
            this.panel6.Location = new System.Drawing.Point(750, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(247, 730);
            this.panel6.TabIndex = 7;
            // 
            // fDatHang_ChinhSua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fDatHang_ChinhSua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "b";
            this.Activated += new System.EventHandler(this.fDatHang_ChinhSua_Activated);
            this.Load += new System.EventHandler(this.fDatHang_ChinhSua_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAmount)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtbNote;
        private System.Windows.Forms.ComboBox cboBoxTopping;
        private System.Windows.Forms.ComboBox cboBoxToppingSugar;
        private System.Windows.Forms.Label lbNote;
        private System.Windows.Forms.Label lbTopping;
        private System.Windows.Forms.Label lbSugar;
        private System.Windows.Forms.ComboBox cboBoxToppingIce;
        private System.Windows.Forms.Label lbIce;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cboBoxSmell;
        private System.Windows.Forms.ComboBox cboBoxSize;
        private System.Windows.Forms.NumericUpDown numericAmount;
        private System.Windows.Forms.Label lbSmell;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.Label lbProductName;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBoxProduct;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.ListView lvDonHang;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.Label lbIDDonHang;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnMangDi;
        private System.Windows.Forms.Panel panel6;

    }
}