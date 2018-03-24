using ProcessMonitoring.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessMonitoring.Utils
{
    class OSUtils
    {
        static public List<string> GetPluginsNames(string path)
        {
            DirectoryInfo d = new DirectoryInfo(path);
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
            Assembly DLL = Assembly.LoadFrom(String.Format("{0}\\{1}.{2}", Utils.Constants.PATH_TO_DLL_LIBS, name, ext));
            Type classType = DLL.GetType(String.Format("{0}.{1}", name, "Plugin"));
            dynamic classInst = Activator.CreateInstance(classType, "Hello");
            return classInst;
        }

        static public List<Point> LoadPoints(string path)
        {
            var result = new List<Point>();
            using (StreamReader reader = new StreamReader(new FileStream(path, FileMode.Open), new UTF8Encoding()))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var data = line.Split(' ');
                    result.Add(new Point(float.Parse(data[0]), float.Parse(data[1])));
                }
            }
            return result;
        }

        static public void WritePoints(string path, List<Point> points)
        {
            using (StreamWriter writer = new StreamWriter(new FileStream(path, FileMode.OpenOrCreate), new UTF8Encoding()))
            {
                points.ForEach(delegate (Point point)
                {
                    writer.WriteLine(String.Format("{0} {1}", point.X, point.Y));
                });
            }
        }
    }
}
