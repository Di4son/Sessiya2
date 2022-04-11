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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void SpisokMaterialov_Click(object sender, EventArgs e)
        {
            SpisokMaterialov sm = new SpisokMaterialov();
            sm.Show();
            this.Hide();
        }

        private void Postavshiki_Click(object sender, EventArgs e)
        {
            Postavshiki ps = new Postavshiki();
            ps.Show();
            this.Hide();
        }

        private void TipyMaterialov_Click(object sender, EventArgs e)
        {
            TipyMaterialov tm = new TipyMaterialov();
            tm.Show();
            this.Hide();
        }

        private void VozmozhniyePostavshiki_Click(object sender, EventArgs e)
        {
            VozhmozhniyePostavshiki vp = new VozhmozhniyePostavshiki();
            vp.Show();
            this.Hide();
        }
    }
}
