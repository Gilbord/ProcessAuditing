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

        public Settings(string nameX, string nameY, Color plotColor)
        {
            this.nameX = nameX;
            this.nameY = nameY;
            this.plotColor = plotColor;
        }

        public static Settings defaultSettings()
        {
            return new Settings("x", "y", Color.Red);
        }

    }
}
