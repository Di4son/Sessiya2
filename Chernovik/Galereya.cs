using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chernovik
{
    public partial class Galereya : Form
    {
        public Galereya()
        {
            InitializeComponent();
        }

        private void knopkaNazad_Click(object sender, EventArgs e)
        {
            SpisokMaterialov sm = new SpisokMaterialov();
            sm.Show();
            this.Hide();
        }

        private void knopkaYbrat_Click(object sender, EventArgs e)
        {
            pictureBox29.Visible = true;
        }

        private void knopkaDobavit_Click(object sender, EventArgs e)
        {
            pictureBox29.Visible = false;
        }
    }
}
