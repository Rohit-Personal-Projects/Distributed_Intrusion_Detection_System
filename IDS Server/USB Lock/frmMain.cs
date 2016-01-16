using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;

namespace USB_Policy
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        
        private void frmMain_Load(object sender, EventArgs e)
        {
            CheckPasswordStatus(); 
            USB_getStatus();
            REG_getStatus();
        }
        private void CheckPasswordStatus()
        {
            Program.strPwdFilePath += "\\usbpolicy.pwd";
            if (File.Exists(Program.strPwdFilePath))
            {
                try
                {
                    StreamReader fsPwdFile =
                       new StreamReader(
                           new FileStream(Program.strPwdFilePath, FileMode.Open, FileAccess.Read));
                    string pwd = fsPwdFile.ReadToEnd();
                    if (String.IsNullOrEmpty(pwd) == false)
                        Program.isPwdEnabled = true;
                    fsPwdFile.Close();
                }
                catch { }
            }
            else
                Program.isPwdEnabled = false;
        }
        private void REG_getStatus()
        {
            RegistryKey key;
            try
            {

                key = Registry.CurrentUser.OpenSubKey
                    ("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
                if (System.Convert.ToInt16(key.GetValue("DisableRegistryTools", null)) == 1)
                    REG_cbox_DisableRegistry.Checked = true;
                else
                    REG_cbox_DisableRegistry.Checked = false;

                key.Close();
            }
            catch (NullReferenceException)
            {
                key = Registry.CurrentUser.OpenSubKey
                    ("Software\\Microsoft\\Windows\\CurrentVersion\\Policies", true);
                key.CreateSubKey("System");
            };
        }
        private void USB_getStatus()
        {

            RegistryKey key;
            try
            {
                key = Registry.LocalMachine.OpenSubKey
                        ("SYSTEM\\CurrentControlSet\\Control\\StorageDevicePolicies");

                if (System.Convert.ToInt16(key.GetValue("WriteProtect", null)) == 1)
                    USB_radio_ReadOnly.Checked = true;
                else
                    USB_radio_FullAccess.Checked = true;
            }
            catch (NullReferenceException )
            {
                key = Registry.LocalMachine.OpenSubKey
                        ("SYSTEM\\CurrentControlSet\\Control", true);
                key.CreateSubKey("StorageDevicePolicies");
                key.Close();
            }
            catch (Exception) { }
            try
            {
                key = Registry.LocalMachine.OpenSubKey
                ("SYSTEM\\CurrentControlSet\\Services\\UsbStor");

                if (System.Convert.ToInt16(key.GetValue("Start", null)) == 4)
                {
                    USB_radio_Disabled.Checked = true;
                    return;
                }
            }
            catch (NullReferenceException )
            {
                key = Registry.LocalMachine.OpenSubKey
                ("SYSTEM\\CurrentControlSet\\Services", true);
                key.CreateSubKey("USBSTOR");

                key = Registry.LocalMachine.OpenSubKey
                ("SYSTEM\\CurrentControlSet\\Services\\UsbStor", true);

                key.SetValue("Type", 1, RegistryValueKind.DWord);
                key.SetValue("Start", 3, RegistryValueKind.DWord);
                key.SetValue
                    ("ImagePath", "system32\\drivers\\usbstor.sys", RegistryValueKind.ExpandString);
                key.SetValue("ErrorControl", 1, RegistryValueKind.DWord);
                key.SetValue
                    ("DisplayName", "USB Mass Storage Driver", RegistryValueKind.String);

                key.Close();
            }
            
           catch( Exception ) {}

        }
        
        private void REG_EnableRegedit()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey
                ("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", true);
            key.SetValue("DisableRegistryTools",0, RegistryValueKind.DWord);
            key.Close();
        }
        private void REG_DisableRegedit()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey
                ("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", true);
            key.SetValue("DisableRegistryTools", 1, RegistryValueKind.DWord);
            key.Close();
        }
        void USB_disableAllStorageDevices()
        {
            RegistryKey key = Registry.LocalMachine.OpenSubKey
                ("SYSTEM\\CurrentControlSet\\Services\\UsbStor",true);
            if (key != null)
            {
                key.SetValue("Start", 4, RegistryValueKind.DWord);
            }
            key.Close();
        }
        void USB_enableAllStorageDevices()
        {
            RegistryKey key = Registry.LocalMachine.OpenSubKey
                ("SYSTEM\\CurrentControlSet\\Services\\UsbStor", true);
            if (key != null)
            {
                key.SetValue("Start", 3, RegistryValueKind.DWord);
            }
            key.Close();
        }
        void USB_enableWriteProtect()
        {
            RegistryKey key = Registry.LocalMachine.OpenSubKey
              ("SYSTEM\\CurrentControlSet\\Control\\StorageDevicePolicies", true);
            if (key == null)
            {
                Registry.LocalMachine.CreateSubKey
                    ("SYSTEM\\CurrentControlSet\\Control\\StorageDevicePolicies", RegistryKeyPermissionCheck.ReadWriteSubTree);
                key = Registry.LocalMachine.OpenSubKey
                ("SYSTEM\\CurrentControlSet\\Control\\StorageDevicePolicies", true);
                key.SetValue("WriteProtect", 1, RegistryValueKind.DWord);
            }
            else if (key.GetValue("WriteProtect") != (object)(1))
            {
                key.SetValue("WriteProtect", 1, RegistryValueKind.DWord);
            }
        }
        void USB_disableWriteProtect()
        {
            RegistryKey key = Registry.LocalMachine.OpenSubKey
               ("SYSTEM\\CurrentControlSet\\Control\\StorageDevicePolicies", true);
            if (key != null)
            {
                key.SetValue("WriteProtect", 0, RegistryValueKind.DWord);
            }
            key.Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            DialogResult resultApplyChanges = MessageBox.Show
                ("Apply changes?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (resultApplyChanges == DialogResult.Yes)
            {
                if (Program.isPwdEnabled)
                {
                    frmPasswordCheck frmPwdCheck = new frmPasswordCheck();
                    frmPwdCheck.ShowDialog();

                    if (frmPwdCheck.DialogResult != DialogResult.OK)
                        return;
                }
                if (USB_radio_Disabled.Checked == true)
                {
                    USB_disableAllStorageDevices();
                }
                else if (USB_radio_ReadOnly.Checked == true)
                {
                    USB_enableAllStorageDevices();
                    USB_enableWriteProtect();
                }
                else
                {
                    USB_enableAllStorageDevices();
                    USB_disableWriteProtect();
                }

                if (REG_cbox_DisableRegistry.Checked == true)
                {
                    REG_DisableRegedit();
                }
                else
                {
                    REG_EnableRegedit();
                }
                MessageBox.Show
                    ("In order to enable new setting please" +
                    " reconnect your USB storage devices" +
                    " or restart your computer", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            USB_getStatus();
            REG_getStatus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSecurity_Click(object sender, EventArgs e)
        {
            frmPassword PasswordForm = new frmPassword();
            PasswordForm.ShowDialog();
        }
   }
}