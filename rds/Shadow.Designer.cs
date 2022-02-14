namespace rds
{
    partial class Shadow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shadow));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudSession = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSetup = new System.Windows.Forms.Button();
            this.btnShadow = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.Label();
            this.cbConsent = new System.Windows.Forms.CheckBox();
            this.txtSession = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.Label();
            this.cbComputer = new System.Windows.Forms.ComboBox();
            this.cbCredentials = new System.Windows.Forms.CheckBox();
            this.btnSessions = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSession)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::rds.Properties.Resources.header;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(405, 72);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Computer:";
            // 
            // nudSession
            // 
            this.nudSession.Location = new System.Drawing.Point(75, 113);
            this.nudSession.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudSession.Name = "nudSession";
            this.nudSession.Size = new System.Drawing.Size(50, 20);
            this.nudSession.TabIndex = 5;
            this.nudSession.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Session:";
            // 
            // btnSetup
            // 
            this.btnSetup.Location = new System.Drawing.Point(318, 189);
            this.btnSetup.Name = "btnSetup";
            this.btnSetup.Size = new System.Drawing.Size(75, 25);
            this.btnSetup.TabIndex = 11;
            this.btnSetup.Text = "Setup";
            this.btnSetup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetup.UseVisualStyleBackColor = true;
            this.btnSetup.Click += new System.EventHandler(this.btnSetup_Click);
            // 
            // btnShadow
            // 
            this.btnShadow.Enabled = false;
            this.btnShadow.Location = new System.Drawing.Point(237, 189);
            this.btnShadow.Name = "btnShadow";
            this.btnShadow.Size = new System.Drawing.Size(75, 25);
            this.btnShadow.TabIndex = 10;
            this.btnShadow.Text = "Shadow";
            this.btnShadow.UseVisualStyleBackColor = true;
            this.btnShadow.Click += new System.EventHandler(this.btnShadow_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.AutoSize = true;
            this.txtMessage.Location = new System.Drawing.Point(12, 141);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(50, 13);
            this.txtMessage.TabIndex = 7;
            this.txtMessage.Text = "Message";
            // 
            // cbConsent
            // 
            this.cbConsent.AutoSize = true;
            this.cbConsent.Location = new System.Drawing.Point(15, 197);
            this.cbConsent.Name = "cbConsent";
            this.cbConsent.Size = new System.Drawing.Size(153, 17);
            this.cbConsent.TabIndex = 9;
            this.cbConsent.Text = "Don\'t ask user for consent.";
            this.cbConsent.UseVisualStyleBackColor = true;
            // 
            // txtSession
            // 
            this.txtSession.AutoSize = true;
            this.txtSession.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtSession.Location = new System.Drawing.Point(162, 115);
            this.txtSession.Name = "txtSession";
            this.txtSession.Size = new System.Drawing.Size(42, 13);
            this.txtSession.TabIndex = 6;
            this.txtSession.Text = "session";
            // 
            // txtIP
            // 
            this.txtIP.AutoSize = true;
            this.txtIP.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtIP.Location = new System.Drawing.Point(281, 89);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(53, 13);
            this.txtIP.TabIndex = 3;
            this.txtIP.Text = "hostname";
            // 
            // cbComputer
            // 
            this.cbComputer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbComputer.FormattingEnabled = true;
            this.cbComputer.Location = new System.Drawing.Point(75, 86);
            this.cbComputer.MaxDropDownItems = 10;
            this.cbComputer.Name = "cbComputer";
            this.cbComputer.Size = new System.Drawing.Size(200, 21);
            this.cbComputer.TabIndex = 2;
            this.cbComputer.TextChanged += new System.EventHandler(this.cbComputer_TextChanged);
            // 
            // cbCredentials
            // 
            this.cbCredentials.AutoSize = true;
            this.cbCredentials.Location = new System.Drawing.Point(15, 174);
            this.cbCredentials.Name = "cbCredentials";
            this.cbCredentials.Size = new System.Drawing.Size(182, 17);
            this.cbCredentials.TabIndex = 8;
            this.cbCredentials.Text = "Use current or saved credentials.";
            this.cbCredentials.UseVisualStyleBackColor = true;
            // 
            // btnSessions
            // 
            this.btnSessions.Location = new System.Drawing.Point(131, 113);
            this.btnSessions.Name = "btnSessions";
            this.btnSessions.Size = new System.Drawing.Size(25, 20);
            this.btnSessions.TabIndex = 13;
            this.btnSessions.Text = "...";
            this.btnSessions.UseVisualStyleBackColor = true;
            this.btnSessions.Click += new System.EventHandler(this.btnSessions_Click);
            // 
            // Shadow
            // 
            this.AcceptButton = this.btnShadow;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 226);
            this.Controls.Add(this.btnSessions);
            this.Controls.Add(this.cbCredentials);
            this.Controls.Add(this.cbComputer);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.txtSession);
            this.Controls.Add(this.cbConsent);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnShadow);
            this.Controls.Add(this.btnSetup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudSession);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Shadow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remote Desktop Shadow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Shadow_FormClosing);
            this.Load += new System.EventHandler(this.Shadow_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Shadow_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSession)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudSession;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSetup;
        private System.Windows.Forms.Button btnShadow;
        private System.Windows.Forms.Label txtMessage;
        private System.Windows.Forms.CheckBox cbConsent;
        private System.Windows.Forms.Label txtSession;
        private System.Windows.Forms.Label txtIP;
        private System.Windows.Forms.ComboBox cbComputer;
        private System.Windows.Forms.CheckBox cbCredentials;
        private System.Windows.Forms.Button btnSessions;
    }
}

