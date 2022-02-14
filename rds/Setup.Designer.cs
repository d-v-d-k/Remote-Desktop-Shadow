namespace rds
{
    partial class Setup
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
            this.btnApply = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbConsent = new System.Windows.Forms.CheckBox();
            this.cbNoLogin = new System.Windows.Forms.CheckBox();
            this.btnManual = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbNoPass = new System.Windows.Forms.CheckBox();
            this.ddlPermission = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAuto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(318, 326);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 25);
            this.btnApply.TabIndex = 7;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.cbConsent);
            this.groupBox3.Controls.Add(this.btnAuto);
            this.groupBox3.Controls.Add(this.cbNoLogin);
            this.groupBox3.Controls.Add(this.btnManual);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.cbNoPass);
            this.groupBox3.Controls.Add(this.ddlPermission);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(12, 122);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(381, 198);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Settings";
            // 
            // cbConsent
            // 
            this.cbConsent.AutoSize = true;
            this.cbConsent.Location = new System.Drawing.Point(121, 95);
            this.cbConsent.Name = "cbConsent";
            this.cbConsent.Size = new System.Drawing.Size(104, 17);
            this.cbConsent.TabIndex = 26;
            this.cbConsent.Text = "Require consent";
            this.cbConsent.UseVisualStyleBackColor = true;
            // 
            // cbNoLogin
            // 
            this.cbNoLogin.AutoSize = true;
            this.cbNoLogin.Location = new System.Drawing.Point(15, 146);
            this.cbNoLogin.Name = "cbNoLogin";
            this.cbNoLogin.Size = new System.Drawing.Size(216, 17);
            this.cbNoLogin.TabIndex = 24;
            this.cbNoLogin.Text = "Don\'t require physical login after resume.";
            this.cbNoLogin.UseVisualStyleBackColor = true;
            // 
            // btnManual
            // 
            this.btnManual.Location = new System.Drawing.Point(15, 36);
            this.btnManual.Name = "btnManual";
            this.btnManual.Size = new System.Drawing.Size(75, 25);
            this.btnManual.TabIndex = 23;
            this.btnManual.Text = "Manual";
            this.btnManual.UseVisualStyleBackColor = true;
            this.btnManual.Click += new System.EventHandler(this.btnManual_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Type of access:";
            // 
            // cbNoPass
            // 
            this.cbNoPass.AutoSize = true;
            this.cbNoPass.Location = new System.Drawing.Point(15, 169);
            this.cbNoPass.Name = "cbNoPass";
            this.cbNoPass.Size = new System.Drawing.Size(227, 17);
            this.cbNoPass.TabIndex = 22;
            this.cbNoPass.Text = "Allow accounts without password (unsafe).";
            this.cbNoPass.UseVisualStyleBackColor = true;
            // 
            // ddlPermission
            // 
            this.ddlPermission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlPermission.FormattingEnabled = true;
            this.ddlPermission.Items.AddRange(new object[] {
            "View only",
            "Full control"});
            this.ddlPermission.Location = new System.Drawing.Point(15, 93);
            this.ddlPermission.Name = "ddlPermission";
            this.ddlPermission.Size = new System.Drawing.Size(100, 21);
            this.ddlPermission.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Enable and choose access:";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(12, 326);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 25);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Cancel";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAuto
            // 
            this.btnAuto.Location = new System.Drawing.Point(96, 36);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(75, 25);
            this.btnAuto.TabIndex = 18;
            this.btnAuto.Text = "Automatic";
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 26);
            this.label1.TabIndex = 19;
            this.label1.Text = "Enter and apply these settings if you want to configure this computer\r\nto be remo" +
    "tely shadowed.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::rds.Properties.Resources.header;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(405, 72);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Other:";
            // 
            // Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(405, 363);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnApply);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Setup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuration";
            this.Load += new System.EventHandler(this.Setup_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.CheckBox cbNoPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnManual;
        private System.Windows.Forms.CheckBox cbNoLogin;
        private System.Windows.Forms.CheckBox cbConsent;
        private System.Windows.Forms.ComboBox ddlPermission;
        private System.Windows.Forms.Label label5;
    }
}