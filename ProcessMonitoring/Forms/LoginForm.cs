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
    public partial class LoginForm : Form
    {
        private User user = null;
        public User User
        {
            get
            {
                return this.user;
            }
        }
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.user = User.getUser(this.loginInput.Text, this.passwordInput.Text);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            this.user = new User(this.loginInput.Text, this.passwordInput.Text, false, UserSettings.getDefaultSettings());
            try
            {
                this.user.save();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
