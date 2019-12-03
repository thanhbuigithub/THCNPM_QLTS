namespace QuanLyQuanTraSua
{
    partial class Product
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picProduct = new System.Windows.Forms.PictureBox();
            this.tbProductName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // picProduct
            // 
            this.picProduct.Location = new System.Drawing.Point(8, 8);
            this.picProduct.Name = "picProduct";
            this.picProduct.Size = new System.Drawing.Size(152, 128);
            this.picProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProduct.TabIndex = 0;
            this.picProduct.TabStop = false;
            // 
            // tbProductName
            // 
            this.tbProductName.BackColor = System.Drawing.SystemColors.Control;
            this.tbProductName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbProductName.Location = new System.Drawing.Point(0, 144);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.ReadOnly = true;
            this.tbProductName.Size = new System.Drawing.Size(168, 15);
            this.tbProductName.TabIndex = 2;
            this.tbProductName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbProductName);
            this.Controls.Add(this.picProduct);
            this.Name = "Product";
            this.Size = new System.Drawing.Size(168, 168);
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picProduct;
        private System.Windows.Forms.TextBox tbProductName;
    }
}
