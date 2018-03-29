using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessMonitoring.Models
{
    public class Settings
    {
        private string nameX;
        private string nameY;
        private string pathToPlugins;
        private Color plotColor;

        public string NameX
        {
            get
            {
                if (this.nameX == null || this.nameX == " ")
                {
                    return "x";
                }
                else
                {
                    return this.nameX;
                }
            }
        }

        public string NameY
        {
            get
            {
                if (this.nameY == null || this.nameY == " ")
                {
                    return "y";
                }
                else
                {
                    return this.nameY;
                }
            }
        }

        public Color PlotColor
        {
            get
            {
                return this.plotColor;
            }
        }

        public string PathToPlugins { get => pathToPlugins; set => pathToPlugins = value; }

        public Settings(string nameX, string nameY, Color plotColor, string pathToPlugins)
        {
            this.nameX = nameX;
            this.nameY = nameY;
            this.plotColor = plotColor;
            this.PathToPlugins = pathToPlugins;
        }

        public void save()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\OurSettings", true);
            if (key == null)
            {
                key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\OurSettings", true);
            }

            //storing the values  
            key.SetValue("nameX", this.NameX);
            key.SetValue("nameY", this.NameY);
            key.SetValue("color", this.PlotColor.Name);
            key.SetValue("pathToPlugins", this.PathToPlugins);
            key.Close();
        }

        public static Settings loadSettings()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\OurSettings", true);
            if(key == null)
            {
                key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\OurSettings", true);
            }

            return new Settings(key.GetValue("nameX", "x").ToString(),
                key.GetValue("nameY", "y").ToString(),
                Color.FromName(key.GetValue("color", Color.Red).ToString()),
                key.GetValue("pathToPlugins", Utils.Constants.PATH_TO_DLL_LIBS).ToString());
        }

    }
}
