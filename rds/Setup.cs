using System;
using System.Windows.Forms;
using System.Diagnostics; // Process
using Microsoft.Win32; // Registry
using System.IO; // Files

namespace rds
{
    public partial class Setup : Form
    {
        public Setup()
        {
            InitializeComponent();
        }

        private void Setup_Load(object sender, EventArgs e)
        {
            ddlPermission.SelectedIndex = 1;
        }

        private void btnEnable_Click(object sender, EventArgs e)
        {

        }

        private void btnDisable_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnManual_Click(object sender, EventArgs e)
        {
            Process.Start("SystemPropertiesRemote.exe");
            //Process.Start("ms-settings:remotedesktop");
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want enable Remote Desktop, and give \"" + Environment.UserName + "\" permission to shadow? ", "Enable", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr != DialogResult.Yes) return;

            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Terminal Server", "fDenyTSConnections", "0", RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows NT\Terminal Services", "Shadow", "3", RegistryValueKind.DWord);

            // "Remote Desktop - Shadow (TCP-In)", "Remote Desktop - User Mode (TCP-In)", "Remote Desktop - User Mode (UDP-In)"
            //Process.Start("powershell.exe", "Enable-NetFirewallRule -Group '@FirewallAPI.dll,-28752'");
            Process.Start("cmd.exe", "/c netsh advfirewall firewall set rule group=\"Remote Desktop\" new enable=yes");

            Process.Start("cmd.exe", "/c net localgroup \"Remote Desktop Users\" /add"); // Create Group first in case its Windows Home.
            Process.Start("cmd.exe", "/c net localgroup \"Remote Desktop Users\" \"" + Environment.UserDomainName + "\\" + Environment.UserName + "\" /add");
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            int shadow = 0;
            if (ddlPermission.SelectedIndex == 0)
            {
                if (cbConsent.Checked) shadow = 3;
                else shadow = 4;
            }
            if (ddlPermission.SelectedIndex == 1)
            {
                if (cbConsent.Checked) shadow = 2;
                else shadow = 1;
            }
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows NT\Terminal Services", "Shadow", shadow, RegistryValueKind.DWord);

            Process.Start("cmd.exe", "/c powercfg /SETACVALUEINDEX SCHEME_CURRENT SUB_NONE CONSOLELOCK " + !cbNoLogin.Checked); // Plugged
            Process.Start("cmd.exe", "/c powercfg /SETDCVALUEINDEX SCHEME_CURRENT SUB_NONE CONSOLELOCK " + !cbNoLogin.Checked); // Battery

            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Lsa", "LimitBlankPasswordUse", !cbNoPass.Checked, RegistryValueKind.DWord);

            System.Threading.Thread.Sleep(2000);
            MessageBox.Show("The Remote Desktop Shadow settings have been successfully applied!", "Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
