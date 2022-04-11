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
    public partial class VozhmozhniyePostavshiki : Form
    {
        public VozhmozhniyePostavshiki()
        {
            InitializeComponent();
        }

        private void materialSupplierBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.materialSupplierBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.chernovikDataSet);

        }

        private void VozhmozhniyePostavshiki_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "chernovikDataSet.MaterialSupplier". При необходимости она может быть перемещена или удалена.
            this.materialSupplierTableAdapter.Fill(this.chernovikDataSet.MaterialSupplier);

        }

        private void buttonPervaya_Click(object sender, EventArgs e)
        {
            materialSupplierBindingSource.MoveFirst();
        }

        private void buttonPoslednyaya_Click(object sender, EventArgs e)
        {
            materialSupplierBindingSource.MoveLast();
        }

        private void buttonSled_Click(object sender, EventArgs e)
        {
            materialSupplierBindingSource.MoveNext();
        }

        private void buttonPred_Click(object sender, EventArgs e)
        {
            materialSupplierBindingSource.MovePrevious();
        }

        private void buttonDobavit_Click(object sender, EventArgs e)
        {
            materialSupplierBindingSource.AddNew();
        }

        private void buttonYdalit_Click(object sender, EventArgs e)
        {
            materialSupplierBindingSource.RemoveCurrent();
        }

        private void buttonSohr_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.materialSupplierBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.chernovikDataSet);
        }

        private void buttonNazad_Click(object sender, EventArgs e)
        {
            Menu mn = new Menu();
            mn.Show();
            this.Hide();
        }
    }
}
