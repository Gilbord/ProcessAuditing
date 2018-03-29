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
    public partial class SettingsForm : Form
    {
        private Settings settings;
        public Settings Settings
        {
            get
            {
                if (this.settings == null)
                {
                    this.settings = Settings.loadSettings();
                }
                return this.settings;
            }
        }

        public SettingsForm(Settings settings)
        {
            InitializeComponent();
            this.textX.Text = this.Settings.NameX;
            this.textY.Text = this.Settings.NameY;
            this.plotColor.BackColor = this.Settings.PlotColor;
            this.pathToPlugins.Text = this.Settings.PathToPlugins;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.settings = new Settings(this.textX.Text, this.textY.Text, this.plotColor.BackColor, this.pathToPlugins.Text);
            this.settings.save();
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void plotColor_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            // Keeps the user from selecting a custom color.
            MyDialog.AllowFullOpen = false;
            // Allows the user to get help. (The default is false.)
            MyDialog.ShowHelp = true;
            // Sets the initial color select to the current text color.
            MyDialog.Color = this.Settings.PlotColor;

            // Update the text box color if the user clicks OK 
            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                plotColor.BackColor = MyDialog.Color;
            }
        }

        private void buttonPathToPlugins_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    this.pathToPlugins.Text = fbd.SelectedPath;
                }
            }
        }
    }
}
