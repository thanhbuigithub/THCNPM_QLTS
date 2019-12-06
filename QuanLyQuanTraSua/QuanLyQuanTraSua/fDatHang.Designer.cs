namespace QuanLyQuanTraSua
{
    partial class fDatHang
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
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnMangDi = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lvDonHang = new System.Windows.Forms.ListView();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.lbIDDonHang = new System.Windows.Forms.Label();
            this.lbTimkiem = new System.Windows.Forms.Label();
            this.txtbSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnOtherPrevious = new System.Windows.Forms.Button();
            this.btnBSPrevious = new System.Windows.Forms.Button();
            this.btnSpecPrevious = new System.Windows.Forms.Button();
            this.btnOtherNext = new System.Windows.Forms.Button();
            this.btnBSNext = new System.Windows.Forms.Button();
            this.btnSpecNext = new System.Windows.Forms.Button();
            this.lvOther = new System.Windows.Forms.ListView();
            this.lvBestSeller = new System.Windows.Forms.ListView();
            this.lvSpecial = new System.Windows.Forms.ListView();
            this.lbOtherMenu = new System.Windows.Forms.Label();
            this.lbBestSeller = new System.Windows.Forms.Label();
            this.lbSpecial = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Location = new System.Drawing.Point(3, 2);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(100, 66);
            this.pictureBoxLogo.TabIndex = 1;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.pictureBoxLogo);
            this.panel2.Location = new System.Drawing.Point(1011, 12);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(329, 891);
            this.panel2.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnXoa);
            this.panel5.Controls.Add(this.btnThanhToan);
            this.panel5.Controls.Add(this.btnMangDi);
            this.panel5.Location = new System.Drawing.Point(3, 706);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(313, 166);
            this.panel5.TabIndex = 3;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(0, 129);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(149, 34);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(3, 59);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(221, 34);
            this.btnThanhToan.TabIndex = 0;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnMangDi
            // 
            this.btnMangDi.Location = new System.Drawing.Point(3, 18);
            this.btnMangDi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMangDi.Name = "btnMangDi";
            this.btnMangDi.Size = new System.Drawing.Size(221, 34);
            this.btnMangDi.TabIndex = 0;
            this.btnMangDi.Text = "Mang đi";
            this.btnMangDi.UseVisualStyleBackColor = true;
            this.btnMangDi.Click += new System.EventHandler(this.btnMangDi_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lvDonHang);
            this.panel4.Controls.Add(this.lbTongTien);
            this.panel4.Controls.Add(this.lbIDDonHang);
            this.panel4.Location = new System.Drawing.Point(3, 76);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(316, 625);
            this.panel4.TabIndex = 2;
            // 
            // lvDonHang
            // 
            this.lvDonHang.HideSelection = false;
            this.lvDonHang.Location = new System.Drawing.Point(0, 60);
            this.lvDonHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvDonHang.Name = "lvDonHang";
            this.lvDonHang.Size = new System.Drawing.Size(312, 506);
            this.lvDonHang.TabIndex = 1;
            this.lvDonHang.UseCompatibleStateImageBehavior = false;
            // 
            // lbTongTien
            // 
            this.lbTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongTien.Location = new System.Drawing.Point(91, 570);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(126, 46);
            this.lbTongTien.TabIndex = 0;
            this.lbTongTien.Text = "label1";
            this.lbTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbIDDonHang
            // 
            this.lbIDDonHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbIDDonHang.AutoSize = true;
            this.lbIDDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDDonHang.Location = new System.Drawing.Point(91, 11);
            this.lbIDDonHang.Name = "lbIDDonHang";
            this.lbIDDonHang.Size = new System.Drawing.Size(126, 46);
            this.lbIDDonHang.TabIndex = 0;
            this.lbIDDonHang.Text = "label1";
            this.lbIDDonHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTimkiem
            // 
            this.lbTimkiem.AutoSize = true;
            this.lbTimkiem.BackColor = System.Drawing.SystemColors.Control;
            this.lbTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimkiem.Location = new System.Drawing.Point(3, 30);
            this.lbTimkiem.Name = "lbTimkiem";
            this.lbTimkiem.Size = new System.Drawing.Size(132, 36);
            this.lbTimkiem.TabIndex = 0;
            this.lbTimkiem.Text = "Tìm kiếm";
            // 
            // txtbSearch
            // 
            this.txtbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbSearch.Location = new System.Drawing.Point(175, 22);
            this.txtbSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbSearch.Name = "txtbSearch";
            this.txtbSearch.Size = new System.Drawing.Size(372, 41);
            this.txtbSearch.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbTimkiem);
            this.panel1.Controls.Add(this.txtbSearch);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(993, 82);
            this.panel1.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnOtherPrevious);
            this.panel3.Controls.Add(this.btnBSPrevious);
            this.panel3.Controls.Add(this.btnSpecPrevious);
            this.panel3.Controls.Add(this.btnOtherNext);
            this.panel3.Controls.Add(this.btnBSNext);
            this.panel3.Controls.Add(this.btnSpecNext);
            this.panel3.Controls.Add(this.lvOther);
            this.panel3.Controls.Add(this.lvBestSeller);
            this.panel3.Controls.Add(this.lvSpecial);
            this.panel3.Controls.Add(this.lbOtherMenu);
            this.panel3.Controls.Add(this.lbBestSeller);
            this.panel3.Controls.Add(this.lbSpecial);
            this.panel3.Location = new System.Drawing.Point(12, 100);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(991, 804);
            this.panel3.TabIndex = 7;
            // 
            // btnOtherPrevious
            // 
            this.btnOtherPrevious.Location = new System.Drawing.Point(3, 562);
            this.btnOtherPrevious.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOtherPrevious.Name = "btnOtherPrevious";
            this.btnOtherPrevious.Size = new System.Drawing.Size(64, 132);
            this.btnOtherPrevious.TabIndex = 3;
            this.btnOtherPrevious.Text = "button1";
            this.btnOtherPrevious.UseVisualStyleBackColor = true;
            // 
            // btnBSPrevious
            // 
            this.btnBSPrevious.Location = new System.Drawing.Point(3, 321);
            this.btnBSPrevious.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBSPrevious.Name = "btnBSPrevious";
            this.btnBSPrevious.Size = new System.Drawing.Size(64, 140);
            this.btnBSPrevious.TabIndex = 3;
            this.btnBSPrevious.Text = "button1";
            this.btnBSPrevious.UseVisualStyleBackColor = true;
            // 
            // btnSpecPrevious
            // 
            this.btnSpecPrevious.Location = new System.Drawing.Point(3, 70);
            this.btnSpecPrevious.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSpecPrevious.Name = "btnSpecPrevious";
            this.btnSpecPrevious.Size = new System.Drawing.Size(64, 123);
            this.btnSpecPrevious.TabIndex = 3;
            this.btnSpecPrevious.Text = "button1";
            this.btnSpecPrevious.UseVisualStyleBackColor = true;
            // 
            // btnOtherNext
            // 
            this.btnOtherNext.Location = new System.Drawing.Point(909, 559);
            this.btnOtherNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOtherNext.Name = "btnOtherNext";
            this.btnOtherNext.Size = new System.Drawing.Size(64, 132);
            this.btnOtherNext.TabIndex = 3;
            this.btnOtherNext.Text = "button1";
            this.btnOtherNext.UseVisualStyleBackColor = true;
            // 
            // btnBSNext
            // 
            this.btnBSNext.Location = new System.Drawing.Point(909, 318);
            this.btnBSNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBSNext.Name = "btnBSNext";
            this.btnBSNext.Size = new System.Drawing.Size(64, 140);
            this.btnBSNext.TabIndex = 3;
            this.btnBSNext.Text = "button1";
            this.btnBSNext.UseVisualStyleBackColor = true;
            // 
            // btnSpecNext
            // 
            this.btnSpecNext.Location = new System.Drawing.Point(909, 66);
            this.btnSpecNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSpecNext.Name = "btnSpecNext";
            this.btnSpecNext.Size = new System.Drawing.Size(64, 127);
            this.btnSpecNext.TabIndex = 3;
            this.btnSpecNext.Text = "button1";
            this.btnSpecNext.UseVisualStyleBackColor = true;
            // 
            // lvOther
            // 
            this.lvOther.HideSelection = false;
            this.lvOther.Location = new System.Drawing.Point(72, 544);
            this.lvOther.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvOther.Name = "lvOther";
            this.lvOther.Size = new System.Drawing.Size(832, 169);
            this.lvOther.TabIndex = 2;
            this.lvOther.UseCompatibleStateImageBehavior = false;
            // 
            // lvBestSeller
            // 
            this.lvBestSeller.HideSelection = false;
            this.lvBestSeller.Location = new System.Drawing.Point(72, 303);
            this.lvBestSeller.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvBestSeller.Name = "lvBestSeller";
            this.lvBestSeller.Size = new System.Drawing.Size(832, 178);
            this.lvBestSeller.TabIndex = 2;
            this.lvBestSeller.UseCompatibleStateImageBehavior = false;
            // 
            // lvSpecial
            // 
            this.lvSpecial.HideSelection = false;
            this.lvSpecial.Location = new System.Drawing.Point(72, 52);
            this.lvSpecial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvSpecial.Name = "lvSpecial";
            this.lvSpecial.Size = new System.Drawing.Size(832, 174);
            this.lvSpecial.TabIndex = 2;
            this.lvSpecial.UseCompatibleStateImageBehavior = false;
            // 
            // lbOtherMenu
            // 
            this.lbOtherMenu.AutoSize = true;
            this.lbOtherMenu.BackColor = System.Drawing.SystemColors.Control;
            this.lbOtherMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOtherMenu.Location = new System.Drawing.Point(24, 506);
            this.lbOtherMenu.Name = "lbOtherMenu";
            this.lbOtherMenu.Size = new System.Drawing.Size(166, 36);
            this.lbOtherMenu.TabIndex = 1;
            this.lbOtherMenu.Text = "Menu Khác";
            // 
            // lbBestSeller
            // 
            this.lbBestSeller.AutoSize = true;
            this.lbBestSeller.BackColor = System.Drawing.SystemColors.Control;
            this.lbBestSeller.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBestSeller.Location = new System.Drawing.Point(24, 258);
            this.lbBestSeller.Name = "lbBestSeller";
            this.lbBestSeller.Size = new System.Drawing.Size(205, 36);
            this.lbBestSeller.TabIndex = 1;
            this.lbBestSeller.Text = "Bán chạy nhất";
            // 
            // lbSpecial
            // 
            this.lbSpecial.AutoSize = true;
            this.lbSpecial.BackColor = System.Drawing.SystemColors.Control;
            this.lbSpecial.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSpecial.Location = new System.Drawing.Point(24, 16);
            this.lbSpecial.Name = "lbSpecial";
            this.lbSpecial.Size = new System.Drawing.Size(245, 36);
            this.lbSpecial.TabIndex = 1;
            this.lbSpecial.Text = "Đặc biệt tuần này";
            // 
            // fDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 898);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fDatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fDatHang";
            this.Activated += new System.EventHandler(this.fDatHang_Activated);
            this.Load += new System.EventHandler(this.fDatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbTimkiem;
        private System.Windows.Forms.TextBox txtbSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnMangDi;
        private System.Windows.Forms.ListView lvDonHang;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.Label lbIDDonHang;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnOtherPrevious;
        private System.Windows.Forms.Button btnBSPrevious;
        private System.Windows.Forms.Button btnSpecPrevious;
        private System.Windows.Forms.Button btnOtherNext;
        private System.Windows.Forms.Button btnBSNext;
        private System.Windows.Forms.Button btnSpecNext;
        private System.Windows.Forms.ListView lvOther;
        private System.Windows.Forms.ListView lvBestSeller;
        private System.Windows.Forms.ListView lvSpecial;
        private System.Windows.Forms.Label lbOtherMenu;
        private System.Windows.Forms.Label lbBestSeller;
        private System.Windows.Forms.Label lbSpecial;
    }
}