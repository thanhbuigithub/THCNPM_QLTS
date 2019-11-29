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
            this.btnBack = new System.Windows.Forms.Button();
            this.lbCustomerType = new System.Windows.Forms.Label();
            this.rbtnNormalCustomer = new System.Windows.Forms.RadioButton();
            this.rbtnCloseCustomer = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(11, 11);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(124, 40);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lbCustomerType
            // 
            this.lbCustomerType.AutoSize = true;
            this.lbCustomerType.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCustomerType.Location = new System.Drawing.Point(14, 276);
            this.lbCustomerType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCustomerType.Name = "lbCustomerType";
            this.lbCustomerType.Size = new System.Drawing.Size(209, 29);
            this.lbCustomerType.TabIndex = 2;
            this.lbCustomerType.Text = "Loại khách hàng:";
            // 
            // rbtnNormalCustomer
            // 
            this.rbtnNormalCustomer.AutoSize = true;
            this.rbtnNormalCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.rbtnNormalCustomer.Location = new System.Drawing.Point(250, 276);
            this.rbtnNormalCustomer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rbtnNormalCustomer.Name = "rbtnNormalCustomer";
            this.rbtnNormalCustomer.Size = new System.Drawing.Size(218, 30);
            this.rbtnNormalCustomer.TabIndex = 3;
            this.rbtnNormalCustomer.TabStop = true;
            this.rbtnNormalCustomer.Text = "Khách hàng thường";
            this.rbtnNormalCustomer.UseVisualStyleBackColor = true;
            this.rbtnNormalCustomer.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbtnCloseCustomer
            // 
            this.rbtnCloseCustomer.AutoSize = true;
            this.rbtnCloseCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.rbtnCloseCustomer.Location = new System.Drawing.Point(250, 320);
            this.rbtnCloseCustomer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rbtnCloseCustomer.Name = "rbtnCloseCustomer";
            this.rbtnCloseCustomer.Size = new System.Drawing.Size(252, 30);
            this.rbtnCloseCustomer.TabIndex = 4;
            this.rbtnCloseCustomer.TabStop = true;
            this.rbtnCloseCustomer.Text = "Khách hàng thành viên";
            this.rbtnCloseCustomer.UseVisualStyleBackColor = true;
            // 
            // fThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 662);
            this.Controls.Add(this.rbtnCloseCustomer);
            this.Controls.Add(this.rbtnNormalCustomer);
            this.Controls.Add(this.lbCustomerType);
            this.Controls.Add(this.btnBack);
            this.Name = "fThanhToan";
            this.Text = "fThanhToan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lbCustomerType;
        private System.Windows.Forms.RadioButton rbtnNormalCustomer;
        private System.Windows.Forms.RadioButton rbtnCloseCustomer;
    }
}