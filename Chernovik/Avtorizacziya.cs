using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Chernovik
{
    public partial class Avtorizacziya : Form
    {
        public Avtorizacziya()
        {
            InitializeComponent();
        }

        private void voiti_Click(object sender, EventArgs e)
        {
            // Ниже происходит процесс авторизации 
            SqlConnection sqlcon = new SqlConnection(@"Data Source = DESKTOP-FBSADPU\SQLEXPRESS; Initial Catalog = Chernovik; Integrated Security = True"); 
            string query = "Select * from Avtorizacziya Where username = '" + tbUsername.Text.Trim() + "' and password = '" + tbPassword.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dttl = new DataTable();
            sda.Fill(dttl);
            if (dttl.Rows.Count == 1)
            {
                if (tbUsername.Text == "Agent")
                {
                    Menu mn = new Menu();
                    mn.Show();
                    this.Hide();
                }
                else
                {
                    Menu mn = new Menu();
                    mn.Show();
                    this.Hide();
                }      

            }
            else
            {
                MessageBox.Show("Неверные данные!");
            }
        }

        private void knopkaNazad_Click(object sender, EventArgs e)
        {
            Tityl tl = new Tityl();
            tl.Show();
            this.Hide();
        }
    }
}
