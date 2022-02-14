using System;
using System.Windows.Forms;
using System.Diagnostics; // Process
using System.IO; // Files
using System.Security.Principal; // UAC etc.
using Microsoft.Win32; // Registry

namespace rds
{
    public partial class Shadow : Form
    {
        int MaxHistorySavings = 5;

        public Shadow()
        {
            InitializeComponent();
            //this.Icon = Properties.Resources.icons;
        }

        private void Shadow_Load(object sender, EventArgs e)
        {
            cbComputer_TextChanged(sender, e);

            txtIP.Text = System.Environment.MachineName;

            // Get Session ID of user that executes this app:
            txtSession.Text = Process.GetCurrentProcess().SessionId.ToString();

            // Get Console Session ID:
            string GlassID = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Terminal Server", "GlassSessionId", "Unknown").ToString();
            if(GlassID != "Unknown") txtSession.Text += " (" + GlassID + ")";

            if (!(new WindowsPrincipal(WindowsIdentity.GetCurrent())).IsInRole(WindowsBuiltInRole.Administrator))
                btnSetup.Image = rds.Properties.Resources.shield;

            LoadPreferences();
        }

        private void cbComputer_TextChanged(object sender, EventArgs e)
        {
            if (cbComputer.Text.Length == 0)
            {
                btnShadow.Enabled = false;
                txtMessage.Text = "The computer field is blank. Enter a hostname or IP address.";
            }
            else
            {
                btnShadow.Enabled = true;
                txtMessage.Text = "You will be asked for credentials when you connect.";
            }
        }

        private void btnShadow_Click(object sender, EventArgs e)
        {
            string prompt = string.Empty;
            string consent = string.Empty;
            if (!cbCredentials.Checked) prompt = " /prompt";
            if (cbConsent.Checked) consent = " /noconsentprompt";

            Process.Start("mstsc.exe", @"/v:" + cbComputer.Text + " /shadow:" + nudSession.Value + prompt + " /control" + consent);
            AddShadowHistory();
        }

        private void btnSetup_Click(object sender, EventArgs e)
        {
            //if((new WindowsPrincipal(WindowsIdentity.GetCurrent())).IsInRole(WindowsBuiltInRole.Administrator))
            if (btnSetup.Image == null)
            {
                Setup setup = new Setup();
                setup.ShowDialog();
                return;
            }
            ProcessStartInfo proc = new ProcessStartInfo();
            proc.UseShellExecute = true;
            proc.WorkingDirectory = Environment.CurrentDirectory;
            proc.FileName = Application.ExecutablePath;
            proc.Arguments = @"/setup";
            proc.Verb = "runas";
            try { Process.Start(proc); }
            catch (Exception) {  MessageBox.Show("Unable to rerun this application as an Administrator, check if your account has sufficient rights.\nThe setup-feature of this application requires elevated permissions.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop); return; }
            Application.Exit();
        }

        private void Shadow_FormClosing(object sender, FormClosingEventArgs e)
        {
            SetPreferences();
        }

        void LoadPreferences()
        {
            RegistryKey rk = Registry.CurrentUser; // true
            if ((rk = Registry.CurrentUser.OpenSubKey(@"Software\Remote Desktop Shadow\History", false)) == null)
                rk = Registry.CurrentUser.CreateSubKey(@"Software\Remote Desktop Shadow\History");

            for (int i = 0; i < MaxHistorySavings; i++)
            {
                if (rk.GetValue(i.ToString()) != null)
                    cbComputer.Items.Add(rk.GetValue(i.ToString()));
            }
            rk.Close();
            cbComputer.SelectedIndex = cbComputer.Items.Count-1;

            nudSession.Value = Convert.ToInt32(Registry.GetValue(@"HKEY_CURRENT_USER\Software\Remote Desktop Shadow", "LastSession", 1));
            cbCredentials.Checked = Convert.ToBoolean(Registry.GetValue(@"HKEY_CURRENT_USER\Software\Remote Desktop Shadow", "AskCredentials", 0));
            cbConsent.Checked = Convert.ToBoolean(Registry.GetValue(@"HKEY_CURRENT_USER\Software\Remote Desktop Shadow", "DontAskConsent", 0));
        }

        void AddShadowHistory()
        {
            string computer = cbComputer.Text;
            if (cbComputer.Items.Contains(cbComputer.Text))
            {
                cbComputer.Items.Remove(cbComputer.Text);
            }
            cbComputer.Items.Add(computer);

            if (cbComputer.Items.Count > MaxHistorySavings)
                cbComputer.Items.RemoveAt(0);

            cbComputer.SelectedItem = computer;
        }

        void SetPreferences()
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey(@"Software\Remote Desktop Shadow\History", true);
            for (int i = 0; i < cbComputer.Items.Count; i++)
            {
                rk.SetValue(i.ToString(), cbComputer.Items[i], RegistryValueKind.String);
            }
            rk.Close();

            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Remote Desktop Shadow", "LastSession", nudSession.Value, RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Remote Desktop Shadow", "AskCredentials", cbCredentials.Checked, RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Remote Desktop Shadow", "DontAskConsent", cbConsent.Checked, RegistryValueKind.DWord);
        }

        private void btnSessions_Click(object sender, EventArgs e)
        {
            Sessions fSessions = new Sessions();
            fSessions.Computer = cbComputer.Text;
            fSessions.ShowDialog();
        }

        private void Shadow_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Process.Start("http://wiki.danit.nl/index.php/Remote_Desktop_Shadow_(Tool)");
            }
            if (e.KeyCode == Keys.F2)
            {
                Process.Start("rundll32.exe", "keymgr.dll, KRShowKeyMgr");
                //Process.Start("control.exe", "keymgr.dll");
                //Process.Start("control.exe", "/name Microsoft.CredentialManager");
            }
        }
    }
}
