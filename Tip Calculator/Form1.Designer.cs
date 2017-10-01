namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.labelCharges = new System.Windows.Forms.Label();
            this.labelTipAmount = new System.Windows.Forms.Label();
            this.charges = new System.Windows.Forms.TextBox();
            this.radioButtonTip1 = new System.Windows.Forms.RadioButton();
            this.radioButtonTip2 = new System.Windows.Forms.RadioButton();
            this.tip = new System.Windows.Forms.TextBox();
            this.buttonCal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.labelTotalBalance = new System.Windows.Forms.Label();
            this.balance = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCharges
            // 
            this.labelCharges.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCharges.Location = new System.Drawing.Point(98, 156);
            this.labelCharges.Name = "labelCharges";
            this.labelCharges.Size = new System.Drawing.Size(193, 67);
            this.labelCharges.TabIndex = 0;
            this.labelCharges.Text = "Charges:";
            this.labelCharges.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTipAmount
            // 
            this.labelTipAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipAmount.Location = new System.Drawing.Point(98, 369);
            this.labelTipAmount.Name = "labelTipAmount";
            this.labelTipAmount.Size = new System.Drawing.Size(218, 88);
            this.labelTipAmount.TabIndex = 3;
            this.labelTipAmount.Text = "Tip Amount";
            this.labelTipAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // charges
            // 
            this.charges.Location = new System.Drawing.Point(425, 168);
            this.charges.Name = "charges";
            this.charges.Size = new System.Drawing.Size(238, 44);
            this.charges.TabIndex = 4;
            this.charges.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.charges.TextChanged += new System.EventHandler(this.textBoxCharges_TextChanged);
            this.charges.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.charges_KeyPress);
            // 
            // radioButtonTip1
            // 
            this.radioButtonTip1.AutoSize = true;
            this.radioButtonTip1.Location = new System.Drawing.Point(404, 242);
            this.radioButtonTip1.Name = "radioButtonTip1";
            this.radioButtonTip1.Size = new System.Drawing.Size(123, 41);
            this.radioButtonTip1.TabIndex = 6;
            this.radioButtonTip1.TabStop = true;
            this.radioButtonTip1.Text = "15%";
            this.radioButtonTip1.UseVisualStyleBackColor = true;
            // 
            // radioButtonTip2
            // 
            this.radioButtonTip2.AutoSize = true;
            this.radioButtonTip2.Location = new System.Drawing.Point(404, 309);
            this.radioButtonTip2.Name = "radioButtonTip2";
            this.radioButtonTip2.Size = new System.Drawing.Size(125, 41);
            this.radioButtonTip2.TabIndex = 7;
            this.radioButtonTip2.TabStop = true;
            this.radioButtonTip2.Text = "20%";
            this.radioButtonTip2.UseVisualStyleBackColor = true;
            // 
            // tip
            // 
            this.tip.Location = new System.Drawing.Point(425, 402);
            this.tip.Name = "tip";
            this.tip.ReadOnly = true;
            this.tip.Size = new System.Drawing.Size(238, 44);
            this.tip.TabIndex = 8;
            // 
            // buttonCal
            // 
            this.buttonCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCal.Location = new System.Drawing.Point(143, 666);
            this.buttonCal.Name = "buttonCal";
            this.buttonCal.Size = new System.Drawing.Size(230, 83);
            this.buttonCal.TabIndex = 9;
            this.buttonCal.Text = "Calculate";
            this.buttonCal.UseVisualStyleBackColor = true;
            this.buttonCal.Click += new System.EventHandler(this.buttonCal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(53, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(648, 108);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tip Calculator";
            // 
            // reset
            // 
            this.reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.Location = new System.Drawing.Point(425, 666);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(189, 83);
            this.reset.TabIndex = 11;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // labelTotalBalance
            // 
            this.labelTotalBalance.AutoSize = true;
            this.labelTotalBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalBalance.Location = new System.Drawing.Point(114, 530);
            this.labelTotalBalance.Name = "labelTotalBalance";
            this.labelTotalBalance.Size = new System.Drawing.Size(226, 37);
            this.labelTotalBalance.TabIndex = 12;
            this.labelTotalBalance.Text = "Total Balance";
            // 
            // balance
            // 
            this.balance.Location = new System.Drawing.Point(425, 527);
            this.balance.Name = "balance";
            this.balance.ReadOnly = true;
            this.balance.Size = new System.Drawing.Size(238, 44);
            this.balance.TabIndex = 13;
            this.balance.TextChanged += new System.EventHandler(this.balance_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 37);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tip";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 37);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tip";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 899);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.labelTotalBalance);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCal);
            this.Controls.Add(this.tip);
            this.Controls.Add(this.radioButtonTip2);
            this.Controls.Add(this.radioButtonTip1);
            this.Controls.Add(this.charges);
            this.Controls.Add(this.labelTipAmount);
            this.Controls.Add(this.labelCharges);
            this.Name = "Form1";
            this.Text = "Tip Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCharges;
        private System.Windows.Forms.Label labelTipAmount;
        private System.Windows.Forms.TextBox charges;
        private System.Windows.Forms.RadioButton radioButtonTip1;
        private System.Windows.Forms.RadioButton radioButtonTip2;
        private System.Windows.Forms.TextBox tip;
        private System.Windows.Forms.Button buttonCal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label labelTotalBalance;
        private System.Windows.Forms.TextBox balance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

