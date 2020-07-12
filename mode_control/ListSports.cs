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
    }
}
