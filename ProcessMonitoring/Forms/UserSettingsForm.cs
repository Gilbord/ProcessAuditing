using ProcessMonitoring.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessMonitoring.Forms
{
    public partial class UserSettingsForm : Form
    {
        public UserSettingsForm()
        {
            InitializeComponent();
            this.listUsers.Items.AddRange(User.getAllUsers().ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ((User)this.listUsers.SelectedItem).delete();
            this.listUsers.Items.Remove(this.listUsers.SelectedItem);
            this.listUsers.ClearSelected();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ((User)this.listUsers.SelectedItem).Rights.SaveFiles = this.checkSaveFiles.Checked;
        }

        private void listUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listUsers.SelectedItem == null)
            {
                return;
            }
            this.textLogin.Text = ((User)this.listUsers.SelectedItem).Login;
            this.checkIsAdmin.Checked = ((User)this.listUsers.SelectedItem).IsAdmin;
            this.checkSaveFiles.Checked = ((User)this.listUsers.SelectedItem).Rights.SaveFiles;
            this.checkTip.Checked = ((User)this.listUsers.SelectedItem).Rights.WatchTip;
        }

        private void checkIsAdmin_CheckedChanged(object sender, EventArgs e)
        {
            ((User)this.listUsers.SelectedItem).IsAdmin = this.checkIsAdmin.Checked;
        }

        private void checkTip_CheckedChanged(object sender, EventArgs e)
        {
            ((User)this.listUsers.SelectedItem).Rights.WatchTip = this.checkTip.Checked;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            ((User)this.listUsers.SelectedItem).update();
        }
    }
}
