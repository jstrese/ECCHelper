using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Idea Bank
// 1. Add button 'check links'
//    > Button will go out to each link to verify that the link works.
//    > This will only work if a we get an HTTP response before logging
//    > in that tells us if the link is bad. Haven't tested yet.
// 2. Automatically log in to EDM Admin Tool
//    > Admin Tool has an anti-impersonation cookie and form value
//    > We would need to send a GET request to load the page and populate
//    > the values in the cookie and form field. Then extract both values
//    > and send them with a request to login.
// 3. (Requires #2) Add way to get list of package IDs with an envelope ID
//    automatically by POSTing to the EDM Admin Tool.
//

// TODO: Minimize to tray area
// TODO: Add context menu to control row items

namespace ECC_PackageLink
{
    public partial class FormAdvanced : Form
    {
        public FormAdvanced()
        {
            InitializeComponent();
        }

        //
        // Columns
        // 0 => Loan GUID
        // 1 => Package ID
        // 2 => Link
        //
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            this.updateLink(e.RowIndex, e.ColumnIndex);
        }

        //
        // Constructs URL to eSign a package.
        // 
        internal void updateLink(int rowIndex, int columnIndex = 0)
        {
            

            //
            // Update link column when modifiyng first two columns (0 & 1)
            //
            if (columnIndex < 2 && (dgvLinks[0, rowIndex].Value != null && dgvLinks[1, rowIndex].Value != null))
            {
                if (dgvLinks[columnIndex, rowIndex].Value.ToString() != String.Empty)
                    dgvLinks[2, rowIndex].Value = string.Format("https://admin.elliemae.com/encompassconsumerconnect/index.html#/login?loanId={0}&packageId={1}", Uri.EscapeDataString(dgvLinks[0, rowIndex].Value.ToString()), Uri.EscapeDataString(dgvLinks[1, rowIndex].Value.ToString()));
            }

            //
            // Clear the link if we detect no loan GUID or package GUID
            //
            if ((dgvLinks[0, rowIndex].Value == null || dgvLinks[1, rowIndex].Value == null) ||
               (dgvLinks[0, rowIndex].Value.ToString() == String.Empty || dgvLinks[1, rowIndex].Value.ToString() == String.Empty))
            {
                dgvLinks[2, rowIndex].Value = string.Empty;
            }
        }

        //
        // Clears all rows
        //
        internal void btnClear_Click(object sender, EventArgs e)
        {
            this.dgvLinks.Rows.Clear();
        }

        //
        // We are using a context menu with a button to build a dropdown button menu
        //
        private void btnActions_Click(object sender, EventArgs e)
        {
            Button btnSender = (Button)sender;
            Point ptLowerLeft = new Point(0, btnSender.Height);
            ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
            this.ctxActions.Show(ptLowerLeft);
        }

        //
        // Display the Quick Response form
        //
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            using (frmQuickResponse _handle = new frmQuickResponse(this.GenerateLinkList(), (this.dgvLinks.Rows.Count - 1) > 1 ? true : false))
            {
                _handle.ShowDialog();
            }
        }

        //
        // Builds the quick response to pass to the Quick Response form
        //
        private string GenerateLinkList()
        {
            string output = string.Empty;

            foreach (DataGridViewRow row in this.dgvLinks.Rows)
            {
                if (row.Index < (this.dgvLinks.Rows.Count - 1) && (row.Cells[2].Value != null && row.Cells[2].Value.ToString() != string.Empty))
                    output += string.Format("Loan GUID: {0}\r\nLink: {1}\r\n\r\n", row.Cells[0].Value.ToString(), row.Cells[2].Value.ToString());
            }

            return output;
        }

        //
        // Display the Import form
        //
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (frmImport _handle = new frmImport() { Owner = this })
            {
                _handle.ShowDialog();
            }
        }

        //
        // Ensure that formatting is checked when new rows are added via import
        //
        private void dgvLinks_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            this.checkFormatting(0, e.RowIndex);
            this.checkFormatting(1, e.RowIndex);
        }

        //
        // Display the Export form
        //
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            using (frmExport _handle = new frmExport() { Owner = this })
            {
                _handle.ShowDialog();
            }
        }

        //
        // Returns the Loan GUID for the specified rowIndex
        //
        internal string getLoanGUID(int rowIndex)
        {
            if (rowIndex <= this.dgvLinks.Rows.Count - 1 && this.dgvLinks[0, rowIndex].Value != null)
                return this.dgvLinks[0, rowIndex].Value.ToString();
            else
                return string.Empty;
        }

        //
        // Returns the link for the specified rowIndex
        //
        internal string getLink(int rowIndex)
        {
            if (rowIndex <= this.dgvLinks.Rows.Count - 1 && this.dgvLinks[2, rowIndex].Value != null)
                return this.dgvLinks[2, rowIndex].Value.ToString();
            else
                return string.Empty;
        }

        //
        // Place error text in the cell if the format doesn't match a GUID or package ID format
        //
        internal void dgvLinks_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            this.checkFormatting(e.ColumnIndex, e.RowIndex);
        }

        //
        // This function trims and takes out unnecessary characters in the loan GUID and
        // package ID. We also display an error if the end result for the IDs are not
        // formatted well.
        //
        internal void checkFormatting(int ColumnIndex, int RowIndex)
        {
            // Loan GUID: 0a8aef23-d3ca-4fc0-ab8f-430b3457e517
            // Package:   7f8e9482-8615-445d-acd7-d1c18764687d

            // This logic should only apply to the first two columns (0 & 1)
            if (this.dgvLinks.Rows.Count >= 1 && RowIndex >= 0)
            {
                if (ColumnIndex < 2)
                {
                    if (dgvLinks[ColumnIndex, RowIndex].Value != null)
                        dgvLinks[ColumnIndex, RowIndex].Value = dgvLinks[ColumnIndex, RowIndex].Value.ToString().Trim().Replace("{", "").Replace("}", "");

                    if (this.dgvLinks[ColumnIndex, RowIndex].Value == null || this.dgvLinks[ColumnIndex, RowIndex].Value.ToString() == string.Empty)
                        this.dgvLinks[ColumnIndex, RowIndex].ErrorText = string.Empty;
                    else
                    {
                        System.Text.RegularExpressions.Regex _reg = new System.Text.RegularExpressions.Regex("^([a-zA-Z0-9]{8,9})-([a-zA-Z0-9]{4,5})-([a-zA-Z0-9]{4,5})-([a-zA-Z0-9]{4,5})-([a-zA-Z0-9]{10,13})$");

                        if (_reg.Match(this.dgvLinks[ColumnIndex, RowIndex].Value.ToString()).Success)
                            this.dgvLinks[ColumnIndex, RowIndex].ErrorText = string.Empty;
                        else
                            this.dgvLinks[ColumnIndex, RowIndex].ErrorText = "Warning: Specified GUID does not match GUID formatting.\r\nExample: 0a8aef23-d3ca-4fc0-ab8f-430b3457e517";
                    }
                }
            }
        }
    }
}
