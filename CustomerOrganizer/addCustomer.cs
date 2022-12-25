using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace CustomerOrganizer
{
    public partial class addCustomer : Krypton.Toolkit.KryptonForm
    {
        public addCustomer()
        {
            InitializeComponent();
        }

        private void addCustomer_Load(object sender, EventArgs e)
        {

        }

        private void insertCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand insertCustomer = new MySqlCommand($"INSERT INTO customers (firstName, secondName, thridName, phone_number, fax, email, address, age, sex, id) VALUES('" +
    fName.Text +
    "','" +
    sName.Text +
    "','" +
    thirdName.Text +
    "','" +
    pNum.Text +
    "','" +
    faxId.Text +
    "','" +
    eMail.Text +
    "','" +
    address.Text +
    "','" +
    int.Parse(age.Text) +
    "','" +
    sex.Text +
    "','" +
    getId() +
    "')", Database.Connections.db.connection);
                insertCustomer.ExecuteScalar();
                MessageBox.Show("Successfully inserted customer !", "Customer Organizer");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message,"Error");
            }
        }
        public static int getId()
        {
            MySqlCommand getId = new MySqlCommand("SELECT COUNT(*) from customers", Database.Connections.db.connection);
            int totalId = 0;
            using (MySqlDataReader readId = getId.ExecuteReader())
            {
                while (readId.Read())
                {
                    totalId = readId.GetInt32(0);
                }
                return totalId + 1;
            }
        }
    }
}
