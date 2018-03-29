using ProcessMonitoring.Forms;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace ProcessMonitoring
{
    public partial class MainForm : Form
    {
        private List<Models.Point> points;
        private User user;
        private Settings settings;
        private string pathToSavedFile;

        public Settings Settings
        {
            get
            {
                if (this.settings == null)
                {
                    this.settings = Settings.defaultSettings();
                }
                return this.settings;
            }
        }
        public MainForm()
        { 
            InitializeComponent();
            if (this.user == null)
            {
                this.LoginUser();
            }
            getPlugins();

        }

        private void getPlugins()
        {
            foreach (string name in Utils.OSUtils.GetPluginsNames(Utils.Constants.PATH_TO_DLL_LIBS))
            {
                var plugin = new ToolStripMenuItem()
                {
                    Text = name,
                    Name = String.Format("{0}{1}", name, "Plugin")
                };
                plugin.Click += (sender, EventArgs) => { this.LoadPlugin(sender, EventArgs, name); };
                this.pluginsMenu.DropDownItems.Add(plugin);

            }
        }

        private void LoginUser()
        {
            using (LoginForm loginForm = new LoginForm())
            {
                loginForm.ShowDialog();
                if (loginForm.User == null)
                {
                    MessageBox.Show("You didn't login");
                    this.Dispose();
                    this.Close();
                }
                else
                {
                    this.user = loginForm.User;
                    this.rigthsUpdate();
                }
            }
            
        }

        private void rigthsUpdate()
        {
            var isPointsEmpty = this.points != null;
            this.saveMenu.Enabled = isPointsEmpty && this.user.Rights.SaveFiles;
            this.saveAsMenu.Enabled = isPointsEmpty && this.user.Rights.SaveFiles;
            this.tipMenu.Enabled = this.user.Rights.WatchTip;
            this.usersSetingsMenu.Enabled = this.user.IsAdmin;
        }

        public void LoadPlugin(object sender, EventArgs e, string name)
        {
            var plugin = new Plugin(name, this.points);
            plugin.Load();
        }

        private void openMenu_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text files | *.pmv";
            dialog.Multiselect = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.pathToSavedFile = dialog.FileName;
                this.points = Utils.OSUtils.LoadPoints(this.pathToSavedFile);
                this.saveAsMenu.Enabled = this.user.Rights.SaveFiles;
                this.saveMenu.Enabled = this.user.Rights.SaveFiles;
                this.pluginsMenu.Enabled = true;
                this.drawPlot();
            }
            
        }

        private void drawPlot()
        { 
            if(this.points == null)
            {
                return;
            }
            this.plot.Series.Clear();
            this.plot.ChartAreas[0].AxisX.Title = this.Settings.NameX;
            this.plot.ChartAreas[0].AxisY.Title = this.Settings.NameY;
            this.plot.Series.Add(new Series("line"));
            this.plot.Series.Add(new Series("points"));
            this.plot.Series["line"].ChartType = SeriesChartType.FastLine;
            this.plot.Series["line"].Color = this.Settings.PlotColor;
            this.plot.Series["points"].ChartType = SeriesChartType.Point;
            this.plot.Series["points"].Color = Color.Green;
            this.points.ForEach(delegate (Models.Point point)
            {
                this.plot.Series["line"].Points.AddXY(point.X, point.Y);
                this.plot.Series["points"].Points.AddXY(point.X, point.Y);
            });
        }

        private void settingsMenu_Click(object sender, EventArgs e)
        {
            using (SettingsForm settingsForm = new SettingsForm(this.Settings))
            {
                settingsForm.ShowDialog();
                this.settings = settingsForm.Settings;
            }
            this.drawPlot();
        }

        private void usersSetingsMenu_Click(object sender, EventArgs e)
        {
            using (UserSettingsForm userSettingsForm = new UserSettingsForm())
            {
                userSettingsForm.ShowDialog();
                this.user.getUpdate();
                this.rigthsUpdate();
            }
        }

        private void saveMenu_Click(object sender, EventArgs e)
        {
            Utils.OSUtils.WritePoints(this.pathToSavedFile, this.points);
        }

        private void saveAsMenu_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Text files | *.pmv";
            if (dialog.ShowDialog() == DialogResult.OK && dialog.FileName != "")
            {
                Utils.OSUtils.WritePoints(dialog.FileName, this.points);
            }
        }

        private void changeUserMenu_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.LoginUser();
            this.Visible = true;
        }
    }
}
