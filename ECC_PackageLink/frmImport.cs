using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECC_PackageLink
{
    public partial class frmImport : Form
    {
        public frmImport()
        {
            InitializeComponent();

            //
            // Adding a tooltip over the chkIgnore box explaining the behavior
            //
            this.toolTip1.SetToolTip(this.chkIgnore, "If your CSV file contains a header row you should check this box to ignore it during the import process.");
        }

        //
        // Note: It is possible to get around the extension limitation by
        //       providing *.* as the filename
        private void btnChoose_Click(object sender, EventArgs e)
        {
            this.ofdImport.ShowDialog();

            if(this.ofdImport.FileName != string.Empty)
                this.txtPath.Text = this.ofdImport.FileName;
        }

        private void btnImportFile_Click(object sender, EventArgs e)
        {
            /******
             * How a CSV file works
             * > Rows are split by new lines
             * > Column data is then split by a comma
             * 
             * Thus we need to read each line, split by a comma, then add the row
             */

            FormAdvanced _Owner = (FormAdvanced)Owner;
            DialogResult _DR = MessageBox.Show("Do you want to overwrite existing GUIDs with these?\r\nClicking 'No' will import and not clear any existing GUIDs.", "Overwrite?", MessageBoxButtons.YesNo);

            if (_DR == DialogResult.Yes)
            {
                _Owner.btnClear_Click(null, null);
            }

            try
            {
                using (System.IO.StreamReader reader = new System.IO.StreamReader(this.ofdImport.OpenFile()))
                {
                    string s = string.Empty;
                    int i = 0;

                    while (true)
                    {
                        s = reader.ReadLine();

                        //
                        // The last line will be null
                        //
                        if (s != null)
                        {
                            //
                            // This logic skips the first line if the chkIgnore box is checked
                            //
                            if (this.chkIgnore.Checked && i == 0)
                            {
                                ++i;
                                continue;
                            }

                            string[] GUID = s.Split(',');

                            if (GUID.Count() > 1)
                                if (GUID[0].Length >= 1 || GUID[1].Length >= 1)
                                    _Owner.updateLink(_Owner.dgvLinks.Rows.Add(new Object[] { GUID[0], GUID[1] }));
                                else
                                if (GUID[0].Length >= 1)
                                    _Owner.updateLink(_Owner.dgvLinks.Rows.Add(GUID[0]));
                        }
                        else
                            break;
                    }

                    MessageBox.Show("Import completed successfully.");
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(String.Format("An error was encountered while trying to import this file.\r\n{0}", ex.Message));
            }
        }

        private void btnTxtImport_Click(object sender, EventArgs e)
        {
            FormAdvanced _Owner = (FormAdvanced)Owner;
            DialogResult _DR = MessageBox.Show("Do you want to overwrite existing GUIDs with these?\r\nClicking 'No' will import and not clear any existing GUIDs.", "Overwrite?", MessageBoxButtons.YesNo);

            if (_DR == DialogResult.Yes)
            {
                _Owner.btnClear_Click(null, null);
            }

            if (this.txtImport.Text != string.Empty)
            {
                if (this.rdbCSV.Checked)
                {
                    //
                    // Importing via CSV value
                    //
                    foreach (String GUID in this.txtImport.Text.Split(','))
                    {
                        if (GUID != String.Empty)
                            _Owner.dgvLinks.Rows.Add(GUID);
                    }

                    MessageBox.Show("Import completed successfully.");
                    this.Close();
                }
                else
                {
                    //
                    // Importing using line breaks
                    //
                    using (System.IO.StringReader Reader = new System.IO.StringReader(this.txtImport.Text))
                    {
                        while (true)
                        {
                            string s = Reader.ReadLine();

                            //
                            // The final line will be null
                            //
                            if (s != null)
                            {
                                _Owner.dgvLinks.Rows.Add(s);
                            }
                            else
                                break;
                        }
                    }

                    MessageBox.Show("Import completed successfully.");
                    this.Close();
                }
            }
            else
                MessageBox.Show("You are required to enter text to import using this method.");
        }
    }
}
