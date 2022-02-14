using System;
using System.Windows.Forms;
using System.Diagnostics; // Process

namespace rds
{
    public partial class Credentials : Form
    {
        public string Computer;
        public Credentials()
        {
            InitializeComponent();
        }

        private void Credentials_Load(object sender, EventArgs e)
        {
            txtComputer.Text += Computer;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Process.Start("cmdkey.exe", "/add:" + Computer + " /user:" + tbUsername.Text + " /pass:" + tbPassword.Text);
            this.DialogResult = DialogResult.OK;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete the saved credentials for this remote computer?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Process.Start("cmdkey.exe", "/delete:" + Computer);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}