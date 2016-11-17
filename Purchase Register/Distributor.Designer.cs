namespace Purchase_Register
{
    partial class frmDistributor
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
            this.txtTIN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDistributor = new System.Windows.Forms.DataGridView();
            this.dgvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDistibutorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTINNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDistributorName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDistributor)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTIN
            // 
            this.txtTIN.Location = new System.Drawing.Point(199, 89);
            this.txtTIN.Name = "txtTIN";
            this.txtTIN.Size = new System.Drawing.Size(163, 20);
            this.txtTIN.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "TIN No.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Distributor Name";
            // 
            // dgvDistributor
            // 
            this.dgvDistributor.AllowUserToAddRows = false;
            this.dgvDistributor.AllowUserToDeleteRows = false;
            this.dgvDistributor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDistributor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvID,
            this.dgvDistibutorName,
            this.dgvTINNo});
            this.dgvDistributor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDistributor.Location = new System.Drawing.Point(0, 180);
            this.dgvDistributor.Name = "dgvDistributor";
            this.dgvDistributor.ReadOnly = true;
            this.dgvDistributor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDistributor.Size = new System.Drawing.Size(504, 222);
            this.dgvDistributor.TabIndex = 19;
            this.dgvDistributor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDistributor_CellContentClick);
            // 
            // dgvID
            // 
            this.dgvID.HeaderText = "ID";
            this.dgvID.Name = "dgvID";
            this.dgvID.ReadOnly = true;
            this.dgvID.Width = 30;
            // 
            // dgvDistibutorName
            // 
            this.dgvDistibutorName.HeaderText = "Distributor Name";
            this.dgvDistibutorName.Name = "dgvDistibutorName";
            this.dgvDistibutorName.ReadOnly = true;
            this.dgvDistibutorName.Width = 290;
            // 
            // dgvTINNo
            // 
            this.dgvTINNo.HeaderText = "TIN No";
            this.dgvTINNo.Name = "dgvTINNo";
            this.dgvTINNo.ReadOnly = true;
            this.dgvTINNo.Width = 140;
            // 
            // txtDistributorName
            // 
            this.txtDistributorName.Location = new System.Drawing.Point(199, 52);
            this.txtDistributorName.Name = "txtDistributorName";
            this.txtDistributorName.Size = new System.Drawing.Size(163, 20);
            this.txtDistributorName.TabIndex = 20;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(83, 126);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 38);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(199, 126);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 38);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(317, 126);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 38);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Distributor ID";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(196, 24);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(13, 13);
            this.lblID.TabIndex = 25;
            this.lblID.Text = "0";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmDistributor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 402);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtDistributorName);
            this.Controls.Add(this.dgvDistributor);
            this.Controls.Add(this.txtTIN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDistributor";
            this.Text = "Distributor";
            this.Load += new System.EventHandler(this.frmDistributor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDistributor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTIN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDistributor;
        private System.Windows.Forms.TextBox txtDistributorName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDistibutorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTINNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblID;
    }
}