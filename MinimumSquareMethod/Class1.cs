using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Approximate
{
    public class MinimumSquareMethod
    {
        private dynamic points;
        public MinimumSquareMethod(dynamic points)
        {
            this.points = points;
        }

        public List<Tuple<float, float>> calculate()
        {
            var parameters = getParameters();
            var result = new List<Tuple<float, float>>();
            foreach (dynamic point in this.points)
            {
                float x = point.GetType().GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance)[0].GetValue(point);
                float y = parameters.Item1 * x + parameters.Item2;
                result.Add(new Tuple<float, float>(x, y));
            }
            return result;
        }

        public Tuple<float, float> getParameters()
        {
            float sumx = 0;
            float sumy = 0;
            float sumx2 = 0;
            float sumxy = 0;
            int n = this.points.Count;
            foreach (dynamic point in this.points)
            {
                float x = point.GetType().GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance)[0].GetValue(point);
                float y = point.GetType().GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance)[1].GetValue(point);
                sumx += x;
                sumy += y;
                sumx2 += x * x;
                sumxy += x * y;
            }
            float a = (n * sumxy - (sumx * sumy)) / (n * sumx2 - sumx * sumx);
            float b = (sumy - a * sumx) / n;
            return new Tuple<float, float>(a, b);
        }
    }
}
