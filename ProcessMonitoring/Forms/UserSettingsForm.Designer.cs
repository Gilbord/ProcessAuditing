namespace ProcessMonitoring.Forms
{
    partial class UserSettingsForm
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
            this.listUsers = new System.Windows.Forms.ListBox();
            this.checkIsAdmin = new System.Windows.Forms.CheckBox();
            this.deleteUser = new System.Windows.Forms.Button();
            this.textLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkSaveFiles = new System.Windows.Forms.CheckBox();
            this.checkTip = new System.Windows.Forms.CheckBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listUsers
            // 
            this.listUsers.FormattingEnabled = true;
            this.listUsers.Location = new System.Drawing.Point(2, 7);
            this.listUsers.Name = "listUsers";
            this.listUsers.Size = new System.Drawing.Size(250, 563);
            this.listUsers.TabIndex = 0;
            this.listUsers.SelectedIndexChanged += new System.EventHandler(this.listUsers_SelectedIndexChanged);
            // 
            // checkIsAdmin
            // 
            this.checkIsAdmin.AutoSize = true;
            this.checkIsAdmin.Location = new System.Drawing.Point(258, 79);
            this.checkIsAdmin.Name = "checkIsAdmin";
            this.checkIsAdmin.Size = new System.Drawing.Size(105, 17);
            this.checkIsAdmin.TabIndex = 1;
            this.checkIsAdmin.Text = "Администратор";
            this.checkIsAdmin.UseVisualStyleBackColor = true;
            this.checkIsAdmin.CheckedChanged += new System.EventHandler(this.checkIsAdmin_CheckedChanged);
            // 
            // deleteUser
            // 
            this.deleteUser.Location = new System.Drawing.Point(258, 534);
            this.deleteUser.Name = "deleteUser";
            this.deleteUser.Size = new System.Drawing.Size(75, 23);
            this.deleteUser.TabIndex = 2;
            this.deleteUser.Text = "Удалить";
            this.deleteUser.UseVisualStyleBackColor = true;
            this.deleteUser.Click += new System.EventHandler(this.button1_Click);
            // 
            // textLogin
            // 
            this.textLogin.Location = new System.Drawing.Point(324, 16);
            this.textLogin.Name = "textLogin";
            this.textLogin.Size = new System.Drawing.Size(100, 20);
            this.textLogin.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Login";
            // 
            // checkSaveFiles
            // 
            this.checkSaveFiles.AutoSize = true;
            this.checkSaveFiles.Location = new System.Drawing.Point(258, 102);
            this.checkSaveFiles.Name = "checkSaveFiles";
            this.checkSaveFiles.Size = new System.Drawing.Size(127, 17);
            this.checkSaveFiles.TabIndex = 7;
            this.checkSaveFiles.Text = "Сохранение файлов";
            this.checkSaveFiles.UseVisualStyleBackColor = true;
            this.checkSaveFiles.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkTip
            // 
            this.checkTip.AutoSize = true;
            this.checkTip.Location = new System.Drawing.Point(258, 125);
            this.checkTip.Name = "checkTip";
            this.checkTip.Size = new System.Drawing.Size(122, 17);
            this.checkTip.TabIndex = 8;
            this.checkTip.Text = "Просмотр справки";
            this.checkTip.UseVisualStyleBackColor = true;
            this.checkTip.CheckedChanged += new System.EventHandler(this.checkTip_CheckedChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(389, 534);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // UserSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 569);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.checkTip);
            this.Controls.Add(this.checkSaveFiles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textLogin);
            this.Controls.Add(this.deleteUser);
            this.Controls.Add(this.checkIsAdmin);
            this.Controls.Add(this.listUsers);
            this.Name = "UserSettingsForm";
            this.Text = "UserSettingsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listUsers;
        private System.Windows.Forms.CheckBox checkIsAdmin;
        private System.Windows.Forms.Button deleteUser;
        private System.Windows.Forms.TextBox textLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkSaveFiles;
        private System.Windows.Forms.CheckBox checkTip;
        private System.Windows.Forms.Button buttonSave;
    }
}