namespace QuanLyQuanTraSua
{
    partial class fThanhToan_Thuong
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
            this.rbtnCast = new System.Windows.Forms.RadioButton();
            this.rbtnCard = new System.Windows.Forms.RadioButton();
            this.lbTypeOfPayment = new System.Windows.Forms.Label();
            this.txtbChange = new System.Windows.Forms.TextBox();
            this.lbChange = new System.Windows.Forms.Label();
            this.txtbMoneyReceived = new System.Windows.Forms.TextBox();
            this.lbMoneyReceived = new System.Windows.Forms.Label();
            this.txtbTotalMoney = new System.Windows.Forms.TextBox();
            this.lbTotalMoney = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnXoa = new ePOSOne.btnProduct.ButtonModified();
            this.btnThanhToan = new ePOSOne.btnProduct.ButtonModified();
            this.btnMangDi = new ePOSOne.btnProduct.ButtonModified();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lvDonHang = new System.Windows.Forms.ListView();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.lbIDDonHang = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnBack = new ePOSOne.btnProduct.ButtonModified();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTiep = new ePOSOne.btnProduct.ButtonModified();
            this.lbDateOfPayment = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 731);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rbtnCast);
            this.panel4.Controls.Add(this.rbtnCard);
            this.panel4.Controls.Add(this.lbTypeOfPayment);
            this.panel4.Controls.Add(this.txtbChange);
            this.panel4.Controls.Add(this.lbChange);
            this.panel4.Controls.Add(this.txtbMoneyReceived);
            this.panel4.Controls.Add(this.lbMoneyReceived);
            this.panel4.Controls.Add(this.txtbTotalMoney);
            this.panel4.Controls.Add(this.lbTotalMoney);
            this.panel4.Location = new System.Drawing.Point(29, 68);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(701, 567);
            this.panel4.TabIndex = 32;
            // 
            // rbtnCast
            // 
            this.rbtnCast.AutoSize = true;
            this.rbtnCast.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.rbtnCast.Location = new System.Drawing.Point(232, 324);
            this.rbtnCast.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rbtnCast.Name = "rbtnCast";
            this.rbtnCast.Size = new System.Drawing.Size(114, 30);
            this.rbtnCast.TabIndex = 35;
            this.rbtnCast.TabStop = true;
            this.rbtnCast.Text = "Tiền mặt";
            this.rbtnCast.UseVisualStyleBackColor = true;
            this.rbtnCast.CheckedChanged += new System.EventHandler(this.rbtnCast_CheckedChanged);
            // 
            // rbtnCard
            // 
            this.rbtnCard.AutoSize = true;
            this.rbtnCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.rbtnCard.Location = new System.Drawing.Point(232, 280);
            this.rbtnCard.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rbtnCard.Name = "rbtnCard";
            this.rbtnCard.Size = new System.Drawing.Size(66, 30);
            this.rbtnCard.TabIndex = 34;
            this.rbtnCard.TabStop = true;
            this.rbtnCard.Text = "Thẻ";
            this.rbtnCard.UseVisualStyleBackColor = true;
            // 
            // lbTypeOfPayment
            // 
            this.lbTypeOfPayment.AutoSize = true;
            this.lbTypeOfPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTypeOfPayment.Location = new System.Drawing.Point(2, 282);
            this.lbTypeOfPayment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTypeOfPayment.Name = "lbTypeOfPayment";
            this.lbTypeOfPayment.Size = new System.Drawing.Size(224, 26);
            this.lbTypeOfPayment.TabIndex = 33;
            this.lbTypeOfPayment.Text = "Hình thức thanh toán :";
            // 
            // txtbChange
            // 
            this.txtbChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.txtbChange.Location = new System.Drawing.Point(232, 199);
            this.txtbChange.Margin = new System.Windows.Forms.Padding(2);
            this.txtbChange.Multiline = true;
            this.txtbChange.Name = "txtbChange";
            this.txtbChange.Size = new System.Drawing.Size(436, 34);
            this.txtbChange.TabIndex = 32;
            // 
            // lbChange
            // 
            this.lbChange.AutoSize = true;
            this.lbChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChange.Location = new System.Drawing.Point(2, 207);
            this.lbChange.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbChange.Name = "lbChange";
            this.lbChange.Size = new System.Drawing.Size(100, 26);
            this.lbChange.TabIndex = 31;
            this.lbChange.Text = "Tiền thối:";
            // 
            // txtbMoneyReceived
            // 
            this.txtbMoneyReceived.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.txtbMoneyReceived.Location = new System.Drawing.Point(232, 121);
            this.txtbMoneyReceived.Margin = new System.Windows.Forms.Padding(2);
            this.txtbMoneyReceived.Multiline = true;
            this.txtbMoneyReceived.Name = "txtbMoneyReceived";
            this.txtbMoneyReceived.Size = new System.Drawing.Size(436, 34);
            this.txtbMoneyReceived.TabIndex = 30;
            // 
            // lbMoneyReceived
            // 
            this.lbMoneyReceived.AutoSize = true;
            this.lbMoneyReceived.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMoneyReceived.Location = new System.Drawing.Point(2, 129);
            this.lbMoneyReceived.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMoneyReceived.Name = "lbMoneyReceived";
            this.lbMoneyReceived.Size = new System.Drawing.Size(172, 26);
            this.lbMoneyReceived.TabIndex = 29;
            this.lbMoneyReceived.Text = "Tiền nhận được :";
            // 
            // txtbTotalMoney
            // 
            this.txtbTotalMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.txtbTotalMoney.Location = new System.Drawing.Point(232, 46);
            this.txtbTotalMoney.Margin = new System.Windows.Forms.Padding(2);
            this.txtbTotalMoney.Multiline = true;
            this.txtbTotalMoney.Name = "txtbTotalMoney";
            this.txtbTotalMoney.Size = new System.Drawing.Size(436, 34);
            this.txtbTotalMoney.TabIndex = 28;
            // 
            // lbTotalMoney
            // 
            this.lbTotalMoney.AutoSize = true;
            this.lbTotalMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalMoney.Location = new System.Drawing.Point(2, 54);
            this.lbTotalMoney.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTotalMoney.Name = "lbTotalMoney";
            this.lbTotalMoney.Size = new System.Drawing.Size(113, 26);
            this.lbTotalMoney.TabIndex = 27;
            this.lbTotalMoney.Text = "Tổng tiền :";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.pictureBoxLogo);
            this.panel6.Location = new System.Drawing.Point(759, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(262, 733);
            this.panel6.TabIndex = 17;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnXoa);
            this.panel7.Controls.Add(this.btnThanhToan);
            this.panel7.Controls.Add(this.btnMangDi);
            this.panel7.Location = new System.Drawing.Point(2, 574);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(258, 150);
            this.panel7.TabIndex = 3;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnXoa.FlatAppearance.BorderSize = 3;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(138, 109);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(97, 30);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnThanhToan.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnThanhToan.FlatAppearance.BorderSize = 3;
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Location = new System.Drawing.Point(4, 38);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(164, 30);
            this.btnThanhToan.TabIndex = 2;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            // 
            // btnMangDi
            // 
            this.btnMangDi.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnMangDi.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMangDi.FlatAppearance.BorderSize = 3;
            this.btnMangDi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMangDi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMangDi.Location = new System.Drawing.Point(2, 3);
            this.btnMangDi.Name = "btnMangDi";
            this.btnMangDi.Size = new System.Drawing.Size(164, 30);
            this.btnMangDi.TabIndex = 1;
            this.btnMangDi.Text = "Mang đi";
            this.btnMangDi.UseVisualStyleBackColor = false;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.lvDonHang);
            this.panel8.Controls.Add(this.lbTongTien);
            this.panel8.Controls.Add(this.lbIDDonHang);
            this.panel8.Location = new System.Drawing.Point(2, 62);
            this.panel8.Margin = new System.Windows.Forms.Padding(2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(258, 508);
            this.panel8.TabIndex = 2;
            // 
            // lvDonHang
            // 
            this.lvDonHang.HideSelection = false;
            this.lvDonHang.Location = new System.Drawing.Point(2, 49);
            this.lvDonHang.Margin = new System.Windows.Forms.Padding(2);
            this.lvDonHang.Name = "lvDonHang";
            this.lvDonHang.Size = new System.Drawing.Size(254, 412);
            this.lvDonHang.TabIndex = 1;
            this.lvDonHang.UseCompatibleStateImageBehavior = false;
            // 
            // lbTongTien
            // 
            this.lbTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongTien.Location = new System.Drawing.Point(68, 463);
            this.lbTongTien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(106, 37);
            this.lbTongTien.TabIndex = 0;
            this.lbTongTien.Text = "label1";
            this.lbTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbIDDonHang
            // 
            this.lbIDDonHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbIDDonHang.AutoSize = true;
            this.lbIDDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDDonHang.Location = new System.Drawing.Point(15, 9);
            this.lbIDDonHang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbIDDonHang.Name = "lbIDDonHang";
            this.lbIDDonHang.Size = new System.Drawing.Size(218, 37);
            this.lbIDDonHang.TabIndex = 0;
            this.lbIDDonHang.Text = "mã đơn hàng";
            this.lbIDDonHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // panel3
            // 
            this.panel3.Controls.Add(this.btnBack);
            this.panel3.Location = new System.Drawing.Point(29, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(692, 61);
            this.panel3.TabIndex = 37;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBack.FlatAppearance.BorderSize = 3;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(7, 11);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(164, 43);
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnTiep);
            this.panel2.Controls.Add(this.lbDateOfPayment);
            this.panel2.Controls.Add(this.lbDate);
            this.panel2.Location = new System.Drawing.Point(36, 643);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(694, 77);
            this.panel2.TabIndex = 36;
            // 
            // btnTiep
            // 
            this.btnTiep.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnTiep.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTiep.FlatAppearance.BorderSize = 3;
            this.btnTiep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTiep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiep.Location = new System.Drawing.Point(521, 24);
            this.btnTiep.Name = "btnTiep";
            this.btnTiep.Size = new System.Drawing.Size(164, 43);
            this.btnTiep.TabIndex = 32;
            this.btnTiep.Text = "tiếp";
            this.btnTiep.UseVisualStyleBackColor = false;
            this.btnTiep.Click += new System.EventHandler(this.btnTiep_Click);
            // 
            // lbDateOfPayment
            // 
            this.lbDateOfPayment.AutoSize = true;
            this.lbDateOfPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbDateOfPayment.Location = new System.Drawing.Point(74, 50);
            this.lbDateOfPayment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDateOfPayment.Name = "lbDateOfPayment";
            this.lbDateOfPayment.Size = new System.Drawing.Size(100, 17);
            this.lbDateOfPayment.TabIndex = 31;
            this.lbDateOfPayment.Text = "dd - mm - yyyy";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(21, 51);
            this.lbDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(49, 16);
            this.lbDate.TabIndex = 30;
            this.lbDate.Text = "Ngày:";
            // 
            // fThanhToan_Thuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Name = "fThanhToan_Thuong";
            this.Text = "fThanhToan_Thuong";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rbtnCast;
        private System.Windows.Forms.RadioButton rbtnCard;
        private System.Windows.Forms.Label lbTypeOfPayment;
        private System.Windows.Forms.TextBox txtbChange;
        private System.Windows.Forms.Label lbChange;
        private System.Windows.Forms.TextBox txtbMoneyReceived;
        private System.Windows.Forms.Label lbMoneyReceived;
        private System.Windows.Forms.TextBox txtbTotalMoney;
        private System.Windows.Forms.Label lbTotalMoney;
        private System.Windows.Forms.Panel panel3;
        private ePOSOne.btnProduct.ButtonModified btnBack;
        private System.Windows.Forms.Panel panel2;
        private ePOSOne.btnProduct.ButtonModified btnTiep;
        private System.Windows.Forms.Label lbDateOfPayment;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private ePOSOne.btnProduct.ButtonModified btnXoa;
        private ePOSOne.btnProduct.ButtonModified btnThanhToan;
        private ePOSOne.btnProduct.ButtonModified btnMangDi;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.ListView lvDonHang;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.Label lbIDDonHang;
        private System.Windows.Forms.PictureBox pictureBoxLogo;

    }
}