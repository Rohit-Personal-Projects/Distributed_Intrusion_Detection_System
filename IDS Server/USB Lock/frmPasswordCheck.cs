using System;
using System.IO;
using System.Windows.Forms;

namespace USB_Policy
{
    public partial class frmPasswordCheck : Form
    {
        
        public frmPasswordCheck()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (CommonMethods.ConfirmPwd( txtPwd.Text ))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

            else
            {
                MessageBox.Show
                   ("Wrong password, please re-enter", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPwd.Focus();
                return;
          }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPwd.Clear();
            txtPwd.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        
    }
}