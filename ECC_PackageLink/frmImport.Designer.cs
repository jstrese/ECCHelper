namespace ECC_PackageLink
{
    partial class frmImport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImport));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rdbLineBreak = new System.Windows.Forms.RadioButton();
            this.rdbCSV = new System.Windows.Forms.RadioButton();
            this.btnTxtImport = new System.Windows.Forms.Button();
            this.txtImport = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chkIgnore = new System.Windows.Forms.CheckBox();
            this.btnImportFile = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnChoose = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ofdImport = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(437, 312);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rdbLineBreak);
            this.tabPage1.Controls.Add(this.rdbCSV);
            this.tabPage1.Controls.Add(this.btnTxtImport);
            this.tabPage1.Controls.Add(this.txtImport);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(429, 286);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "From Text";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rdbLineBreak
            // 
            this.rdbLineBreak.AutoSize = true;
            this.rdbLineBreak.Location = new System.Drawing.Point(269, 263);
            this.rdbLineBreak.Name = "rdbLineBreak";
            this.rdbLineBreak.Size = new System.Drawing.Size(76, 17);
            this.rdbLineBreak.TabIndex = 4;
            this.rdbLineBreak.Text = "Line Break";
            this.rdbLineBreak.UseVisualStyleBackColor = true;
            // 
            // rdbCSV
            // 
            this.rdbCSV.AutoSize = true;
            this.rdbCSV.Checked = true;
            this.rdbCSV.Location = new System.Drawing.Point(217, 263);
            this.rdbCSV.Name = "rdbCSV";
            this.rdbCSV.Size = new System.Drawing.Size(46, 17);
            this.rdbCSV.TabIndex = 4;
            this.rdbCSV.TabStop = true;
            this.rdbCSV.Text = "CSV";
            this.rdbCSV.UseVisualStyleBackColor = true;
            // 
            // btnTxtImport
            // 
            this.btnTxtImport.Location = new System.Drawing.Point(351, 260);
            this.btnTxtImport.Name = "btnTxtImport";
            this.btnTxtImport.Size = new System.Drawing.Size(75, 23);
            this.btnTxtImport.TabIndex = 3;
            this.btnTxtImport.Text = "Import";
            this.btnTxtImport.UseVisualStyleBackColor = true;
            this.btnTxtImport.Click += new System.EventHandler(this.btnTxtImport_Click);
            // 
            // txtImport
            // 
            this.txtImport.AcceptsReturn = true;
            this.txtImport.Location = new System.Drawing.Point(3, 112);
            this.txtImport.Multiline = true;
            this.txtImport.Name = "txtImport";
            this.txtImport.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtImport.Size = new System.Drawing.Size(423, 141);
            this.txtImport.TabIndex = 2;
            this.txtImport.WordWrap = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(380, 78);
            this.label3.TabIndex = 1;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Importing From Text";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.chkIgnore);
            this.tabPage2.Controls.Add(this.btnImportFile);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btnChoose);
            this.tabPage2.Controls.Add(this.txtPath);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(429, 286);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "From File";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chkIgnore
            // 
            this.chkIgnore.AutoSize = true;
            this.chkIgnore.Location = new System.Drawing.Point(11, 123);
            this.chkIgnore.Name = "chkIgnore";
            this.chkIgnore.Size = new System.Drawing.Size(103, 17);
            this.chkIgnore.TabIndex = 6;
            this.chkIgnore.Text = "Ignore First Row";
            this.chkIgnore.UseVisualStyleBackColor = true;
            // 
            // btnImportFile
            // 
            this.btnImportFile.Location = new System.Drawing.Point(171, 122);
            this.btnImportFile.Name = "btnImportFile";
            this.btnImportFile.Size = new System.Drawing.Size(75, 23);
            this.btnImportFile.TabIndex = 5;
            this.btnImportFile.Text = "Import";
            this.btnImportFile.UseVisualStyleBackColor = true;
            this.btnImportFile.Click += new System.EventHandler(this.btnImportFile_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(313, 39);
            this.label5.TabIndex = 4;
            this.label5.Text = "To import from a file simply select a file below and click on Import.\r\n\r\nNote: Th" +
    "e file must be in a CSV format for this operation to work.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Importing From File";
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(384, 96);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(37, 20);
            this.btnChoose.TabIndex = 2;
            this.btnChoose.Text = "...";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(11, 96);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(367, 20);
            this.txtPath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select File";
            // 
            // ofdImport
            // 
            this.ofdImport.DefaultExt = "csv";
            this.ofdImport.Filter = "CSV Files|*.csv";
            this.ofdImport.Title = "Select file to import";
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipTitle = "Ignoring The First Row";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ECC_PackageLink.Properties.Resources.Sample;
            this.pictureBox1.Location = new System.Drawing.Point(6, 179);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(415, 99);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(184, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Sample";
            // 
            // frmImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 312);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmImport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Import";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbLineBreak;
        private System.Windows.Forms.RadioButton rdbCSV;
        private System.Windows.Forms.Button btnTxtImport;
        private System.Windows.Forms.TextBox txtImport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnImportFile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog ofdImport;
        private System.Windows.Forms.CheckBox chkIgnore;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
    }
}