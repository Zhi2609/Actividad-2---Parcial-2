using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_2___Parcial_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este programa fue creado por Cesar Garcia", "Acerca de...",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rojoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
            rojoToolStripMenuItem.Checked = true;
        }

        private void verdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Green;
            rojoToolStripMenuItem.Checked = true;
        }

        private void timesNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comicSansToolStripMenuItem.Checked = false;
            label1.Font = new Font("Times New Roman", 14, label1.Font.Style);
            timesNewRomanToolStripMenuItem.Checked = true;
        }

        private void comicSansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comicSansToolStripMenuItem.Checked = true;
            label1.Font = new Font("Comic Sans MS", 20, label1.Font.Style);
            timesNewRomanToolStripMenuItem.Checked = false;
        }
    }
}
