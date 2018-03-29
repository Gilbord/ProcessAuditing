using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Approximate
{
    public class ExponentialRegression
    {
        private dynamic points;
        public ExponentialRegression(dynamic points)
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
            var X = new List<float>();
            var Y = new List<float>();
            foreach (dynamic point in this.points)
            {
                float x = point.GetType().GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance)[0].GetValue(point);
                float y = point.GetType().GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance)[1].GetValue(point);
                X.Add(x);
                Y.Add(y);
            }
            double[] y_hat = Generate.Map(y, Math.Log);
            double[] p_hat = Fit.LinearCombination(x, y_hat, method, t => 1.0, t => t);
            return new[] { Math.Exp(p_hat[0]), p_hat[1] };
        }
    }
}
