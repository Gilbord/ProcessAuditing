using ProcessMonitoring.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessMonitoring
{
    public partial class MainForm : Form
    {
        private List<Point> points;
        public MainForm()
        {
            InitializeComponent();
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

        public void LoadPlugin(object sender, EventArgs e, string name)
        {
            var plugin = new Plugin(name, this.points);
            plugin.Load();
        }

        private void openMenu_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text files | *.pmv"; // file types, that will be allowed to upload
            dialog.Multiselect = false; // allow/deny user to upload more than one file at a time
            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                String path = dialog.FileName; // get name of file
                this.points = Utils.OSUtils.LoadPoints(path);
            }
        }
    }
}
