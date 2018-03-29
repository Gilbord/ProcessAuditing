using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TablePlugin
{
    public partial class MainForm : Form
    {
        public MainForm(dynamic points)
        {
            InitializeComponent();
            var num = 0;
            foreach(dynamic point in points) {
                num++;
                float x = point.GetType().GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance)[0].GetValue(point);
                float y = point.GetType().GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance)[1].GetValue(point);
                string[] row = { num.ToString(), x.ToString(), y.ToString() };
                this.dataGridView1.Rows.Add(row);
            }
            
        }
        
    }
}
