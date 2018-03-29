using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GraphPlugin
{
    class OSUtils
    {
        public static string PATH_TO_PROJECT_DIRECTORY = @"D:\PRM\С#\GraphPlugin\GraphPlugin";
        public static string PATH_TO_DLL_LIBS = String.Format("{0}\\{1}", PATH_TO_PROJECT_DIRECTORY, "lib");
        static public List<string> GetPluginsNames()
        {
            DirectoryInfo d = new DirectoryInfo(PATH_TO_DLL_LIBS);
            FileInfo[] files = d.GetFiles("*.dll");
            var pluginsNames = new List<string>();
            foreach (FileInfo file in files)
            {
                pluginsNames.Add(file.Name.Substring(0, file.Name.Length - 4));
            };
            return pluginsNames;
        }

        static public dynamic LoadPlugin(string name, List<Point> points)
        {
            var ext = "dll";
            Assembly DLL = Assembly.LoadFrom(String.Format("{0}\\{1}.{2}", PATH_TO_DLL_LIBS, name, ext));
            Type classType = DLL.GetType(String.Format("{0}.{1}", "Approximate", name));
            dynamic classInst = Activator.CreateInstance(classType, points);
            return classInst;
        }

    }
}
