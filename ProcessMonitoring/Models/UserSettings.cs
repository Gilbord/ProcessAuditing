using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessMonitoring.Models
{
    public class UserSettings
    {

        private bool isWatchTip;
        private bool isSaveFiles;

        public bool WatchTip
        {
            get
            {
                return this.isWatchTip;
            }
            set
            {
                this.isWatchTip = value;
            }
        }

        public bool SaveFiles
        {
            get
            {
                return this.isSaveFiles;
            }
            set
            {
                this.isSaveFiles = value;
            }
        }

        public UserSettings(bool isSaveFiles, bool isWatchTip)
        {
            this.isSaveFiles = isSaveFiles;
            this.isWatchTip = isWatchTip;
        }

        public static UserSettings getDefaultSettings()
        {
            return new UserSettings(true, true);
        }

    }
}
