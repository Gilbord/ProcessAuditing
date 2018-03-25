using ProcessMonitoring.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessMonitoring
{
    class Plugin
    {
        private string name;
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public List<Point> Points
        {
            get; set;
        }

        public Plugin(string name, List<Point> points)
        {
            this.name = name;
            this.Points = points;
        }

        public void Load()
        {
            var ext = "dll";
            Assembly DLL = Assembly.LoadFrom(String.Format("{0}\\{1}.{2}", Utils.Constants.PATH_TO_DLL_LIBS, name, ext));
            Type classType = DLL.GetType(String.Format("{0}.{1}", name, "Plugin"));
            try
            {
                dynamic classInst = Activator.CreateInstance(classType, this.Points);
                classInst.Perform();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }


    }
}
