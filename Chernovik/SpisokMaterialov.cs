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
    public partial class SpisokMaterialov : Form
    {
        public SpisokMaterialov()
        {
            InitializeComponent();
        }

        private void materialBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.materialBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.chernovikDataSet);

        }

        private void SpisokMaterialov_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "chernovikDataSet.Material". При необходимости она может быть перемещена или удалена.
            this.materialTableAdapter.Fill(this.chernovikDataSet.Material);

        }

        private void buttonPervaya_Click(object sender, EventArgs e)
        {
            materialBindingSource.MoveFirst();
        }

        private void buttonPoslednyaya_Click(object sender, EventArgs e)
        {
            materialBindingSource.MoveLast();
        }

        private void buttonSled_Click(object sender, EventArgs e)
        {
            materialBindingSource.MoveNext();
        }

        private void buttonPred_Click(object sender, EventArgs e)
        {
            materialBindingSource.MovePrevious();
        }

        private void buttonDobavit_Click(object sender, EventArgs e)
        {
            materialBindingSource.AddNew();
        }

        private void buttonYdalit_Click(object sender, EventArgs e)
        {
            materialBindingSource.RemoveCurrent();
        }

        private void buttonSohr_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.materialBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.chernovikDataSet);
        }

        private void buttonNazad_Click(object sender, EventArgs e)
        {
            Menu mn = new Menu();
            mn.Show();
            this.Hide();
        }

        private void pbMaterialy_Click(object sender, EventArgs e)
        {
            
        }

        private void knopkaGalereya_Click(object sender, EventArgs e)
        {
            Galereya gal = new Galereya();
            gal.Show();
            this.Hide();
        }

        private void сортироватьToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.materialTableAdapter.Сортировать(this.chernovikDataSet.Material);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
