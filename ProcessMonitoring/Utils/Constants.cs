using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessMonitoring.Utils
{
    class Constants
    {
        public static string PATH_TO_PROJECT_DIRECTORY = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
        public static string PATH_TO_DLL_LIBS = String.Format("{0}\\{1}", PATH_TO_PROJECT_DIRECTORY, "lib");
    }
}
