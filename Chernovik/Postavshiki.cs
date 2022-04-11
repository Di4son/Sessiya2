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
    public partial class Postavshiki : Form
    {
        public Postavshiki()
        {
            InitializeComponent();
        }

        private void supplierBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.supplierBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.chernovikDataSet);

        }

        private void Postavshiki_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "chernovikDataSet.Supplier". При необходимости она может быть перемещена или удалена.
            this.supplierTableAdapter.Fill(this.chernovikDataSet.Supplier);

        }

        private void buttonPervaya_Click(object sender, EventArgs e)
        {
            supplierBindingSource.MoveFirst();
        }

        private void buttonPoslednyaya_Click(object sender, EventArgs e)
        {
            supplierBindingSource.MoveLast();
        }

        private void buttonSled_Click(object sender, EventArgs e)
        {
            supplierBindingSource.MoveNext();
        }

        private void buttonPred_Click(object sender, EventArgs e)
        {
            supplierBindingSource.MovePrevious();
        }

        private void buttonDobavit_Click(object sender, EventArgs e)
        {
            supplierBindingSource.AddNew();
        }

        private void buttonYdalit_Click(object sender, EventArgs e)
        {
            supplierBindingSource.RemoveCurrent();
        }

        private void buttonSohr_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.supplierBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.chernovikDataSet);
        }

        private void buttonNazad_Click(object sender, EventArgs e)
        {
            Menu mn = new Menu();
        }
    }
}
