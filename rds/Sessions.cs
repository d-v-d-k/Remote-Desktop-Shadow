using System;
using System.Windows.Forms;
using System.Diagnostics; // Process
using Microsoft.Win32; // Registry

namespace rds
{
    public partial class Sessions : Form
    {
        public string Computer;
        RegistryKey rkSessions = null;

        public Sessions()
        {
            InitializeComponent();
        }

        private void Sessions_Load(object sender, EventArgs e)
        {
            this.Text += " of " + Computer;
            ConnectToComputer();
            if (lvSessions.Items.Count != 0) lvSessions.Items[0].Selected = true;
        }

        private void lvSessions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSessions.SelectedItems.Count == 0) btnShadow.Enabled = false;
            else btnShadow.Enabled = true;
        }

        private void btnShadow_Click(object sender, EventArgs e)
        {
            Process.Start("mstsc.exe", @"/v:" + Computer + " /shadow:" + lvSessions.SelectedItems[0].Text + " /noconsentprompt /control");
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadSessions();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void ConnectToComputer(bool error = false)
        {
            try { rkSessions = RegistryKey.OpenRemoteBaseKey(RegistryHive.Users, Computer); }
            catch (Exception ex)
            {
                if (ex.HResult == 53) // "The network path was not found"
                {
                    MessageBox.Show("Unable to connect to \"" + Computer + "\". The remote computer could be offline, or the Remote Registry service disabled.", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    this.Close();
                    return;
                }
                // what error if no permission?
                else if (ex.HResult == -2147024891) // "Attempted to perform an unauthorized operation."
                {
                    if (error)
                    {
                        MessageBox.Show("The credentials used to connect to the remote computer seem to be incorrect.", "Credentials", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("Unable to connect to the remote computers registry.\nThe error message was:\n\n" + ex.Message, "Connect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }
                
                Credentials fCredentials = new Credentials();
                fCredentials.Computer = Computer;
                if (fCredentials.ShowDialog() == DialogResult.OK)
                {
                    System.Threading.Thread.Sleep(1000); // cmdkey.exe may take a while
                    ConnectToComputer(true); 
                }
                else { this.Close(); }
                return;
            }
            LoadSessions();
        }

        void LoadSessions()
        {
            lvSessions.Items.Clear();
            foreach (string subkey in rkSessions.GetSubKeyNames()) // crashes here sometimes because credentials could be entered after rkUsers is created
            {
                RegistryKey rkSession = rkSessions.OpenSubKey(subkey + @"\Volatile Environment");
                if (rkSession != null)
                {
                    lvSessions.Items.Add(rkSession.GetSubKeyNames()[0]).SubItems.Add(rkSession.GetValue("USERNAME").ToString());
                }
            }
        }
    }
}