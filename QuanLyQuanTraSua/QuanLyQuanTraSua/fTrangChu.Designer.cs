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
            this.panelOrther = new System.Windows.Forms.Panel();
            this.fLPOrther = new System.Windows.Forms.FlowLayoutPanel();
            this.panelBestSeller = new System.Windows.Forms.Panel();
            this.fLPBestSeller = new System.Windows.Forms.FlowLayoutPanel();
            this.panelSpecList = new System.Windows.Forms.Panel();
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
            this.panelOrther.SuspendLayout();
            this.panelBestSeller.SuspendLayout();
            this.panelSpecList.SuspendLayout();
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
            this.txtbSearch.TextChanged += new System.EventHandler(this.txtbSearch_TextChanged);
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
            this.panel2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel2.Controls.Add(this.btnProduct);
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
            this.pictureBoxLogo.Location = new System.Drawing.Point(3, 2);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(235, 165);
            this.pictureBoxLogo.TabIndex = 1;
            this.pictureBoxLogo.TabStop = false;
            //
            // panel3
            //
            this.panel3.Controls.Add(this.panelOrther);
            this.panel3.Controls.Add(this.panelBestSeller);
            this.panel3.Controls.Add(this.panelSpecList);
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
            // panelOrther
            //
            this.panelOrther.Controls.Add(this.fLPOrther);
            this.panelOrther.Location = new System.Drawing.Point(72, 544);
            this.panelOrther.Name = "panelOrther";
            this.panelOrther.Size = new System.Drawing.Size(830, 188);
            this.panelOrther.TabIndex = 5;
            //
            // fLPOrther
            //
            this.fLPOrther.AutoScroll = true;
            this.fLPOrther.BackColor = System.Drawing.SystemColors.Control;
            this.fLPOrther.Location = new System.Drawing.Point(0, 1);
            this.fLPOrther.Margin = new System.Windows.Forms.Padding(4);
            this.fLPOrther.Name = "fLPOrther";
            this.fLPOrther.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fLPOrther.Size = new System.Drawing.Size(829, 188);
            this.fLPOrther.TabIndex = 4;
            this.fLPOrther.WrapContents = false;
            //
            // panelBestSeller
            //
            this.panelBestSeller.Controls.Add(this.fLPBestSeller);
            this.panelBestSeller.Location = new System.Drawing.Point(72, 304);
            this.panelBestSeller.Name = "panelBestSeller";
            this.panelBestSeller.Size = new System.Drawing.Size(830, 188);
            this.panelBestSeller.TabIndex = 5;
            //
            // fLPBestSeller
            //
            this.fLPBestSeller.AutoScroll = true;
            this.fLPBestSeller.BackColor = System.Drawing.SystemColors.Control;
            this.fLPBestSeller.Location = new System.Drawing.Point(0, 1);
            this.fLPBestSeller.Margin = new System.Windows.Forms.Padding(4);
            this.fLPBestSeller.Name = "fLPBestSeller";
            this.fLPBestSeller.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fLPBestSeller.Size = new System.Drawing.Size(829, 188);
            this.fLPBestSeller.TabIndex = 4;
            this.fLPBestSeller.WrapContents = false;
            //
            // panelSpecList
            //
            this.panelSpecList.Controls.Add(this.fLPSpecial);
            this.panelSpecList.Location = new System.Drawing.Point(73, 61);
            this.panelSpecList.Name = "panelSpecList";
            this.panelSpecList.Size = new System.Drawing.Size(830, 188);
            this.panelSpecList.TabIndex = 5;
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
            // // btnOtherPrevious
            // //
            // this.btnOtherPrevious.Location = new System.Drawing.Point(3, 562);
            // this.btnOtherPrevious.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // this.btnOtherPrevious.Name = "btnOtherPrevious";
            // this.btnOtherPrevious.Size = new System.Drawing.Size(64, 132);
            // this.btnOtherPrevious.TabIndex = 3;
            // this.btnOtherPrevious.Text = "button1";
            // this.btnOtherPrevious.UseVisualStyleBackColor = true;
            // this.btnOtherPrevious.Click += new System.EventHandler(this.btnOtherPrevious_Click);
            // //
            // // btnBSPrevious
            // //
            // this.btnBSPrevious.Location = new System.Drawing.Point(3, 321);
            // this.btnBSPrevious.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // this.btnBSPrevious.Name = "btnBSPrevious";
            // this.btnBSPrevious.Size = new System.Drawing.Size(64, 140);
            // this.btnBSPrevious.TabIndex = 3;
            // this.btnBSPrevious.Text = "button1";
            // this.btnBSPrevious.UseVisualStyleBackColor = true;
            // this.btnBSPrevious.Click += new System.EventHandler(this.btnBSPrevious_Click);
            // //
            // // btnSpecPrevious
            // //
            // this.btnSpecPrevious.Location = new System.Drawing.Point(3, 70);
            // this.btnSpecPrevious.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // this.btnSpecPrevious.Name = "btnSpecPrevious";
            // this.btnSpecPrevious.Size = new System.Drawing.Size(64, 123);
            // this.btnSpecPrevious.TabIndex = 3;
            // this.btnSpecPrevious.Text = "button1";
            // this.btnSpecPrevious.UseVisualStyleBackColor = true;
            // this.btnSpecPrevious.Click += new System.EventHandler(this.btnSpecPrevious_Click);
            // //
            // // btnOtherNext
            // //
            // this.btnOtherNext.Location = new System.Drawing.Point(909, 559);
            // this.btnOtherNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // this.btnOtherNext.Name = "btnOtherNext";
            // this.btnOtherNext.Size = new System.Drawing.Size(64, 132);
            // this.btnOtherNext.TabIndex = 3;
            // this.btnOtherNext.Text = "button1";
            // this.btnOtherNext.UseVisualStyleBackColor = true;
            // this.btnOtherNext.Click += new System.EventHandler(this.btnOtherNext_Click);
            // //
            // // btnBSNext
            // //
            // this.btnBSNext.Location = new System.Drawing.Point(909, 318);
            // this.btnBSNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // this.btnBSNext.Name = "btnBSNext";
            // this.btnBSNext.Size = new System.Drawing.Size(64, 140);
            // this.btnBSNext.TabIndex = 3;
            // this.btnBSNext.Text = "button1";
            // this.btnBSNext.UseVisualStyleBackColor = true;
            // this.btnBSNext.Click += new System.EventHandler(this.btnBSNext_Click);
            // //
            // // btnSpecNext
            // //
            // this.btnSpecNext.Location = new System.Drawing.Point(909, 66);
            // this.btnSpecNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // this.btnSpecNext.Name = "btnSpecNext";
            // this.btnSpecNext.Size = new System.Drawing.Size(64, 127);
            // this.btnSpecNext.TabIndex = 3;
            // this.btnSpecNext.Text = "button1";
            // this.btnSpecNext.UseVisualStyleBackColor = true;
            // this.btnSpecNext.Click += new System.EventHandler(this.btnSpecNext_Click);
            // //
            // // lbOtherMenu
            // //
            // this.lbOtherMenu.AutoSize = true;
            // this.lbOtherMenu.BackColor = System.Drawing.SystemColors.Control;
            // this.lbOtherMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // this.lbOtherMenu.Location = new System.Drawing.Point(24, 506);
            // this.lbOtherMenu.Name = "lbOtherMenu";
            // this.lbOtherMenu.Size = new System.Drawing.Size(166, 36);
            // this.lbOtherMenu.TabIndex = 1;
            // this.lbOtherMenu.Text = "Menu Khác";
            // //
            // // lbBestSeller
            // //
            // this.lbBestSeller.AutoSize = true;
            // this.lbBestSeller.BackColor = System.Drawing.SystemColors.Control;
            // this.lbBestSeller.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // this.lbBestSeller.Location = new System.Drawing.Point(24, 258);
            // this.lbBestSeller.Name = "lbBestSeller";
            // this.lbBestSeller.Size = new System.Drawing.Size(205, 36);
            // this.lbBestSeller.TabIndex = 1;
            // this.lbBestSeller.Text = "Bán chạy nhất";
            // //
            // // lbSpecial
            // //
            // this.lbSpecial.AutoSize = true;
            // this.lbSpecial.BackColor = System.Drawing.Color.MintCream;
            // this.lbSpecial.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // this.lbSpecial.Location = new System.Drawing.Point(24, -2);
            // this.lbSpecial.Name = "lbSpecial";
            // this.lbSpecial.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            // this.lbSpecial.Size = new System.Drawing.Size(271, 60);
            // this.lbSpecial.TabIndex = 1;
            // this.lbSpecial.Text = "Đặc biệt tuần này";
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
            this.btnSpecPrevious.Click += new System.EventHandler(this.btnSpecPrevious_Click);
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
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
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

            //
            // fTrangChu
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
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
            this.panelOrther.ResumeLayout(false);
            this.panelBestSeller.ResumeLayout(false);
            this.panelSpecList.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panelSpecList;
        private System.Windows.Forms.Panel panelOrther;
        private System.Windows.Forms.FlowLayoutPanel fLPOrther;
        private System.Windows.Forms.Panel panelBestSeller;
        private System.Windows.Forms.FlowLayoutPanel fLPBestSeller;
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
