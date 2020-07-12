using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace mode_control
{
    public class ListSports : List<Sports>
    {
        // Path name defined for the development environment
        string folderName = "C:\\sports.dat";

        // Constructor
        public ListSports()
            : base()
        {

        }

        // Destructor
        ~ListSports()
        {
            save();
        }

        // Consult data
        public Sports Query(string mode)
        {
            Sports item = null;

            foreach (Sports data in this)
            {
                if (data.Mode == mode)
                {
                    item = data;
                }
            }
            return item;
        }

        public List<Sports> Queryl(bool mix)
        {
            List<Sports> item = new List<Sports>();
            foreach (Sports data in this)
            {
                if (data.Mixed)
                {
                    item.Add(data);
                }
            }

            return item;
        }

        // Delete data
        public void Delete(Sports obj)
        {
            Sports item = Query(obj.Mode);

            if (item != null)
            {
                base.Remove(item);
            }
        }

        // Update data
        public void Update(Sports obj)
        {
            Sports item = Query(obj.Mode);

            if (item != null)
            {
                item.toJson = obj.JsonSerialize();
            }
        }
    }
}
