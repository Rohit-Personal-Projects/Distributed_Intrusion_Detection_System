using System;
using System.IO;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace USB_Policy
{
    public partial class frmPassword : Form
    {
        public frmPassword()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if( txtNewPwd.Text != txtNewPwdAgain.Text )
            {
                MessageBox.Show
                    ("Passwords do not match, please retry","Error", 
                        MessageBoxButtons.OK,MessageBoxIcon.Error);
                    
               txtNewPwdAgain.Clear();
               txtNewPwd.Clear();
               txtNewPwd.Focus();
                    
               return;
            }
            
            if( Program.isPwdEnabled )
                if (CommonMethods.ConfirmPwd( txtOldPwd.Text) == false)
                {
                    MessageBox.Show
                    ("Wrong password, please retry", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtOldPwd.Focus();
                    return;
                }
            if (String.IsNullOrEmpty(txtNewPwd.Text))
            {
                DisablePwd();
                MessageBox.Show
                    ("Password disabled", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                this.Close();
                return;
            }
            
            string newPwdEncrypted = 
                CommonMethods.MD5Hash( txtNewPwd.Text );

            StorePassword(newPwdEncrypted);

            Program.isPwdEnabled = true;

            MessageBox.Show
                    ("Password changed successfully ", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
               
        }

        private void DisablePwd()
        {
            Program.isPwdEnabled = false;
            try { File.Delete(Program.strPwdFilePath); }
            catch { }

        }

        private void StorePassword(string newPwdEncrypted)
        {
            try
            {
                File.Delete(Program.strPwdFilePath);

                StreamWriter fsPwdFile =
                        new StreamWriter(
                            new FileStream
                                (Program.strPwdFilePath,
                                FileMode.Create,
                                FileAccess.Write));

                fsPwdFile.Write(newPwdEncrypted);
                fsPwdFile.Close();
            }
            catch { }
        }
        
        private void frmPassword_Load(object sender, EventArgs e)
        {
            if (Program.isPwdEnabled == false)
                txtOldPwd.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNewPwd.Clear();
            txtOldPwd.Clear();
            txtOldPwd.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}