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
        public class Customer
        {
            public string FirstName { get; set; }
            public string SecondName { get; set; }
            public string ThirdName { get; set; }
            public string PhoneNumber { get; set; }
            public string Fax { get; set; }
            public string Email { get; set; }
            public string Address { get; set; }
            public int Age { get; set; }
            public string Sex { get; set; }

            public Customer(string firstName, string secondName, string thirdName, string phoneNumber, string fax, string email, string address, int age, string sex)
            {
                FirstName = firstName;
                SecondName = secondName;
                ThirdName = thirdName;
                PhoneNumber = phoneNumber;
                Fax = fax;
                Email = email;
                Address = address;
                Age = age;
                Sex = sex;
            }
        }

        public void updateData()
        {
            List<Customer> customerList = new List<Customer>();
            MySqlCommand getNames = new MySqlCommand("SELECT * FROM customers", Database.Connections.db.connection);
            using (MySqlDataReader readNames = getNames.ExecuteReader())
            {
                while (readNames.Read())
                {
                    Customer customer = new Customer(
                        readNames.GetString(0),
                        readNames.GetString(1),
                        readNames.GetString(2),
                        readNames.GetString(3),
                        readNames.GetString(4),
                        readNames.GetString(5),
                        readNames.GetString(6),
                        readNames.GetInt32(7),
                        readNames.GetString(8));
                    customerList.Add(customer);
                }
            }

            foreach (Customer customer in customerList)
            {
                this.customers.Rows.Add(
                    customer.FirstName,
                    customer.SecondName,
                    customer.ThirdName,
                    customer.PhoneNumber,
                    customer.Fax,
                    customer.Email,
                    customer.Address,
                    customer.Age,
                    customer.Sex);
            }
        }



        private void getCustomers_Click(object sender, EventArgs e)
        {
            customers.Visible = true;
        }


        private void insertCustomers_Click(object sender, EventArgs e)
        {
            addCustomer customerAdd = new addCustomer();
            customerAdd.ShowDialog();
        }
    }
}
