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
                using (MySqlCommand insertCustomer = new MySqlCommand("INSERT INTO customers (firstName, secondName, thirdName, phone_number, fax, email, address, age, sex, id) VALUES(@firstName, @secondName, @thirdName, @phoneNumber, @fax, @email, @address, @age, @sex, @id)",
                                                                         Database.Connections.db.connection))
                {
                    insertCustomer.Parameters.AddWithValue("@firstName", fName.Text);
                    insertCustomer.Parameters.AddWithValue("@secondName", sName.Text);
                    insertCustomer.Parameters.AddWithValue("@thirdName", thirdName.Text);
                    insertCustomer.Parameters.AddWithValue("@phoneNumber", pNum.Text);
                    insertCustomer.Parameters.AddWithValue("@fax", faxId.Text);
                    insertCustomer.Parameters.AddWithValue("@email", eMail.Text);
                    insertCustomer.Parameters.AddWithValue("@address", address.Text);
                    insertCustomer.Parameters.AddWithValue("@age", int.Parse(age.Text));
                    insertCustomer.Parameters.AddWithValue("@sex", sex.Text);
                    insertCustomer.Parameters.AddWithValue("@id", getId());

                    insertCustomer.ExecuteNonQuery();
                }

                MessageBox.Show("Successfully inserted customer !", "Customer Organizer");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        public static int getId()
        {
            using (MySqlCommand getIdCommand = new MySqlCommand("SELECT COUNT(*) FROM customers", Database.Connections.db.connection))
            {
                int totalId = 0;

                using (MySqlDataReader readId = getIdCommand.ExecuteReader())
                {
                    if (readId.Read())
                    {
                        totalId = readId.GetInt32(0);
                    }
                }

                return totalId + 1;
            }
        }

    }
}
