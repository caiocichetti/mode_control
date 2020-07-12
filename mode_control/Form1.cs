using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mode_control
{
    public partial class Form1 : Form
    {
        ListSports data;

        public Form1()
        {
            InitializeComponent();
            data = new ListSports();
            dataGridView1.DataSource = data;
        }
    }
}
