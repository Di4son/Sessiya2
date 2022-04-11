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
    public partial class TipyMaterialov : Form
    {
        public TipyMaterialov()
        {
            InitializeComponent();
        }

        private void materialTypeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.materialTypeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.chernovikDataSet);

        }

        private void TipyMaterialov_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "chernovikDataSet.MaterialType". При необходимости она может быть перемещена или удалена.
            this.materialTypeTableAdapter.Fill(this.chernovikDataSet.MaterialType);

        }

        private void buttonPervaya_Click(object sender, EventArgs e)
        {
            materialTypeBindingSource.MoveFirst();
        }

        private void buttonPoslednyaya_Click(object sender, EventArgs e)
        {
            materialTypeBindingSource.MoveLast();
        }

        private void buttonSled_Click(object sender, EventArgs e)
        {
            materialTypeBindingSource.MoveNext();
        }

        private void buttonPred_Click(object sender, EventArgs e)
        {
            materialTypeBindingSource.MovePrevious();
        }

        private void buttonDobavit_Click(object sender, EventArgs e)
        {
            materialTypeBindingSource.AddNew();
        }

        private void buttonYdalit_Click(object sender, EventArgs e)
        {
            materialTypeBindingSource.RemoveCurrent();
        }

        private void buttonSohr_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.materialTypeBindingSource.EndEdit();
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
