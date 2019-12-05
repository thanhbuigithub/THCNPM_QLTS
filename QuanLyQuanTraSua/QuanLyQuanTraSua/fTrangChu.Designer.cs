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
            this.btnReport = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.fLPSpecial = new System.Windows.Forms.FlowLayoutPanel();
            this.btnOtherPrevious = new System.Windows.Forms.Button();
            this.btnBSPrevious = new System.Windows.Forms.Button();
            this.btnSpecPrevious = new System.Windows.Forms.Button();
            this.btnOtherNext = new System.Windows.Forms.Button();
            this.btnBSNext = new System.Windows.Forms.Button();
            this.btnSpecNext = new System.Windows.Forms.Button();
            this.lbOtherMenu = new System.Windows.Forms.Label();
            this.lbBestSeller = new System.Windows.Forms.Label();
            this.lbSpecial = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTimkiem
            // 
            this.lbTimkiem.AutoSize = true;
            this.lbTimkiem.BackColor = System.Drawing.SystemColors.Control;
            this.lbTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimkiem.Location = new System.Drawing.Point(2, 24);
            this.lbTimkiem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTimkiem.Name = "lbTimkiem";
            this.lbTimkiem.Size = new System.Drawing.Size(113, 29);
            this.lbTimkiem.TabIndex = 0;
            this.lbTimkiem.Text = "Tìm kiếm";
            // 
            // txtbSearch
            // 
            this.txtbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbSearch.Location = new System.Drawing.Point(132, 21);
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
            this.panel2.Controls.Add(this.pictureBoxLogo);
            this.panel2.Controls.Add(this.btnReport);
            this.panel2.Controls.Add(this.btnProduct);
            this.panel2.Controls.Add(this.btnCustomer);
            this.panel2.Controls.Add(this.btnOrder);
            this.panel2.Location = new System.Drawing.Point(747, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 660);
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
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(0, 427);
            this.btnReport.Margin = new System.Windows.Forms.Padding(2);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(239, 66);
            this.btnReport.TabIndex = 0;
            this.btnReport.Text = "Báo Cáo";
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // btnProduct
            // 
            this.btnProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.Location = new System.Drawing.Point(0, 340);
            this.btnProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(239, 66);
            this.btnProduct.TabIndex = 0;
            this.btnProduct.Text = "Sản phẩm";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.Location = new System.Drawing.Point(0, 255);
            this.btnCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(239, 66);
            this.btnCustomer.TabIndex = 0;
            this.btnCustomer.Text = "Khách hàng";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(0, 172);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(239, 66);
            this.btnOrder.TabIndex = 0;
            this.btnOrder.Text = "Đặt hàng";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.fLPSpecial);
            this.panel3.Controls.Add(this.btnOtherPrevious);
            this.panel3.Controls.Add(this.btnBSPrevious);
            this.panel3.Controls.Add(this.btnSpecPrevious);
            this.panel3.Controls.Add(this.btnOtherNext);
            this.panel3.Controls.Add(this.btnBSNext);
            this.panel3.Controls.Add(this.btnSpecNext);
            this.panel3.Controls.Add(this.lbOtherMenu);
            this.panel3.Controls.Add(this.lbBestSeller);
            this.panel3.Controls.Add(this.lbSpecial);
            this.panel3.Location = new System.Drawing.Point(6, 94);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(739, 596);
            this.panel3.TabIndex = 6;
            // 
            // fLPSpecial
            // 
            this.fLPSpecial.BackColor = System.Drawing.SystemColors.Control;
            this.fLPSpecial.Location = new System.Drawing.Point(55, 54);
            this.fLPSpecial.Name = "fLPSpecial";
            this.fLPSpecial.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fLPSpecial.Size = new System.Drawing.Size(622, 153);
            this.fLPSpecial.TabIndex = 4;
            this.fLPSpecial.WrapContents = false;
            // 
            // btnOtherPrevious
            // 
            this.btnOtherPrevious.Location = new System.Drawing.Point(2, 457);
            this.btnOtherPrevious.Margin = new System.Windows.Forms.Padding(2);
            this.btnOtherPrevious.Name = "btnOtherPrevious";
            this.btnOtherPrevious.Size = new System.Drawing.Size(48, 107);
            this.btnOtherPrevious.TabIndex = 3;
            this.btnOtherPrevious.Text = "button1";
            this.btnOtherPrevious.UseVisualStyleBackColor = true;
            // 
            // btnBSPrevious
            // 
            this.btnBSPrevious.Location = new System.Drawing.Point(2, 261);
            this.btnBSPrevious.Margin = new System.Windows.Forms.Padding(2);
            this.btnBSPrevious.Name = "btnBSPrevious";
            this.btnBSPrevious.Size = new System.Drawing.Size(48, 114);
            this.btnBSPrevious.TabIndex = 3;
            this.btnBSPrevious.Text = "button1";
            this.btnBSPrevious.UseVisualStyleBackColor = true;
            // 
            // btnSpecPrevious
            // 
            this.btnSpecPrevious.Location = new System.Drawing.Point(2, 57);
            this.btnSpecPrevious.Margin = new System.Windows.Forms.Padding(2);
            this.btnSpecPrevious.Name = "btnSpecPrevious";
            this.btnSpecPrevious.Size = new System.Drawing.Size(48, 100);
            this.btnSpecPrevious.TabIndex = 3;
            this.btnSpecPrevious.Text = "button1";
            this.btnSpecPrevious.UseVisualStyleBackColor = true;
            // 
            // btnOtherNext
            // 
            this.btnOtherNext.Location = new System.Drawing.Point(682, 454);
            this.btnOtherNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnOtherNext.Name = "btnOtherNext";
            this.btnOtherNext.Size = new System.Drawing.Size(48, 107);
            this.btnOtherNext.TabIndex = 3;
            this.btnOtherNext.Text = "button1";
            this.btnOtherNext.UseVisualStyleBackColor = true;
            // 
            // btnBSNext
            // 
            this.btnBSNext.Location = new System.Drawing.Point(682, 258);
            this.btnBSNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnBSNext.Name = "btnBSNext";
            this.btnBSNext.Size = new System.Drawing.Size(48, 114);
            this.btnBSNext.TabIndex = 3;
            this.btnBSNext.Text = "button1";
            this.btnBSNext.UseVisualStyleBackColor = true;
            // 
            // btnSpecNext
            // 
            this.btnSpecNext.Location = new System.Drawing.Point(682, 54);
            this.btnSpecNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnSpecNext.Name = "btnSpecNext";
            this.btnSpecNext.Size = new System.Drawing.Size(48, 103);
            this.btnSpecNext.TabIndex = 3;
            this.btnSpecNext.Text = "button1";
            this.btnSpecNext.UseVisualStyleBackColor = true;
            this.btnSpecNext.Click += new System.EventHandler(this.btnSpecNext_Click);
            // 
            // lvOther
            // 
            //this.lvOther.HideSelection = false;
            //this.lvOther.Location = new System.Drawing.Point(54, 442);
            //this.lvOther.Margin = new System.Windows.Forms.Padding(2);
            //this.lvOther.Name = "lvOther";
            //this.lvOther.Size = new System.Drawing.Size(625, 138);
            //this.lvOther.TabIndex = 2;
            //this.lvOther.UseCompatibleStateImageBehavior = false;
            // 
            // lvBestSeller
            // 
            //this.lvBestSeller.HideSelection = false;
            //this.lvBestSeller.Location = new System.Drawing.Point(54, 246);
            //this.lvBestSeller.Margin = new System.Windows.Forms.Padding(2);
            //this.lvBestSeller.Name = "lvBestSeller";
            //this.lvBestSeller.Size = new System.Drawing.Size(625, 145);
            //this.lvBestSeller.TabIndex = 2;
            //this.lvBestSeller.UseCompatibleStateImageBehavior = false;
            // 
            // lbOtherMenu
            // 
            this.lbOtherMenu.AutoSize = true;
            this.lbOtherMenu.BackColor = System.Drawing.SystemColors.Control;
            this.lbOtherMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOtherMenu.Location = new System.Drawing.Point(18, 411);
            this.lbOtherMenu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbOtherMenu.Name = "lbOtherMenu";
            this.lbOtherMenu.Size = new System.Drawing.Size(133, 29);
            this.lbOtherMenu.TabIndex = 1;
            this.lbOtherMenu.Text = "Menu Khác";
            // 
            // lbBestSeller
            // 
            this.lbBestSeller.AutoSize = true;
            this.lbBestSeller.BackColor = System.Drawing.SystemColors.Control;
            this.lbBestSeller.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBestSeller.Location = new System.Drawing.Point(18, 210);
            this.lbBestSeller.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbBestSeller.Name = "lbBestSeller";
            this.lbBestSeller.Size = new System.Drawing.Size(161, 29);
            this.lbBestSeller.TabIndex = 1;
            this.lbBestSeller.Text = "Bán chạy nhất";
            // 
            // lbSpecial
            // 
            this.lbSpecial.AutoSize = true;
            this.lbSpecial.BackColor = System.Drawing.Color.MintCream;
            this.lbSpecial.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSpecial.Location = new System.Drawing.Point(18, -2);
            this.lbSpecial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSpecial.Name = "lbSpecial";
            this.lbSpecial.Padding = new System.Windows.Forms.Padding(10);
            this.lbSpecial.Size = new System.Drawing.Size(215, 49);
            this.lbSpecial.TabIndex = 1;
            this.lbSpecial.Text = "Đặc biệt tuần này";
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
            // fTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTimkiem;
        private System.Windows.Forms.TextBox txtbSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnOtherPrevious;
        private System.Windows.Forms.Button btnBSPrevious;
        private System.Windows.Forms.Button btnSpecPrevious;
        private System.Windows.Forms.Button btnOtherNext;
        private System.Windows.Forms.Button btnBSNext;
        private System.Windows.Forms.Button btnSpecNext;
        private System.Windows.Forms.Label lbOtherMenu;
        private System.Windows.Forms.Label lbBestSeller;
        private System.Windows.Forms.Label lbSpecial;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.FlowLayoutPanel fLPSpecial;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
