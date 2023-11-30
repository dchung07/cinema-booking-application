using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_Booking_System
{
    public partial class AddCustomerForm : Form
    {
        public Form viewCustomerForm { get; set; }

        public AddCustomerForm()
        {
            InitializeComponent();
        }

        private void AddCustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            String id = customerID.Text;
            String firstName = customerFirstName.Text;
            String lastName = customerLastName.Text;
            String email = customerEmail.Text;
            String phone = customerPhone.Text;
            String points = customerPoints.Text;
            String status = customerStatus.Text;

            string customerData = $"{id}\t{firstName}\t{lastName}\t{email}\t{phone}\t{points}\t{status}";

            List<string> lines = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), "Customers.txt")).ToList();
            lines.Add(customerData);
            File.WriteAllLines(Path.Combine(Directory.GetCurrentDirectory(), "Customers.txt"), lines);

            /*File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), "Customers.txt"), customerData);*/

            //generate random password for newly added customer
            String password = GeneratePassword();

            //add to Credentials txt file
            string credentials = $"{id}\t{password}\tC";

            List<string> credLines = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), "Credentials.txt")).ToList();
            credLines.Add(credentials);
            File.WriteAllLines(Path.Combine(Directory.GetCurrentDirectory(), "Credentials.txt"), credLines);

            /*File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), "Credentials.txt"), credentials);*/

            this.Close();

            if (viewCustomerForm is ViewCustomerForm customerForm)
            {
                DataGridView customerTable = customerForm.GetCustomerTable();
                customerTable.Rows.Add(id, firstName, lastName, email, phone, points, status);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private String GeneratePassword()
        {
            String availableChars = "abcdefghijklmnopqrstuvwxyz0123456789";
            StringBuilder password = new StringBuilder();
            Random random = new Random();

            for (int i = 0; i < 6; i++)
            {
                password.Append(availableChars[random.Next(availableChars.Length)]);
            }

            return password.ToString();
        }
    }
}
