﻿namespace QuanLyQuanTraSua
{
    partial class fKhachhang_ThemSua
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDone = new ePOSOne.btnProduct.ButtonModified();
            this.btnXoa = new ePOSOne.btnProduct.ButtonModified();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnBack = new ePOSOne.btnProduct.ButtonModified();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtbAccumulatedPoints = new System.Windows.Forms.TextBox();
            this.lbAccumulatedPoints = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.lbDateOfBirth = new System.Windows.Forms.Label();
            this.txtbMail = new System.Windows.Forms.TextBox();
            this.lbMail = new System.Windows.Forms.Label();
            this.txtbPhone = new System.Windows.Forms.TextBox();
            this.lbPhone = new System.Windows.Forms.Label();
            this.txtbName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 717);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDone);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Location = new System.Drawing.Point(0, 636);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1005, 67);
            this.panel2.TabIndex = 37;
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDone.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDone.FlatAppearance.BorderSize = 3;
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.Location = new System.Drawing.Point(863, 22);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(133, 37);
            this.btnDone.TabIndex = 21;
            this.btnDone.Text = "Thêm";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click_1);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnXoa.FlatAppearance.BorderSize = 3;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(10, 22);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(116, 37);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnBack);
            this.panel3.Location = new System.Drawing.Point(0, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(185, 61);
            this.panel3.TabIndex = 36;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBack.FlatAppearance.BorderSize = 3;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(10, 9);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(164, 43);
            this.btnBack.TabIndex = 20;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtbAccumulatedPoints);
            this.panel4.Controls.Add(this.lbAccumulatedPoints);
            this.panel4.Controls.Add(this.dtpDateOfBirth);
            this.panel4.Controls.Add(this.lbDateOfBirth);
            this.panel4.Controls.Add(this.txtbMail);
            this.panel4.Controls.Add(this.lbMail);
            this.panel4.Controls.Add(this.txtbPhone);
            this.panel4.Controls.Add(this.lbPhone);
            this.panel4.Controls.Add(this.txtbName);
            this.panel4.Controls.Add(this.lbName);
            this.panel4.Location = new System.Drawing.Point(17, 95);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(986, 535);
            this.panel4.TabIndex = 35;
            // 
            // txtbAccumulatedPoints
            // 
            this.txtbAccumulatedPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.txtbAccumulatedPoints.Location = new System.Drawing.Point(173, 407);
            this.txtbAccumulatedPoints.Margin = new System.Windows.Forms.Padding(2);
            this.txtbAccumulatedPoints.Multiline = true;
            this.txtbAccumulatedPoints.Name = "txtbAccumulatedPoints";
            this.txtbAccumulatedPoints.Size = new System.Drawing.Size(777, 33);
            this.txtbAccumulatedPoints.TabIndex = 27;
            // 
            // lbAccumulatedPoints
            // 
            this.lbAccumulatedPoints.AutoSize = true;
            this.lbAccumulatedPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAccumulatedPoints.Location = new System.Drawing.Point(19, 415);
            this.lbAccumulatedPoints.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAccumulatedPoints.Name = "lbAccumulatedPoints";
            this.lbAccumulatedPoints.Size = new System.Drawing.Size(150, 26);
            this.lbAccumulatedPoints.TabIndex = 26;
            this.lbAccumulatedPoints.Text = "Điểm tích lũy :";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.dtpDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.dtpDateOfBirth.Location = new System.Drawing.Point(173, 327);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(777, 32);
            this.dtpDateOfBirth.TabIndex = 25;
            this.dtpDateOfBirth.Value = new System.DateTime(2019, 11, 14, 0, 0, 0, 0);
            // 
            // lbDateOfBirth
            // 
            this.lbDateOfBirth.AutoSize = true;
            this.lbDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateOfBirth.Location = new System.Drawing.Point(19, 333);
            this.lbDateOfBirth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDateOfBirth.Name = "lbDateOfBirth";
            this.lbDateOfBirth.Size = new System.Drawing.Size(115, 26);
            this.lbDateOfBirth.TabIndex = 24;
            this.lbDateOfBirth.Text = "Ngày sinh:";
            // 
            // txtbMail
            // 
            this.txtbMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.txtbMail.Location = new System.Drawing.Point(173, 242);
            this.txtbMail.Margin = new System.Windows.Forms.Padding(2);
            this.txtbMail.Multiline = true;
            this.txtbMail.Name = "txtbMail";
            this.txtbMail.Size = new System.Drawing.Size(777, 34);
            this.txtbMail.TabIndex = 23;
            // 
            // lbMail
            // 
            this.lbMail.AutoSize = true;
            this.lbMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMail.Location = new System.Drawing.Point(19, 250);
            this.lbMail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMail.Name = "lbMail";
            this.lbMail.Size = new System.Drawing.Size(58, 26);
            this.lbMail.TabIndex = 22;
            this.lbMail.Text = "Mail:";
            // 
            // txtbPhone
            // 
            this.txtbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.txtbPhone.Location = new System.Drawing.Point(173, 148);
            this.txtbPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtbPhone.Multiline = true;
            this.txtbPhone.Name = "txtbPhone";
            this.txtbPhone.Size = new System.Drawing.Size(777, 34);
            this.txtbPhone.TabIndex = 21;
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhone.Location = new System.Drawing.Point(19, 156);
            this.lbPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(61, 26);
            this.lbPhone.TabIndex = 20;
            this.lbPhone.Text = "SĐT:";
            // 
            // txtbName
            // 
            this.txtbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.txtbName.Location = new System.Drawing.Point(173, 44);
            this.txtbName.Margin = new System.Windows.Forms.Padding(2);
            this.txtbName.Multiline = true;
            this.txtbName.Name = "txtbName";
            this.txtbName.Size = new System.Drawing.Size(777, 34);
            this.txtbName.TabIndex = 19;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(19, 52);
            this.lbName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(54, 26);
            this.lbName.TabIndex = 18;
            this.lbName.Text = "Tên:";
            // 
            // fKhachhang_ThemSua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 717);
            this.Controls.Add(this.panel1);
            this.Name = "fKhachhang_ThemSua";
            this.Text = "fKhachhang_ThemSua";
            this.Load += new System.EventHandler(this.fKhachhang_ThemSua_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtbAccumulatedPoints;
        private System.Windows.Forms.Label lbAccumulatedPoints;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Label lbDateOfBirth;
        private System.Windows.Forms.TextBox txtbMail;
        private System.Windows.Forms.Label lbMail;
        private System.Windows.Forms.TextBox txtbPhone;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.TextBox txtbName;
        private System.Windows.Forms.Label lbName;
        private ePOSOne.btnProduct.ButtonModified btnBack;
        private ePOSOne.btnProduct.ButtonModified btnDone;
        private ePOSOne.btnProduct.ButtonModified btnXoa;

    }
}