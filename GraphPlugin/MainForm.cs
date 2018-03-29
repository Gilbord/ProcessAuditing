using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GraphPlugin
{
    public partial class MainForm : Form
    {
        private List<Point> points = new List<Point>();
        public MainForm(dynamic points)
        {
            InitializeComponent();
            foreach (dynamic point in points)
            {
                float x = point.GetType().GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance)[0].GetValue(point);
                float y = point.GetType().GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance)[1].GetValue(point);
                this.points.Add(new Point(x, y));
            }
            drawPlot(this.points);
            foreach (string name in OSUtils.GetPluginsNames())
            {
                this.methodSelect.Items.Add(name);
            }

        }

        private void drawPlot(List<Point> points)
        {
            this.plot.Series.Clear();
            this.plot.Series.Add(new Series("line"));
            this.plot.Series.Add(new Series("points"));
            this.plot.Series["line"].ChartType = SeriesChartType.FastLine;
            this.plot.Series["line"].Color = Color.Red;
            this.plot.Series["points"].ChartType = SeriesChartType.Point;
            this.plot.Series["points"].Color = Color.Green;
            points.ForEach(delegate (Point point)
            {
                this.plot.Series["line"].Points.AddXY(point.X, point.Y);
                this.plot.Series["points"].Points.AddXY(point.X, point.Y);
            });
        }

        private void drawApproximatePlot(List<Point> points)
        {
            this.drawPlot(this.points);
            this.plot.Series.Add(new Series("approximate line"));
            this.plot.Series.Add(new Series("approximate points"));
            this.plot.Series["approximate line"].ChartType = SeriesChartType.FastLine;
            this.plot.Series["approximate line"].Color = Color.Red;
            this.plot.Series["approximate points"].ChartType = SeriesChartType.Point;
            this.plot.Series["approximate points"].Color = Color.Green;
            points.ForEach(delegate (Point point)
            {
                this.plot.Series["approximate line"].Points.AddXY(point.X, point.Y);
                this.plot.Series["approximate points"].Points.AddXY(point.X, point.Y);
            });
        }

        private void methodSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            var result = new List<Point>();
            var method = OSUtils.LoadPlugin(this.methodSelect.SelectedItem.ToString(), this.points);
            var aproximatedPoints = (List<Tuple<float, float>>)method.calculate();
            foreach (Tuple<float, float> point in aproximatedPoints)
            {
                result.Add(new Point(point.Item1, point.Item2));
            }
            this.drawApproximatePlot(result);
        }
    }

    public class Point
    {
        private float x;
        private float y;

        public float X
        {
            get
            {
                return this.x;
            }
        }

        public float Y
        {
            get
            {
                return this.y;
            }
        }

        public Point(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
