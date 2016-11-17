namespace Purchase_Register
{
    partial class frmPurchaseRegister
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGrossPurchase5 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGrossPurchase125 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGrossPurchase0 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalPurchase = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblvat125 = new System.Windows.Forms.Label();
            this.lblvat5 = new System.Windows.Forms.Label();
            this.cmbDistributorName = new System.Windows.Forms.ComboBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.txtVat5 = new System.Windows.Forms.TextBox();
            this.txtVat125 = new System.Windows.Forms.TextBox();
            this.rdCal5 = new System.Windows.Forms.RadioButton();
            this.rdCal125 = new System.Windows.Forms.RadioButton();
            this.lblTIN = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Distributor Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "TIN No.";
            // 
            // txtGrossPurchase5
            // 
            this.txtGrossPurchase5.Location = new System.Drawing.Point(116, 194);
            this.txtGrossPurchase5.Name = "txtGrossPurchase5";
            this.txtGrossPurchase5.Size = new System.Drawing.Size(111, 20);
            this.txtGrossPurchase5.TabIndex = 3;
            this.txtGrossPurchase5.Text = "0.00";
            this.txtGrossPurchase5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Gross Purchase 5%";
            // 
            // txtGrossPurchase125
            // 
            this.txtGrossPurchase125.Location = new System.Drawing.Point(116, 261);
            this.txtGrossPurchase125.Name = "txtGrossPurchase125";
            this.txtGrossPurchase125.Size = new System.Drawing.Size(111, 20);
            this.txtGrossPurchase125.TabIndex = 5;
            this.txtGrossPurchase125.Text = "0.00";
            this.txtGrossPurchase125.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Gross Purchase 12.5%";
            // 
            // txtGrossPurchase0
            // 
            this.txtGrossPurchase0.Location = new System.Drawing.Point(421, 231);
            this.txtGrossPurchase0.Name = "txtGrossPurchase0";
            this.txtGrossPurchase0.Size = new System.Drawing.Size(123, 20);
            this.txtGrossPurchase0.TabIndex = 7;
            this.txtGrossPurchase0.Text = "0.00";
            this.txtGrossPurchase0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(434, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Gross Purchase 0%";
            // 
            // txtTotalPurchase
            // 
            this.txtTotalPurchase.Location = new System.Drawing.Point(249, 308);
            this.txtTotalPurchase.Name = "txtTotalPurchase";
            this.txtTotalPurchase.Size = new System.Drawing.Size(110, 20);
            this.txtTotalPurchase.TabIndex = 8;
            this.txtTotalPurchase.Text = "0.00";
            this.txtTotalPurchase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(133, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Total Purchase";
            // 
            // lblvat125
            // 
            this.lblvat125.AutoSize = true;
            this.lblvat125.Location = new System.Drawing.Point(290, 231);
            this.lblvat125.Name = "lblvat125";
            this.lblvat125.Size = new System.Drawing.Size(60, 13);
            this.lblvat125.TabIndex = 18;
            this.lblvat125.Text = "VAT 12.5%";
            // 
            // lblvat5
            // 
            this.lblvat5.AutoSize = true;
            this.lblvat5.Location = new System.Drawing.Point(282, 164);
            this.lblvat5.Name = "lblvat5";
            this.lblvat5.Size = new System.Drawing.Size(45, 13);
            this.lblvat5.TabIndex = 16;
            this.lblvat5.Text = "VAT 5%";
            // 
            // cmbDistributorName
            // 
            this.cmbDistributorName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbDistributorName.FormattingEnabled = true;
            this.cmbDistributorName.Location = new System.Drawing.Point(232, 85);
            this.cmbDistributorName.Name = "cmbDistributorName";
            this.cmbDistributorName.Size = new System.Drawing.Size(163, 21);
            this.cmbDistributorName.TabIndex = 1;
            this.cmbDistributorName.SelectedIndexChanged += new System.EventHandler(this.cmbDistributorName_SelectedIndexChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(285, 366);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 40);
            this.btnCalculate.TabIndex = 11;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(220, 432);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 38);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(345, 432);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 38);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(113, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Date";
            // 
            // date
            // 
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date.Location = new System.Drawing.Point(232, 42);
            this.date.Name = "date";
            this.date.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.date.Size = new System.Drawing.Size(163, 20);
            this.date.TabIndex = 0;
            // 
            // txtVat5
            // 
            this.txtVat5.Location = new System.Drawing.Point(249, 194);
            this.txtVat5.Name = "txtVat5";
            this.txtVat5.Size = new System.Drawing.Size(111, 20);
            this.txtVat5.TabIndex = 4;
            this.txtVat5.Text = "0.00";
            this.txtVat5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtVat125
            // 
            this.txtVat125.Location = new System.Drawing.Point(249, 261);
            this.txtVat125.Name = "txtVat125";
            this.txtVat125.Size = new System.Drawing.Size(111, 20);
            this.txtVat125.TabIndex = 6;
            this.txtVat125.Text = "0.00";
            this.txtVat125.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // rdCal5
            // 
            this.rdCal5.AutoSize = true;
            this.rdCal5.Checked = true;
            this.rdCal5.Location = new System.Drawing.Point(398, 301);
            this.rdCal5.Name = "rdCal5";
            this.rdCal5.Size = new System.Drawing.Size(86, 17);
            this.rdCal5.TabIndex = 9;
            this.rdCal5.TabStop = true;
            this.rdCal5.Text = "Calculate 5%";
            this.rdCal5.UseVisualStyleBackColor = true;
            // 
            // rdCal125
            // 
            this.rdCal125.AutoSize = true;
            this.rdCal125.Location = new System.Drawing.Point(398, 324);
            this.rdCal125.Name = "rdCal125";
            this.rdCal125.Size = new System.Drawing.Size(101, 17);
            this.rdCal125.TabIndex = 10;
            this.rdCal125.TabStop = true;
            this.rdCal125.Text = "Calculate 12.5%";
            this.rdCal125.UseVisualStyleBackColor = true;
            // 
            // lblTIN
            // 
            this.lblTIN.AutoSize = true;
            this.lblTIN.Location = new System.Drawing.Point(229, 125);
            this.lblTIN.Name = "lblTIN";
            this.lblTIN.Size = new System.Drawing.Size(80, 13);
            this.lblTIN.TabIndex = 21;
            this.lblTIN.Text = "00000000000V";
            // 
            // frmPurchaseRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 511);
            this.Controls.Add(this.lblTIN);
            this.Controls.Add(this.rdCal125);
            this.Controls.Add(this.rdCal5);
            this.Controls.Add(this.txtVat125);
            this.Controls.Add(this.txtVat5);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.cmbDistributorName);
            this.Controls.Add(this.lblvat125);
            this.Controls.Add(this.lblvat5);
            this.Controls.Add(this.txtTotalPurchase);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtGrossPurchase0);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtGrossPurchase125);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGrossPurchase5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmPurchaseRegister";
            this.Text = "Purchase Register";
            this.Load += new System.EventHandler(this.PurchaseRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGrossPurchase5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGrossPurchase125;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGrossPurchase0;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalPurchase;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblvat125;
        private System.Windows.Forms.Label lblvat5;
        private System.Windows.Forms.ComboBox cmbDistributorName;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.TextBox txtVat5;
        private System.Windows.Forms.TextBox txtVat125;
        private System.Windows.Forms.RadioButton rdCal5;
        private System.Windows.Forms.RadioButton rdCal125;
        private System.Windows.Forms.Label lblTIN;
    }
}

