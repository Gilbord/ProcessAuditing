using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TablePlugin
{
    public class Plugin
    {
        private dynamic points;
        public Plugin(dynamic points)
        {
            if (points == null)
            {
                throw new DataIsNotValidException("Didn't choose data");
            }
            this.points = points;
        }

        public void Perform()
        {
            var form = new MainForm(this.points);
            form.Show();
        }
    }

    class DataIsNotValidException : Exception
    {
        public DataIsNotValidException(string message) : base(message)
        { }
    }

}
