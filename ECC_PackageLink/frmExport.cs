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
    public partial class frmExport : Form
    {
        public frmExport()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            this.ofdExport.ShowDialog();

            if (this.ofdExport.FileName != "")
                this.txtExportLocation.Text = this.ofdExport.FileName;
        }

        //
        // Export list of links to the selected file
        //
        private void btnExport_Click(object sender, EventArgs e)
        {
            if (this.txtExportLocation.Text != string.Empty)
            {
                //
                // Check to see if this file exists first to see if we want to overwrite it
                //
                if (System.IO.File.Exists(this.ofdExport.FileName))
                {
                    DialogResult _DR = MessageBox.Show("This file already exists, do you want to overwrite it?", "File Exists", MessageBoxButtons.YesNo);

                    if (_DR != DialogResult.Yes)
                    {
                        return;
                    }
                }

                //
                // Build the string buffer for the content that we need to write to the file
                //
                string buffer;
                FormAdvanced _Owner = (FormAdvanced)Owner;

                // Write header values to the buffer
                buffer = "Loan GUID,eSign Link";

                for (int i = 0; i < _Owner.dgvLinks.Rows.Count; ++i)
                {
                    // Skip row if there's no link generated
                    if (_Owner.getLink(i) == string.Empty)
                    {
                        continue;
                    }

                    buffer = String.Format("{0}\r\n{1},{2}", buffer, _Owner.getLoanGUID(i), _Owner.getLink(i));
                }

                //
                // Open a stream writer to the export path. This will create the file if it doesn't exist.
                //
                try
                {
                    using (System.IO.StreamWriter _writer = new System.IO.StreamWriter(this.ofdExport.FileName))
                    {
                        _writer.WriteLine(buffer);
                        _writer.Close();
                    }

                    MessageBox.Show("Exported successfully.");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(String.Format("Unable to save export file due to an error.\r\n\r\n{0}", ex.Message));
                }
            }
            else
                MessageBox.Show("No file export path has been selected.");
        }
    }
}
