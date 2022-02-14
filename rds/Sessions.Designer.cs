
namespace rds
{
    partial class Sessions
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
            this.lvSessions = new System.Windows.Forms.ListView();
            this.cID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnReload = new System.Windows.Forms.Button();
            this.btnShadow = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvSessions
            // 
            this.lvSessions.AutoArrange = false;
            this.lvSessions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvSessions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cID,
            this.cUsername});
            this.lvSessions.FullRowSelect = true;
            this.lvSessions.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvSessions.HideSelection = false;
            this.lvSessions.LabelWrap = false;
            this.lvSessions.Location = new System.Drawing.Point(12, 12);
            this.lvSessions.MultiSelect = false;
            this.lvSessions.Name = "lvSessions";
            this.lvSessions.ShowGroups = false;
            this.lvSessions.Size = new System.Drawing.Size(209, 162);
            this.lvSessions.TabIndex = 1;
            this.lvSessions.UseCompatibleStateImageBehavior = false;
            this.lvSessions.View = System.Windows.Forms.View.Details;
            this.lvSessions.SelectedIndexChanged += new System.EventHandler(this.lvSessions_SelectedIndexChanged);
            // 
            // cID
            // 
            this.cID.Text = "Session";
            this.cID.Width = 64;
            // 
            // cUsername
            // 
            this.cUsername.Text = "Username";
            this.cUsername.Width = 128;
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(227, 41);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 23);
            this.btnReload.TabIndex = 3;
            this.btnReload.Text = "Refresh";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnShadow
            // 
            this.btnShadow.Enabled = false;
            this.btnShadow.Location = new System.Drawing.Point(227, 12);
            this.btnShadow.Name = "btnShadow";
            this.btnShadow.Size = new System.Drawing.Size(75, 23);
            this.btnShadow.TabIndex = 2;
            this.btnShadow.Text = "Shadow";
            this.btnShadow.UseVisualStyleBackColor = true;
            this.btnShadow.Click += new System.EventHandler(this.btnShadow_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(227, 151);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Sessions
            // 
            this.AcceptButton = this.btnShadow;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(314, 186);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnShadow);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.lvSessions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Sessions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sessions";
            this.Load += new System.EventHandler(this.Sessions_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvSessions;
        private System.Windows.Forms.ColumnHeader cID;
        private System.Windows.Forms.ColumnHeader cUsername;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnShadow;
        private System.Windows.Forms.Button btnClose;
    }
}