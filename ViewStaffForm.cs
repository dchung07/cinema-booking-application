using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cinema_Booking_System
{
    public partial class ViewStaffForm : Form
    {
        public Form adminForm { get; set; }

        public ViewStaffForm()
        {
            InitializeComponent();
        }

        private void ViewStaffForm_Load(object sender, EventArgs e)
        {
            //for button enabling/disabling
            staffTbl.SelectionChanged += staffTbl_SelectionChanged;

            // Staff.txt data format:
            // Three columns separated by tab character:
            // Column 0 is ID
            // Column 1 is First Name
            // Column 2 is Last Name
            // Column 3 is Email
            // Column 4 is Phone

            string[] lines = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), "Staff.txt"));

            // adding info from txtfile into DataGridView
            foreach (string line in lines)
            {
                string[] data = line.Split('\t');
                staffTbl.Rows.Add(data);
            }
        }

        private void addStaffBtn_Click(object sender, EventArgs e)
        {
            var addStaffForm = new AddStaffForm();
            addStaffForm.viewStaffForm = this;
            addStaffForm.Show();
        }

        private void manageStaffBtn_Click(object sender, EventArgs e)
        {
            //populating the text fields with selected staff
            if (staffTbl.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = staffTbl.SelectedRows[0];
                String id = selectedRow.Cells[0].Value.ToString();
                String firstName = selectedRow.Cells[1].Value.ToString();
                String lastName = selectedRow.Cells[2].Value.ToString();
                String email = selectedRow.Cells[3].Value.ToString();
                String phone = selectedRow.Cells[4].Value.ToString();

                var manageStaffForm = new ManageStaffForm();
                manageStaffForm.viewStaffForm = this;
                manageStaffForm.PopulateFields(id, firstName, lastName, email, phone);
                manageStaffForm.Show();
            }
        }

        private void deleteStaffBtn_Click(object sender, EventArgs e)
        {
            if (staffTbl.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = staffTbl.SelectedRows[0];
                String staffToDelete = selectedRow.Cells[0].Value.ToString();

                //remove staff from file
                string[] lines = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), "Staff.txt"));
                List<string> newLines = new List<string>();

                foreach (string line in lines)
                {
                    string[] data = line.Split('\t');
                    if (data[0] != staffToDelete)
                    {
                        newLines.Add(line);
                    }
                }

                File.WriteAllLines(Path.Combine(Directory.GetCurrentDirectory(), "Staff.txt"), newLines);

                //remove staff from table
                staffTbl.Rows.Remove(selectedRow);
            }

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.adminForm.Show();
            this.Close();
        }

        public DataGridView GetStaffTable()
        {
            return staffTbl;
        }

        public void UpdateStaffTbl(String id, String firstName, String lastName, String email, String phone)
        {
            foreach (DataGridViewRow row in staffTbl.Rows) {
                if (id == row.Cells[0].Value.ToString())
                {
                    row.Cells[1].Value = firstName;
                    row.Cells[2].Value = lastName;
                    row.Cells[3].Value = email;
                    row.Cells[4].Value = phone;
                    break;
                }
            }
        }

        //to make the delete button enabled only when a row is selected to avoid error
        private void staffTbl_SelectionChanged(object sender, EventArgs args)
        {
            manageStaffBtn.Enabled = staffTbl.SelectedRows.Count > 0;
            deleteStaffBtn.Enabled = staffTbl.SelectedRows.Count > 0;
        }

    }
}
