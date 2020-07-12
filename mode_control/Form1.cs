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

        private void bInsert_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            Sports newData = new Sports(tMode.Text, Convert.ToInt32(tMinimal.Text), Convert.ToInt32(tMaximum.Text), cMixed.Checked);
            data.Add(newData);
            dataGridView1.DataSource = data;

            tMode.Text = "";
            tMinimal.Text = "";
            tMaximum.Text = "";
            cMixed.Checked = false;

        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem Certeza de Apagar", "Apagar Participante",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dataGridView1.DataSource = null;

                Sports old = new Sports(tMode.Text, 0, 0, false);
                data.Remove(old);
                dataGridView1.DataSource = data;
            }
        }

        private void bQuery_Click(object sender, EventArgs e)
        {
            Sports query = data.Query(tMode.Text);

            if (query != null)
            {
                tMode.Text = query.Mode;
                tMinimal.Text = query.Minimal.ToString();
                tMaximum.Text = query.Maximum.ToString();
                cMixed.Checked = query.Mixed;
            }
            else
            {
                MessageBox.Show("Nao encontrado");
            }
        }

        private void bUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem Certeza de Atualizar", "Atualiza Participante",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    dataGridView1.DataSource = null;
                    Sports update = new Sports(tMode.Text, Convert.ToInt32(tMinimal.Text), Convert.ToInt32(tMaximum.Text), cMixed.Checked);
                    data.Update(update);
                    dataGridView1.DataSource = data;
                }
                catch
                {
                    MessageBox.Show("PAM!");
                    dataGridView1.DataSource = data;
                }

            }
        }

        private void rAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rAll.Checked)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = data;
            }
        }

        private void rMixed_CheckedChanged(object sender, EventArgs e)
        {
            if (rMixed.Checked)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = data.Queryl(cMixed.Checked);
            }
        }
    }
}
