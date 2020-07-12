using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

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

        // Attributes
        public string Mode { get { return mode; } set { mode = value; } }
        public int Minimal { get { return minimal; } set { minimal = value; } }
        public int Maximum { get { return maximum; } set { maximum = value; } }
        public bool Mixed { get { return mixed; } set { mixed = value; } }

        // Methods
        public override bool Equals(object obj)
        {
           if (mode == ((Sports)obj).Mode)
            { return true; }
           else
            { return false; }
        }

        public string JsonSerialize()
        {
            string data;
            data = JsonConvert.SerializeObject(this);
            return data;
        }

        public string toJson
        {
            set
            {
                string data = value;
                Sports des = JsonConvert.DeserializeObject<Sports>(data);

                if (des != null)
                {
                    mode = des.Mode;
                    minimal = des.Minimal;
                    maximum = des.Maximum;
                    mixed = des.Mixed;
                }
            }
        }
    }
}
