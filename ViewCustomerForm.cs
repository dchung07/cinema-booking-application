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
    public partial class ViewCustomerForm : Form
    {
        public Form adminForm { get; set; }
        public Form StaffForm { get; set; }
        public int staffFlag = 0;

        public ViewCustomerForm()
        {
            InitializeComponent();
        }

        private void ViewCustomerForm_Load(object sender, EventArgs e)
        {
            //for button enabling/disabling
            customerTbl.SelectionChanged += customerTbl_SelectionChanged;

            // Staff.txt data format:
            // Three columns separated by tab character:
            // Column 0 is ID
            // Column 1 is First Name
            // Column 2 is Last Name
            // Column 3 is Email
            // Column 4 is Phone
            // Column 5 is Points
            // Column 6 is Status

            string[] lines = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), "Customers.txt"));

            // adding info from txtfile into DataGridView
            foreach (string line in lines)
            {
                string[] data = line.Split('\t');
                customerTbl.Rows.Add(data);
            }
        }

        private void addCustomerBtn_Click(object sender, EventArgs e)
        {
            var addCustomerForm = new AddCustomerForm();
            addCustomerForm.viewCustomerForm = this;
            addCustomerForm.Show();
        }

        private void manageCustomerBtn_Click(object sender, EventArgs e)
        {
            if (customerTbl.Rows.Count > 0)
            {
                DataGridViewRow selectedRow = customerTbl.SelectedRows[0];
                String id = selectedRow.Cells[0].Value.ToString();
                String firstName = selectedRow.Cells[1].Value.ToString();
                String lastName = selectedRow.Cells[2].Value.ToString();
                String email = selectedRow.Cells[3].Value.ToString();
                String phone = selectedRow.Cells[4].Value.ToString();
                String points = selectedRow.Cells[5].Value.ToString();
                String status = selectedRow.Cells[6].Value.ToString();

                var manageCustomerForm = new ManageCustomerForm();
                manageCustomerForm.viewCustomerForm = this;
                manageCustomerForm.PopulateFields(id, firstName, lastName, email, phone, points, status);
                manageCustomerForm.Show();
            }
        }

        private void deleteCustomerBtn_Click(object sender, EventArgs e)
        {
            if (staffFlag == 1) {
                MessageBox.Show("Staff Members are not authorized to access this function. Please contact your Administrator to carry out this operation.");
                return;
            }

            if (customerTbl.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = customerTbl.SelectedRows[0];
                String customerToDelete = selectedRow.Cells[0].Value.ToString();

                //remove customer from file
                string[] lines = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), "Customers.txt"));
                List<string> newLines = new List<string>();

                foreach (string line in lines)
                {
                    string[] data = line.Split('\t');
                    if (data[0] != customerToDelete)
                    {
                        newLines.Add(line);
                    }
                }

                File.WriteAllLines(Path.Combine(Directory.GetCurrentDirectory(), "Customers.txt"), newLines);

                //remove customer from table
                customerTbl.Rows.Remove(selectedRow);
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            if (staffFlag == 1) {
                this.StaffForm.Show();
                this.Close();
                return;
            }
            this.adminForm.Show();
            this.Close();
        }

        public DataGridView GetCustomerTable()
        {
            return customerTbl;
        }
        public void UpdateCustomerTbl(String id, String firstName, String lastName, String email, String phone, String points, String status)
        {
            foreach (DataGridViewRow row in customerTbl.Rows)
            {
                if (id == row.Cells[0].Value.ToString())
                {
                    row.Cells[1].Value = firstName;
                    row.Cells[2].Value = lastName;
                    row.Cells[3].Value = email;
                    row.Cells[4].Value = phone;
                    row.Cells[5].Value = points;
                    row.Cells[6].Value = status;
                    break;
                }
            }
        }

        private void customerTbl_SelectionChanged(object sender, EventArgs args)
        {
            manageCustomerBtn.Enabled = customerTbl.SelectedRows.Count > 0;
            deleteCustomerBtn.Enabled = customerTbl.SelectedRows.Count > 0;
        }
    }
}
