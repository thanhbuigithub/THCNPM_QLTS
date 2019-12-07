namespace QuanLyQuanTraSua
{
    partial class fThanhToan_ThanhVien
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
            this.btnTiep = new ePOSOne.btnProduct.ButtonModified();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rbtnNo = new System.Windows.Forms.RadioButton();
            this.rbtnYes = new System.Windows.Forms.RadioButton();
            this.lbUseAccumulatedPoints = new System.Windows.Forms.Label();
            this.txtbAccumulatedPointsReceived = new System.Windows.Forms.TextBox();
            this.lbAccumulatedPointsReceived = new System.Windows.Forms.Label();
            this.txtbAccumulatedPoints = new System.Windows.Forms.TextBox();
            this.lbAccumulatedPoints = new System.Windows.Forms.Label();
            this.txtbPhone = new System.Windows.Forms.TextBox();
            this.lbPhone = new System.Windows.Forms.Label();
            this.txtbName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnBack = new ePOSOne.btnProduct.ButtonModified();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 661);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnTiep);
            this.panel2.Location = new System.Drawing.Point(551, 600);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 61);
            this.panel2.TabIndex = 39;
            // 
            // btnTiep
            // 
            this.btnTiep.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnTiep.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTiep.FlatAppearance.BorderSize = 3;
            this.btnTiep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTiep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiep.Location = new System.Drawing.Point(18, 5);
            this.btnTiep.Name = "btnTiep";
            this.btnTiep.Size = new System.Drawing.Size(164, 43);
            this.btnTiep.TabIndex = 19;
            this.btnTiep.Text = "tiếp";
            this.btnTiep.UseVisualStyleBackColor = false;
            this.btnTiep.Click += new System.EventHandler(this.btnTiep_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rbtnNo);
            this.panel4.Controls.Add(this.rbtnYes);
            this.panel4.Controls.Add(this.lbUseAccumulatedPoints);
            this.panel4.Controls.Add(this.txtbAccumulatedPointsReceived);
            this.panel4.Controls.Add(this.lbAccumulatedPointsReceived);
            this.panel4.Controls.Add(this.txtbAccumulatedPoints);
            this.panel4.Controls.Add(this.lbAccumulatedPoints);
            this.panel4.Controls.Add(this.txtbPhone);
            this.panel4.Controls.Add(this.lbPhone);
            this.panel4.Controls.Add(this.txtbName);
            this.panel4.Controls.Add(this.lbName);
            this.panel4.Location = new System.Drawing.Point(27, 67);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(699, 514);
            this.panel4.TabIndex = 34;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // rbtnNo
            // 
            this.rbtnNo.AutoSize = true;
            this.rbtnNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.rbtnNo.Location = new System.Drawing.Point(242, 410);
            this.rbtnNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rbtnNo.Name = "rbtnNo";
            this.rbtnNo.Size = new System.Drawing.Size(93, 30);
            this.rbtnNo.TabIndex = 25;
            this.rbtnNo.TabStop = true;
            this.rbtnNo.Text = "Không";
            this.rbtnNo.UseVisualStyleBackColor = true;
            this.rbtnNo.CheckedChanged += new System.EventHandler(this.rbtnNo_CheckedChanged);
            // 
            // rbtnYes
            // 
            this.rbtnYes.AutoSize = true;
            this.rbtnYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.rbtnYes.Location = new System.Drawing.Point(242, 366);
            this.rbtnYes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rbtnYes.Name = "rbtnYes";
            this.rbtnYes.Size = new System.Drawing.Size(58, 30);
            this.rbtnYes.TabIndex = 24;
            this.rbtnYes.TabStop = true;
            this.rbtnYes.Text = "Có";
            this.rbtnYes.UseVisualStyleBackColor = true;
            this.rbtnYes.CheckedChanged += new System.EventHandler(this.rbtnYes_CheckedChanged_1);
            // 
            // lbUseAccumulatedPoints
            // 
            this.lbUseAccumulatedPoints.AutoSize = true;
            this.lbUseAccumulatedPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUseAccumulatedPoints.Location = new System.Drawing.Point(12, 368);
            this.lbUseAccumulatedPoints.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUseAccumulatedPoints.Name = "lbUseAccumulatedPoints";
            this.lbUseAccumulatedPoints.Size = new System.Drawing.Size(159, 26);
            this.lbUseAccumulatedPoints.TabIndex = 23;
            this.lbUseAccumulatedPoints.Text = "Sử dụng điểm :";
            // 
            // txtbAccumulatedPointsReceived
            // 
            this.txtbAccumulatedPointsReceived.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.txtbAccumulatedPointsReceived.Location = new System.Drawing.Point(242, 295);
            this.txtbAccumulatedPointsReceived.Margin = new System.Windows.Forms.Padding(2);
            this.txtbAccumulatedPointsReceived.Multiline = true;
            this.txtbAccumulatedPointsReceived.Name = "txtbAccumulatedPointsReceived";
            this.txtbAccumulatedPointsReceived.Size = new System.Drawing.Size(417, 34);
            this.txtbAccumulatedPointsReceived.TabIndex = 22;
            // 
            // lbAccumulatedPointsReceived
            // 
            this.lbAccumulatedPointsReceived.AutoSize = true;
            this.lbAccumulatedPointsReceived.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAccumulatedPointsReceived.Location = new System.Drawing.Point(12, 298);
            this.lbAccumulatedPointsReceived.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAccumulatedPointsReceived.Name = "lbAccumulatedPointsReceived";
            this.lbAccumulatedPointsReceived.Size = new System.Drawing.Size(226, 26);
            this.lbAccumulatedPointsReceived.TabIndex = 21;
            this.lbAccumulatedPointsReceived.Text = "Điểm tích lũy hiện tại :";
            // 
            // txtbAccumulatedPoints
            // 
            this.txtbAccumulatedPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.txtbAccumulatedPoints.Location = new System.Drawing.Point(242, 220);
            this.txtbAccumulatedPoints.Margin = new System.Windows.Forms.Padding(2);
            this.txtbAccumulatedPoints.Multiline = true;
            this.txtbAccumulatedPoints.Name = "txtbAccumulatedPoints";
            this.txtbAccumulatedPoints.Size = new System.Drawing.Size(417, 34);
            this.txtbAccumulatedPoints.TabIndex = 20;
            // 
            // lbAccumulatedPoints
            // 
            this.lbAccumulatedPoints.AutoSize = true;
            this.lbAccumulatedPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAccumulatedPoints.Location = new System.Drawing.Point(12, 223);
            this.lbAccumulatedPoints.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAccumulatedPoints.Name = "lbAccumulatedPoints";
            this.lbAccumulatedPoints.Size = new System.Drawing.Size(226, 26);
            this.lbAccumulatedPoints.TabIndex = 19;
            this.lbAccumulatedPoints.Text = "Điểm tích lũy hiện tại :";
            // 
            // txtbPhone
            // 
            this.txtbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.txtbPhone.Location = new System.Drawing.Point(135, 147);
            this.txtbPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtbPhone.Multiline = true;
            this.txtbPhone.Name = "txtbPhone";
            this.txtbPhone.Size = new System.Drawing.Size(524, 34);
            this.txtbPhone.TabIndex = 18;
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhone.Location = new System.Drawing.Point(12, 147);
            this.lbPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(61, 26);
            this.lbPhone.TabIndex = 17;
            this.lbPhone.Text = "SĐT:";
            // 
            // txtbName
            // 
            this.txtbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.txtbName.Location = new System.Drawing.Point(135, 77);
            this.txtbName.Margin = new System.Windows.Forms.Padding(2);
            this.txtbName.Multiline = true;
            this.txtbName.Name = "txtbName";
            this.txtbName.Size = new System.Drawing.Size(524, 34);
            this.txtbName.TabIndex = 16;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(12, 77);
            this.lbName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(54, 26);
            this.lbName.TabIndex = 15;
            this.lbName.Text = "Tên:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnBack);
            this.panel3.Location = new System.Drawing.Point(13, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(185, 61);
            this.panel3.TabIndex = 38;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBack.FlatAppearance.BorderSize = 3;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(3, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(164, 43);
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // fThanhToan_ThanhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 661);
            this.Controls.Add(this.panel1);
            this.Name = "fThanhToan_ThanhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fThanhToan_ThanhVien";
            this.Load += new System.EventHandler(this.fThanhToan_ThanhVien_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rbtnNo;
        private System.Windows.Forms.RadioButton rbtnYes;
        private System.Windows.Forms.Label lbUseAccumulatedPoints;
        private System.Windows.Forms.TextBox txtbAccumulatedPointsReceived;
        private System.Windows.Forms.Label lbAccumulatedPointsReceived;
        private System.Windows.Forms.TextBox txtbAccumulatedPoints;
        private System.Windows.Forms.Label lbAccumulatedPoints;
        private System.Windows.Forms.TextBox txtbPhone;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.TextBox txtbName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Panel panel2;
        private ePOSOne.btnProduct.ButtonModified btnTiep;
        private System.Windows.Forms.Panel panel3;
        private ePOSOne.btnProduct.ButtonModified btnBack;

    }
}