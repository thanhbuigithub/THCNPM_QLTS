namespace QuanLyQuanTraSua
{
    partial class fThanhToan
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
            this.rbtnCloseCustomer = new System.Windows.Forms.RadioButton();
            this.rbtnNormalCustomer = new System.Windows.Forms.RadioButton();
            this.lbCustomerType = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtnCloseCustomer);
            this.panel1.Controls.Add(this.rbtnNormalCustomer);
            this.panel1.Controls.Add(this.lbCustomerType);
            this.panel1.Location = new System.Drawing.Point(59, 152);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 343);
            this.panel1.TabIndex = 2;
            // 
            // rbtnCloseCustomer
            // 
            this.rbtnCloseCustomer.AutoSize = true;
            this.rbtnCloseCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.rbtnCloseCustomer.Location = new System.Drawing.Point(279, 135);
            this.rbtnCloseCustomer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rbtnCloseCustomer.Name = "rbtnCloseCustomer";
            this.rbtnCloseCustomer.Size = new System.Drawing.Size(252, 30);
            this.rbtnCloseCustomer.TabIndex = 7;
            this.rbtnCloseCustomer.TabStop = true;
            this.rbtnCloseCustomer.Text = "Khách hàng thành viên";
            this.rbtnCloseCustomer.UseVisualStyleBackColor = true;
            // 
            // rbtnNormalCustomer
            // 
            this.rbtnNormalCustomer.AutoSize = true;
            this.rbtnNormalCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.rbtnNormalCustomer.Location = new System.Drawing.Point(279, 91);
            this.rbtnNormalCustomer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rbtnNormalCustomer.Name = "rbtnNormalCustomer";
            this.rbtnNormalCustomer.Size = new System.Drawing.Size(218, 30);
            this.rbtnNormalCustomer.TabIndex = 6;
            this.rbtnNormalCustomer.TabStop = true;
            this.rbtnNormalCustomer.Text = "Khách hàng thường";
            this.rbtnNormalCustomer.UseVisualStyleBackColor = true;
            // 
            // lbCustomerType
            // 
            this.lbCustomerType.AutoSize = true;
            this.lbCustomerType.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCustomerType.Location = new System.Drawing.Point(43, 91);
            this.lbCustomerType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCustomerType.Name = "lbCustomerType";
            this.lbCustomerType.Size = new System.Drawing.Size(209, 29);
            this.lbCustomerType.TabIndex = 5;
            this.lbCustomerType.Text = "Loại khách hàng:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnBack);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(185, 61);
            this.panel3.TabIndex = 33;
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
            // 
            // fThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 662);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "fThanhToan";
            this.Text = "fThanhToan";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtnCloseCustomer;
        private System.Windows.Forms.RadioButton rbtnNormalCustomer;
        private System.Windows.Forms.Label lbCustomerType;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnBack;
    }
}