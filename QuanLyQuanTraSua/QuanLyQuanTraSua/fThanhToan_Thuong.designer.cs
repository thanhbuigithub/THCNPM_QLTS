namespace QuanLyQuanTraSua
{
    partial class fThanhToan_Thuong
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
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtbTotalMoney = new System.Windows.Forms.TextBox();
            this.lbTotalMoney = new System.Windows.Forms.Label();
            this.txtbMoneyReceived = new System.Windows.Forms.TextBox();
            this.lbMoneyReceived = new System.Windows.Forms.Label();
            this.txtbChange = new System.Windows.Forms.TextBox();
            this.lbChange = new System.Windows.Forms.Label();
            this.rbtnCast = new System.Windows.Forms.RadioButton();
            this.rbtnCard = new System.Windows.Forms.RadioButton();
            this.lbTypeOfPayment = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbDateOfPayment = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(426, 626);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(124, 40);
            this.btnNext.TabIndex = 17;
            this.btnNext.Text = "Tiếp";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(11, 11);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(124, 40);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // txtbTotalMoney
            // 
            this.txtbTotalMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.txtbTotalMoney.Location = new System.Drawing.Point(250, 113);
            this.txtbTotalMoney.Margin = new System.Windows.Forms.Padding(2);
            this.txtbTotalMoney.Multiline = true;
            this.txtbTotalMoney.Name = "txtbTotalMoney";
            this.txtbTotalMoney.Size = new System.Drawing.Size(491, 34);
            this.txtbTotalMoney.TabIndex = 19;
            this.txtbTotalMoney.TextChanged += new System.EventHandler(this.txtbAccumulatedPoints_TextChanged);
            // 
            // lbTotalMoney
            // 
            this.lbTotalMoney.AutoSize = true;
            this.lbTotalMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalMoney.Location = new System.Drawing.Point(20, 121);
            this.lbTotalMoney.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTotalMoney.Name = "lbTotalMoney";
            this.lbTotalMoney.Size = new System.Drawing.Size(113, 26);
            this.lbTotalMoney.TabIndex = 18;
            this.lbTotalMoney.Text = "Tổng tiền :";
            this.lbTotalMoney.Click += new System.EventHandler(this.lbAccumulatedPoints_Click);
            // 
            // txtbMoneyReceived
            // 
            this.txtbMoneyReceived.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.txtbMoneyReceived.Location = new System.Drawing.Point(250, 188);
            this.txtbMoneyReceived.Margin = new System.Windows.Forms.Padding(2);
            this.txtbMoneyReceived.Multiline = true;
            this.txtbMoneyReceived.Name = "txtbMoneyReceived";
            this.txtbMoneyReceived.Size = new System.Drawing.Size(491, 34);
            this.txtbMoneyReceived.TabIndex = 21;
            // 
            // lbMoneyReceived
            // 
            this.lbMoneyReceived.AutoSize = true;
            this.lbMoneyReceived.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMoneyReceived.Location = new System.Drawing.Point(20, 196);
            this.lbMoneyReceived.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMoneyReceived.Name = "lbMoneyReceived";
            this.lbMoneyReceived.Size = new System.Drawing.Size(172, 26);
            this.lbMoneyReceived.TabIndex = 20;
            this.lbMoneyReceived.Text = "Tiền nhận được :";
            // 
            // txtbChange
            // 
            this.txtbChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.txtbChange.Location = new System.Drawing.Point(250, 266);
            this.txtbChange.Margin = new System.Windows.Forms.Padding(2);
            this.txtbChange.Multiline = true;
            this.txtbChange.Name = "txtbChange";
            this.txtbChange.Size = new System.Drawing.Size(491, 34);
            this.txtbChange.TabIndex = 23;
            this.txtbChange.TextChanged += new System.EventHandler(this.txtbAccumulatedPoints_TextChanged_1);
            // 
            // lbChange
            // 
            this.lbChange.AutoSize = true;
            this.lbChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChange.Location = new System.Drawing.Point(20, 274);
            this.lbChange.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbChange.Name = "lbChange";
            this.lbChange.Size = new System.Drawing.Size(100, 26);
            this.lbChange.TabIndex = 22;
            this.lbChange.Text = "Tiền thối:";
            this.lbChange.Click += new System.EventHandler(this.lbAccumulatedPoints_Click_1);
            // 
            // rbtnCast
            // 
            this.rbtnCast.AutoSize = true;
            this.rbtnCast.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.rbtnCast.Location = new System.Drawing.Point(250, 391);
            this.rbtnCast.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rbtnCast.Name = "rbtnCast";
            this.rbtnCast.Size = new System.Drawing.Size(114, 30);
            this.rbtnCast.TabIndex = 26;
            this.rbtnCast.TabStop = true;
            this.rbtnCast.Text = "Tiền mặt";
            this.rbtnCast.UseVisualStyleBackColor = true;
            this.rbtnCast.CheckedChanged += new System.EventHandler(this.rbtnNo_CheckedChanged);
            // 
            // rbtnCard
            // 
            this.rbtnCard.AutoSize = true;
            this.rbtnCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.rbtnCard.Location = new System.Drawing.Point(250, 347);
            this.rbtnCard.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rbtnCard.Name = "rbtnCard";
            this.rbtnCard.Size = new System.Drawing.Size(66, 30);
            this.rbtnCard.TabIndex = 25;
            this.rbtnCard.TabStop = true;
            this.rbtnCard.Text = "Thẻ";
            this.rbtnCard.UseVisualStyleBackColor = true;
            // 
            // lbTypeOfPayment
            // 
            this.lbTypeOfPayment.AutoSize = true;
            this.lbTypeOfPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTypeOfPayment.Location = new System.Drawing.Point(20, 349);
            this.lbTypeOfPayment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTypeOfPayment.Name = "lbTypeOfPayment";
            this.lbTypeOfPayment.Size = new System.Drawing.Size(224, 26);
            this.lbTypeOfPayment.TabIndex = 24;
            this.lbTypeOfPayment.Text = "Hình thức thanh toán :";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(7, 642);
            this.lbDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(49, 16);
            this.lbDate.TabIndex = 27;
            this.lbDate.Text = "Ngày:";
            // 
            // lbDateOfPayment
            // 
            this.lbDateOfPayment.AutoSize = true;
            this.lbDateOfPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbDateOfPayment.Location = new System.Drawing.Point(60, 641);
            this.lbDateOfPayment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDateOfPayment.Name = "lbDateOfPayment";
            this.lbDateOfPayment.Size = new System.Drawing.Size(100, 17);
            this.lbDateOfPayment.TabIndex = 28;
            this.lbDateOfPayment.Text = "dd - mm - yyyy";
            // 
            // fThanhToan_Thuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 662);
            this.Controls.Add(this.lbDateOfPayment);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.rbtnCast);
            this.Controls.Add(this.rbtnCard);
            this.Controls.Add(this.lbTypeOfPayment);
            this.Controls.Add(this.txtbChange);
            this.Controls.Add(this.lbChange);
            this.Controls.Add(this.txtbMoneyReceived);
            this.Controls.Add(this.lbMoneyReceived);
            this.Controls.Add(this.txtbTotalMoney);
            this.Controls.Add(this.lbTotalMoney);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Name = "fThanhToan_Thuong";
            this.Text = "fThanhToan_Thuong";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtbTotalMoney;
        private System.Windows.Forms.Label lbTotalMoney;
        private System.Windows.Forms.TextBox txtbMoneyReceived;
        private System.Windows.Forms.Label lbMoneyReceived;
        private System.Windows.Forms.TextBox txtbChange;
        private System.Windows.Forms.Label lbChange;
        private System.Windows.Forms.RadioButton rbtnCast;
        private System.Windows.Forms.RadioButton rbtnCard;
        private System.Windows.Forms.Label lbTypeOfPayment;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbDateOfPayment;
    }
}