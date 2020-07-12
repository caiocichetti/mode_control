using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mode_control
{
    public class Sports
    {
        // Variables
        private string mode;
        private int maximum;
        private int minimal;
        private bool mixed;

        // Constructor
        public Sports(string mo, int mi, int ma, bool mx)
        {
            mode = mo;
            minimal = mi;
            maximum = ma;
            mixed = mx;
        }
    }
}
