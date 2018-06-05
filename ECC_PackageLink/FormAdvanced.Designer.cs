namespace ECC_PackageLink
{
    partial class FormAdvanced
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
            this.components = new System.ComponentModel.Container();
            this.dgvLinks = new System.Windows.Forms.DataGridView();
            this.LoanGUID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PackageID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Link = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnActions = new System.Windows.Forms.Button();
            this.ctxActions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinks)).BeginInit();
            this.ctxActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLinks
            // 
            this.dgvLinks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLinks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLinks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LoanGUID,
            this.PackageID,
            this.Link});
            this.dgvLinks.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvLinks.Location = new System.Drawing.Point(0, 40);
            this.dgvLinks.Name = "dgvLinks";
            this.dgvLinks.Size = new System.Drawing.Size(992, 181);
            this.dgvLinks.TabIndex = 0;
            this.dgvLinks.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dgvLinks.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLinks_CellValueChanged);
            this.dgvLinks.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvLinks_RowsAdded);
            // 
            // LoanGUID
            // 
            this.LoanGUID.HeaderText = "Loan GUID";
            this.LoanGUID.Name = "LoanGUID";
            this.LoanGUID.Width = 220;
            // 
            // PackageID
            // 
            this.PackageID.HeaderText = "PackageID";
            this.PackageID.Name = "PackageID";
            this.PackageID.Width = 220;
            // 
            // Link
            // 
            this.Link.HeaderText = "Link";
            this.Link.Name = "Link";
            this.Link.Width = 500;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(905, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnActions
            // 
            this.btnActions.ContextMenuStrip = this.ctxActions;
            this.btnActions.Location = new System.Drawing.Point(12, 12);
            this.btnActions.Name = "btnActions";
            this.btnActions.Size = new System.Drawing.Size(75, 23);
            this.btnActions.TabIndex = 2;
            this.btnActions.Text = "Actions";
            this.btnActions.UseVisualStyleBackColor = true;
            this.btnActions.Click += new System.EventHandler(this.btnActions_Click);
            // 
            // ctxActions
            // 
            this.ctxActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.ctxActions.Name = "ctxActions";
            this.ctxActions.Size = new System.Drawing.Size(159, 70);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.toolStripMenuItem1.Text = "&Import";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(158, 22);
            this.toolStripMenuItem2.Text = "&Export as CSV";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(158, 22);
            this.toolStripMenuItem3.Text = "&Quick Response";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // FormAdvanced
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 221);
            this.Controls.Add(this.btnActions);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dgvLinks);
            this.MinimumSize = new System.Drawing.Size(700, 260);
            this.Name = "FormAdvanced";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generate eSign Links";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinks)).EndInit();
            this.ctxActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn LoanGUID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackageID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Link;
        private System.Windows.Forms.Button btnActions;
        private System.Windows.Forms.ContextMenuStrip ctxActions;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        internal System.Windows.Forms.Button btnClear;
        public System.Windows.Forms.DataGridView dgvLinks;
    }
}