﻿namespace QuanLyQuanTraSua
{
    partial class fKhachHang
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
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.directorySearcher2 = new System.DirectoryServices.DirectorySearcher();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbListCLoseCustomer = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddCloseCustomer = new System.Windows.Forms.Button();
            this.lbSearch = new System.Windows.Forms.Label();
            this.txtbSeach = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // directorySearcher2
            // 
            this.directorySearcher2.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher2.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher2.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 730);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbListCLoseCustomer);
            this.panel3.Controls.Add(this.btnBack);
            this.panel3.Location = new System.Drawing.Point(14, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(980, 70);
            this.panel3.TabIndex = 37;
            // 
            // lbListCLoseCustomer
            // 
            this.lbListCLoseCustomer.AutoSize = true;
            this.lbListCLoseCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListCLoseCustomer.Location = new System.Drawing.Point(291, 29);
            this.lbListCLoseCustomer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbListCLoseCustomer.Name = "lbListCLoseCustomer";
            this.lbListCLoseCustomer.Size = new System.Drawing.Size(525, 39);
            this.lbListCLoseCustomer.TabIndex = 20;
            this.lbListCLoseCustomer.Text = "Danh sách thành viên thân thiết";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(7, 9);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(124, 40);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAddCloseCustomer);
            this.panel2.Controls.Add(this.lbSearch);
            this.panel2.Controls.Add(this.txtbSeach);
            this.panel2.Location = new System.Drawing.Point(14, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(980, 73);
            this.panel2.TabIndex = 36;
            // 
            // btnAddCloseCustomer
            // 
            this.btnAddCloseCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCloseCustomer.Location = new System.Drawing.Point(810, 17);
            this.btnAddCloseCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddCloseCustomer.Name = "btnAddCloseCustomer";
            this.btnAddCloseCustomer.Size = new System.Drawing.Size(124, 40);
            this.btnAddCloseCustomer.TabIndex = 22;
            this.btnAddCloseCustomer.Text = "Thêm";
            this.btnAddCloseCustomer.UseVisualStyleBackColor = true;
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearch.Location = new System.Drawing.Point(2, 31);
            this.lbSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(137, 32);
            this.lbSearch.TabIndex = 20;
            this.lbSearch.Text = "Tìm kiếm:";
            // 
            // txtbSeach
            // 
            this.txtbSeach.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.txtbSeach.Location = new System.Drawing.Point(124, 23);
            this.txtbSeach.Margin = new System.Windows.Forms.Padding(2);
            this.txtbSeach.Multiline = true;
            this.txtbSeach.Name = "txtbSeach";
            this.txtbSeach.Size = new System.Drawing.Size(430, 34);
            this.txtbSeach.TabIndex = 21;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 171);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(980, 544);
            this.dataGridView1.TabIndex = 35;
            // 
            // fKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "fKhachHang";
            this.Text = "fKhachHang";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.DirectoryServices.DirectorySearcher directorySearcher2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbListCLoseCustomer;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddCloseCustomer;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.TextBox txtbSeach;
        private System.Windows.Forms.DataGridView dataGridView1;

    }
}