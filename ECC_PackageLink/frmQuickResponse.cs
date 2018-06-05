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
    public partial class frmQuickResponse : Form
    {
        public frmQuickResponse()
        {
            InitializeComponent();
        }

        //
        // TODO: Make these configurable
        //
        public frmQuickResponse(string links, bool multiple)
        {
            InitializeComponent();
            PopulateResponse(links, multiple);
        }

        //
        // Builds the response using the list of links provided from the parent form
        //
        private void PopulateResponse(string links, bool multiple)
        {
            if (links.Length > 0)
            {
                // Greeting
                if (multiple == false)
                    this.txtResponse.Text = "Please see below for the link that you requested.\r\n\r\n";
                else
                    this.txtResponse.Text = "Please see below for the list of links that you requested.\r\n\r\n";

                // Body
                this.txtResponse.AppendText(links);

                // Salutation
                this.txtResponse.AppendText("If you have additional questions, please feel free to ask. If you no longer need assistance feel free to update the status of this case to Closed.\r\n\r\nThank you,\r\n\r\n");
            }
            else
                this.txtResponse.Text = "There were no links to include in a response.\r\n\r\nPlease go back and ensure that you have at least\r\none valid GUID and Package ID to form a link.";
        }

        //
        // Copies the quick response text to the user's clipboard
        //
        private void btnCopy_Click(object sender, EventArgs e)
        {
            if(this.txtResponse.Text.ToString().Length > 0)
                Clipboard.SetText(this.txtResponse.Text);
        }

        //
        // Closes form (mapped to ESC key)
        //
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
