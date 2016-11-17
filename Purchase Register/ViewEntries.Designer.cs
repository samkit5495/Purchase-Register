namespace Purchase_Register
{
    partial class frmViewEntries
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
            this.cmbDistributorName = new System.Windows.Forms.ComboBox();
            this.dgvEntries = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotalGrossPurchase5 = new System.Windows.Forms.Label();
            this.lblTotalVAT5 = new System.Windows.Forms.Label();
            this.lblTotalGrossPurchase125 = new System.Windows.Forms.Label();
            this.lblTotalVAT125 = new System.Windows.Forms.Label();
            this.lblTotalGrossPurchase0 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTotalPurchase = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGrossPurchase5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvVAT5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGrossPurchase125 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvVAT125 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGrossPurchase0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTotalPurchase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntries)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Distributor";
            // 
            // cmbDistributorName
            // 
            this.cmbDistributorName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbDistributorName.FormattingEnabled = true;
            this.cmbDistributorName.Location = new System.Drawing.Point(208, 97);
            this.cmbDistributorName.Name = "cmbDistributorName";
            this.cmbDistributorName.Size = new System.Drawing.Size(163, 21);
            this.cmbDistributorName.TabIndex = 2;
            this.cmbDistributorName.SelectedIndexChanged += new System.EventHandler(this.cmbDistributorName_SelectedIndexChanged);
            // 
            // dgvEntries
            // 
            this.dgvEntries.AllowUserToAddRows = false;
            this.dgvEntries.AllowUserToDeleteRows = false;
            this.dgvEntries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvID,
            this.dgvDate,
            this.dgvName,
            this.dgvGrossPurchase5,
            this.dgvVAT5,
            this.dgvGrossPurchase125,
            this.dgvVAT125,
            this.dgvGrossPurchase0,
            this.dgvTotalPurchase});
            this.dgvEntries.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvEntries.Location = new System.Drawing.Point(484, 0);
            this.dgvEntries.Name = "dgvEntries";
            this.dgvEntries.ReadOnly = true;
            this.dgvEntries.Size = new System.Drawing.Size(842, 493);
            this.dgvEntries.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total Gross Purchase 5%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total Gross Purchase 12.5%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total VAT 5%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Total VAT 12.5%";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(105, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Total Gross Purchase 0%";
            // 
            // lblTotalGrossPurchase5
            // 
            this.lblTotalGrossPurchase5.AutoSize = true;
            this.lblTotalGrossPurchase5.Location = new System.Drawing.Point(297, 146);
            this.lblTotalGrossPurchase5.Name = "lblTotalGrossPurchase5";
            this.lblTotalGrossPurchase5.Size = new System.Drawing.Size(28, 13);
            this.lblTotalGrossPurchase5.TabIndex = 9;
            this.lblTotalGrossPurchase5.Text = "0.00";
            this.lblTotalGrossPurchase5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalVAT5
            // 
            this.lblTotalVAT5.AutoSize = true;
            this.lblTotalVAT5.Location = new System.Drawing.Point(297, 177);
            this.lblTotalVAT5.Name = "lblTotalVAT5";
            this.lblTotalVAT5.Size = new System.Drawing.Size(28, 13);
            this.lblTotalVAT5.TabIndex = 10;
            this.lblTotalVAT5.Text = "0.00";
            this.lblTotalVAT5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalGrossPurchase125
            // 
            this.lblTotalGrossPurchase125.AutoSize = true;
            this.lblTotalGrossPurchase125.Location = new System.Drawing.Point(297, 205);
            this.lblTotalGrossPurchase125.Name = "lblTotalGrossPurchase125";
            this.lblTotalGrossPurchase125.Size = new System.Drawing.Size(28, 13);
            this.lblTotalGrossPurchase125.TabIndex = 11;
            this.lblTotalGrossPurchase125.Text = "0.00";
            this.lblTotalGrossPurchase125.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalVAT125
            // 
            this.lblTotalVAT125.AutoSize = true;
            this.lblTotalVAT125.Location = new System.Drawing.Point(297, 238);
            this.lblTotalVAT125.Name = "lblTotalVAT125";
            this.lblTotalVAT125.Size = new System.Drawing.Size(28, 13);
            this.lblTotalVAT125.TabIndex = 12;
            this.lblTotalVAT125.Text = "0.00";
            this.lblTotalVAT125.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalGrossPurchase0
            // 
            this.lblTotalGrossPurchase0.AutoSize = true;
            this.lblTotalGrossPurchase0.Location = new System.Drawing.Point(297, 270);
            this.lblTotalGrossPurchase0.Name = "lblTotalGrossPurchase0";
            this.lblTotalGrossPurchase0.Size = new System.Drawing.Size(28, 13);
            this.lblTotalGrossPurchase0.TabIndex = 13;
            this.lblTotalGrossPurchase0.Text = "0.00";
            this.lblTotalGrossPurchase0.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(71, 293);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(325, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "_____________________________________________________";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalPurchase
            // 
            this.lblTotalPurchase.AutoSize = true;
            this.lblTotalPurchase.Location = new System.Drawing.Point(297, 321);
            this.lblTotalPurchase.Name = "lblTotalPurchase";
            this.lblTotalPurchase.Size = new System.Drawing.Size(28, 13);
            this.lblTotalPurchase.TabIndex = 15;
            this.lblTotalPurchase.Text = "0.00";
            this.lblTotalPurchase.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(113, 321);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Total Purchase";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(105, 52);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "Range";
            // 
            // dateFrom
            // 
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFrom.Location = new System.Drawing.Point(208, 36);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(107, 20);
            this.dateFrom.TabIndex = 18;
            // 
            // dateTo
            // 
            this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTo.Location = new System.Drawing.Point(208, 62);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(107, 20);
            this.dateTo.TabIndex = 19;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(163, 40);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 13);
            this.label15.TabIndex = 20;
            this.label15.Text = "From";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(163, 65);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(20, 13);
            this.label16.TabIndex = 21;
            this.label16.Text = "To";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Location = new System.Drawing.Point(74, 357);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 100);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Note: Select a record to Update or Delete";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(171, 32);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 37);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(70, 32);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 37);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dgvID
            // 
            this.dgvID.Frozen = true;
            this.dgvID.HeaderText = "ID";
            this.dgvID.Name = "dgvID";
            this.dgvID.ReadOnly = true;
            this.dgvID.Visible = false;
            // 
            // dgvDate
            // 
            this.dgvDate.Frozen = true;
            this.dgvDate.HeaderText = "Date";
            this.dgvDate.Name = "dgvDate";
            this.dgvDate.ReadOnly = true;
            // 
            // dgvName
            // 
            this.dgvName.Frozen = true;
            this.dgvName.HeaderText = "Name";
            this.dgvName.Name = "dgvName";
            this.dgvName.ReadOnly = true;
            // 
            // dgvGrossPurchase5
            // 
            this.dgvGrossPurchase5.Frozen = true;
            this.dgvGrossPurchase5.HeaderText = "Gross Purchase 5 %";
            this.dgvGrossPurchase5.Name = "dgvGrossPurchase5";
            this.dgvGrossPurchase5.ReadOnly = true;
            // 
            // dgvVAT5
            // 
            this.dgvVAT5.Frozen = true;
            this.dgvVAT5.HeaderText = "VAT 5%";
            this.dgvVAT5.Name = "dgvVAT5";
            this.dgvVAT5.ReadOnly = true;
            // 
            // dgvGrossPurchase125
            // 
            this.dgvGrossPurchase125.Frozen = true;
            this.dgvGrossPurchase125.HeaderText = "Gross Purchase 12.5 %";
            this.dgvGrossPurchase125.Name = "dgvGrossPurchase125";
            this.dgvGrossPurchase125.ReadOnly = true;
            // 
            // dgvVAT125
            // 
            this.dgvVAT125.Frozen = true;
            this.dgvVAT125.HeaderText = "VAT 12.5 %";
            this.dgvVAT125.Name = "dgvVAT125";
            this.dgvVAT125.ReadOnly = true;
            // 
            // dgvGrossPurchase0
            // 
            this.dgvGrossPurchase0.Frozen = true;
            this.dgvGrossPurchase0.HeaderText = "Gross Purchase 0 %";
            this.dgvGrossPurchase0.Name = "dgvGrossPurchase0";
            this.dgvGrossPurchase0.ReadOnly = true;
            // 
            // dgvTotalPurchase
            // 
            this.dgvTotalPurchase.Frozen = true;
            this.dgvTotalPurchase.HeaderText = "Total Purchase";
            this.dgvTotalPurchase.Name = "dgvTotalPurchase";
            this.dgvTotalPurchase.ReadOnly = true;
            // 
            // frmViewEntries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 493);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dateTo);
            this.Controls.Add(this.dateFrom);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblTotalPurchase);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblTotalGrossPurchase0);
            this.Controls.Add(this.lblTotalVAT125);
            this.Controls.Add(this.lblTotalGrossPurchase125);
            this.Controls.Add(this.lblTotalVAT5);
            this.Controls.Add(this.lblTotalGrossPurchase5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvEntries);
            this.Controls.Add(this.cmbDistributorName);
            this.Controls.Add(this.label1);
            this.Name = "frmViewEntries";
            this.Text = "View Entries";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmViewEntries_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntries)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDistributorName;
        private System.Windows.Forms.DataGridView dgvEntries;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotalGrossPurchase5;
        private System.Windows.Forms.Label lblTotalVAT5;
        private System.Windows.Forms.Label lblTotalGrossPurchase125;
        private System.Windows.Forms.Label lblTotalVAT125;
        private System.Windows.Forms.Label lblTotalGrossPurchase0;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTotalPurchase;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvGrossPurchase5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvVAT5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvGrossPurchase125;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvVAT125;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvGrossPurchase0;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTotalPurchase;
    }
}