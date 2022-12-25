using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomerOrganizer.Database;
using MySql.Data.MySqlClient;
namespace CustomerOrganizer
{
    public partial class Start : Krypton.Toolkit.KryptonForm
    {
        public Start()
        {
            InitializeComponent();
        }

        private void kryptonHeader1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!Connections.db.tryConnect())
            {
                MessageBox.Show("Database connection task failed, please configurate your SQL Connection parameters in Database / Connections Class","Email Organizer");
            }
            else
            {
                updateData();
            }
        }
        public void updateData()
        {
            this.customers.Rows.Clear();
            MySqlCommand getNames = new MySqlCommand("SELECT * FROM customers",Database.Connections.db.connection);
            using (MySqlDataReader readNames = getNames.ExecuteReader())
            {
                while (readNames.Read())
                {
                    this.customers.Rows.Add(readNames.GetString(0), readNames.GetString(1), readNames.GetString(2), readNames.GetString(3), readNames.GetString(4),readNames.GetString(5), readNames.GetString(6), readNames.GetString(7), readNames.GetString(8));
                }
            }
        }



        private void getCustomers_Click(object sender, EventArgs e)
        {
            updateData();
            customers.Visible = true;
        }

        private void insertCustomers_Click(object sender, EventArgs e)
        {
            addCustomer customerAdd = new addCustomer();
            customerAdd.ShowDialog();
        }
    }
}
