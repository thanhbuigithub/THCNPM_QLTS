namespace QuanLyQuanTraSua
{
    partial class fTrangChu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTrangChu));
            this.lbTimkiem = new System.Windows.Forms.Label();
            this.txtbSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.fLPSpecial = new System.Windows.Forms.FlowLayoutPanel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbOtherMenu = new ePOSOne.btnProduct.RoundLabel();
            this.lbBestSeller = new ePOSOne.btnProduct.RoundLabel();
            this.lbSpecial = new ePOSOne.btnProduct.RoundLabel();
            this.btnOtherPrevious = new ePOSOne.btnProduct.ButtonModified();
            this.btnBSPrevious = new ePOSOne.btnProduct.ButtonModified();
            this.btnOtherNext = new ePOSOne.btnProduct.ButtonModified();
            this.btnBSNext = new ePOSOne.btnProduct.ButtonModified();
            this.btnSpecPrevious = new ePOSOne.btnProduct.ButtonModified();
            this.btnSpecNext = new ePOSOne.btnProduct.ButtonModified();
            this.btnProduct = new ePOSOne.btnProduct.ButtonModified();
            this.btnReport = new ePOSOne.btnProduct.ButtonModified();
            this.btnCustomer = new ePOSOne.btnProduct.ButtonModified();
            this.btnOrder = new ePOSOne.btnProduct.ButtonModified();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTimkiem
            // 
            this.lbTimkiem.AutoSize = true;
            this.lbTimkiem.BackColor = System.Drawing.SystemColors.Control;
            this.lbTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimkiem.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lbTimkiem.Location = new System.Drawing.Point(2, 24);
            this.lbTimkiem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTimkiem.Name = "lbTimkiem";
            this.lbTimkiem.Size = new System.Drawing.Size(121, 29);
            this.lbTimkiem.TabIndex = 0;
            this.lbTimkiem.Text = "Tìm kiếm";
            // 
            // txtbSearch
            // 
            this.txtbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbSearch.Location = new System.Drawing.Point(127, 18);
            this.txtbSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtbSearch.Name = "txtbSearch";
            this.txtbSearch.Size = new System.Drawing.Size(280, 35);
            this.txtbSearch.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbTimkiem);
            this.panel1.Controls.Add(this.txtbSearch);
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 80);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel2.Controls.Add(this.btnProduct);
            this.panel2.Controls.Add(this.btnReport);
            this.panel2.Controls.Add(this.btnCustomer);
            this.panel2.Controls.Add(this.btnOrder);
            this.panel2.Controls.Add(this.pictureBoxLogo);
            this.panel2.Location = new System.Drawing.Point(747, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(264, 722);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Location = new System.Drawing.Point(2, 2);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(235, 165);
            this.pictureBoxLogo.TabIndex = 1;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.Click += new System.EventHandler(this.pictureBoxLogo_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbOtherMenu);
            this.panel3.Controls.Add(this.lbBestSeller);
            this.panel3.Controls.Add(this.lbSpecial);
            this.panel3.Controls.Add(this.btnOtherPrevious);
            this.panel3.Controls.Add(this.btnBSPrevious);
            this.panel3.Controls.Add(this.btnOtherNext);
            this.panel3.Controls.Add(this.btnBSNext);
            this.panel3.Controls.Add(this.btnSpecPrevious);
            this.panel3.Controls.Add(this.btnSpecNext);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(6, 94);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(739, 612);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.fLPSpecial);
            this.panel4.Location = new System.Drawing.Point(55, 50);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(622, 153);
            this.panel4.TabIndex = 5;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // fLPSpecial
            // 
            this.fLPSpecial.AutoScroll = true;
            this.fLPSpecial.BackColor = System.Drawing.SystemColors.Control;
            this.fLPSpecial.Location = new System.Drawing.Point(0, 4);
            this.fLPSpecial.Name = "fLPSpecial";
            this.fLPSpecial.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fLPSpecial.Size = new System.Drawing.Size(627, 153);
            this.fLPSpecial.TabIndex = 4;
            this.fLPSpecial.WrapContents = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Bronze_Emblem.png");
            this.imageList1.Images.SetKeyName(1, "Challenger_Emblem.png");
            this.imageList1.Images.SetKeyName(2, "Diamond_Emblem.png");
            this.imageList1.Images.SetKeyName(3, "Gold_Emblem.png");
            this.imageList1.Images.SetKeyName(4, "Grandmaster_Emblem.png");
            this.imageList1.Images.SetKeyName(5, "Iron_Emblem.png");
            this.imageList1.Images.SetKeyName(6, "Master_Emblem.png");
            this.imageList1.Images.SetKeyName(7, "Platinum_Emblem.png");
            this.imageList1.Images.SetKeyName(8, "Silver_Emblem.png");
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // lbOtherMenu
            // 
            this.lbOtherMenu.AutoSize = true;
            this.lbOtherMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOtherMenu.Location = new System.Drawing.Point(3, 418);
            this.lbOtherMenu.Name = "lbOtherMenu";
            this.lbOtherMenu.Padding = new System.Windows.Forms.Padding(76, 10, 76, 10);
            this.lbOtherMenu.Size = new System.Drawing.Size(307, 51);
            this.lbOtherMenu.TabIndex = 14;
            this.lbOtherMenu.Text = "Menu khác";
            // 
            // lbBestSeller
            // 
            this.lbBestSeller.AutoSize = true;
            this.lbBestSeller.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBestSeller.Location = new System.Drawing.Point(3, 224);
            this.lbBestSeller.Name = "lbBestSeller";
            this.lbBestSeller.Padding = new System.Windows.Forms.Padding(56, 10, 56, 10);
            this.lbBestSeller.Size = new System.Drawing.Size(312, 51);
            this.lbBestSeller.TabIndex = 13;
            this.lbBestSeller.Text = "Bán chạy nhất";
            // 
            // lbSpecial
            // 
            this.lbSpecial.AutoSize = true;
            this.lbSpecial.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSpecial.Location = new System.Drawing.Point(3, 0);
            this.lbSpecial.Name = "lbSpecial";
            this.lbSpecial.Padding = new System.Windows.Forms.Padding(40, 10, 40, 10);
            this.lbSpecial.Size = new System.Drawing.Size(322, 51);
            this.lbSpecial.TabIndex = 12;
            this.lbSpecial.Text = "Đặc biệt tuần này";
            // 
            // btnOtherPrevious
            // 
            this.btnOtherPrevious.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnOtherPrevious.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOtherPrevious.FlatAppearance.BorderSize = 3;
            this.btnOtherPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOtherPrevious.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtherPrevious.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOtherPrevious.Location = new System.Drawing.Point(0, 494);
            this.btnOtherPrevious.Name = "btnOtherPrevious";
            this.btnOtherPrevious.Size = new System.Drawing.Size(48, 81);
            this.btnOtherPrevious.TabIndex = 11;
            this.btnOtherPrevious.Text = "<";
            this.btnOtherPrevious.UseVisualStyleBackColor = false;
            // 
            // btnBSPrevious
            // 
            this.btnBSPrevious.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnBSPrevious.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBSPrevious.FlatAppearance.BorderSize = 3;
            this.btnBSPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBSPrevious.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBSPrevious.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBSPrevious.Location = new System.Drawing.Point(0, 294);
            this.btnBSPrevious.Name = "btnBSPrevious";
            this.btnBSPrevious.Size = new System.Drawing.Size(48, 81);
            this.btnBSPrevious.TabIndex = 10;
            this.btnBSPrevious.Text = "<";
            this.btnBSPrevious.UseVisualStyleBackColor = false;
            // 
            // btnOtherNext
            // 
            this.btnOtherNext.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnOtherNext.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOtherNext.FlatAppearance.BorderSize = 3;
            this.btnOtherNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOtherNext.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtherNext.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOtherNext.Location = new System.Drawing.Point(690, 494);
            this.btnOtherNext.Name = "btnOtherNext";
            this.btnOtherNext.Size = new System.Drawing.Size(48, 81);
            this.btnOtherNext.TabIndex = 9;
            this.btnOtherNext.Text = ">";
            this.btnOtherNext.UseVisualStyleBackColor = false;
            // 
            // btnBSNext
            // 
            this.btnBSNext.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnBSNext.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBSNext.FlatAppearance.BorderSize = 3;
            this.btnBSNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBSNext.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBSNext.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBSNext.Location = new System.Drawing.Point(687, 294);
            this.btnBSNext.Name = "btnBSNext";
            this.btnBSNext.Size = new System.Drawing.Size(48, 81);
            this.btnBSNext.TabIndex = 8;
            this.btnBSNext.Text = ">";
            this.btnBSNext.UseVisualStyleBackColor = false;
            // 
            // btnSpecPrevious
            // 
            this.btnSpecPrevious.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSpecPrevious.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSpecPrevious.FlatAppearance.BorderSize = 3;
            this.btnSpecPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpecPrevious.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpecPrevious.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSpecPrevious.Location = new System.Drawing.Point(3, 76);
            this.btnSpecPrevious.Name = "btnSpecPrevious";
            this.btnSpecPrevious.Size = new System.Drawing.Size(48, 81);
            this.btnSpecPrevious.TabIndex = 7;
            this.btnSpecPrevious.Text = "<";
            this.btnSpecPrevious.UseVisualStyleBackColor = false;
            this.btnSpecPrevious.Click += new System.EventHandler(this.btnSpecPrevious_Click_1);
            // 
            // btnSpecNext
            // 
            this.btnSpecNext.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSpecNext.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSpecNext.FlatAppearance.BorderSize = 3;
            this.btnSpecNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpecNext.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpecNext.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSpecNext.Location = new System.Drawing.Point(688, 76);
            this.btnSpecNext.Name = "btnSpecNext";
            this.btnSpecNext.Size = new System.Drawing.Size(48, 81);
            this.btnSpecNext.TabIndex = 6;
            this.btnSpecNext.Text = ">";
            this.btnSpecNext.UseVisualStyleBackColor = false;
            this.btnSpecNext.Click += new System.EventHandler(this.btnSpecNext_Click_1);
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnProduct.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnProduct.FlatAppearance.BorderSize = 3;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnProduct.Location = new System.Drawing.Point(3, 552);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(264, 87);
            this.btnProduct.TabIndex = 5;
            this.btnProduct.Text = "Sản phẩm";
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click_1);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnReport.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnReport.FlatAppearance.BorderSize = 3;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(0, 434);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(264, 87);
            this.btnReport.TabIndex = 4;
            this.btnReport.Text = "Báo cáo";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click_1);
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCustomer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCustomer.FlatAppearance.BorderSize = 3;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnCustomer.Location = new System.Drawing.Point(0, 318);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(264, 87);
            this.btnCustomer.TabIndex = 3;
            this.btnCustomer.Text = "Khách hàng";
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click_1);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnOrder.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOrder.FlatAppearance.BorderSize = 3;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(0, 211);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(264, 87);
            this.btnOrder.TabIndex = 2;
            this.btnOrder.Text = "Đặt hàng";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click_1);
            // 
            // fTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 717);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fTrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang Chủ";
            this.Activated += new System.EventHandler(this.fTrangChu_Activated);
            this.Load += new System.EventHandler(this.fTrangChu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTimkiem;
        private System.Windows.Forms.TextBox txtbSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.FlowLayoutPanel fLPSpecial;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private ePOSOne.btnProduct.ButtonModified btnOrder;
        private ePOSOne.btnProduct.ButtonModified btnCustomer;
        private ePOSOne.btnProduct.ButtonModified btnReport;
        private ePOSOne.btnProduct.ButtonModified btnProduct;
        private ePOSOne.btnProduct.ButtonModified btnSpecNext;
        private ePOSOne.btnProduct.ButtonModified btnSpecPrevious;
        private ePOSOne.btnProduct.ButtonModified btnBSNext;
        private ePOSOne.btnProduct.ButtonModified btnOtherPrevious;
        private ePOSOne.btnProduct.ButtonModified btnBSPrevious;
        private ePOSOne.btnProduct.ButtonModified btnOtherNext;
        private ePOSOne.btnProduct.RoundLabel lbOtherMenu;
        private ePOSOne.btnProduct.RoundLabel lbBestSeller;
        private ePOSOne.btnProduct.RoundLabel lbSpecial;
    }
}
