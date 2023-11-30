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
    public partial class ManagePasswordForm : Form
    {
        public Form adminForm { get; set; }

        public ManagePasswordForm()
        {
            InitializeComponent();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            String id = ID.Text;
            String changePassword = password.Text;

            string[] lines = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), "Credentials.txt"));
            List<string> newLines = new List<string>();
            bool idExists = false;

            foreach (string line in lines)
            {
                string[] info = line.Split('\t');

                if (info[0] == id && info.Length >= 2)
                {
                    // Update information
                    idExists = true;
                    info[1] = changePassword;
                }
                string updatedLogin = string.Join("\t", info);
                newLines.Add(updatedLogin);
            }

            if (idExists)
            {
                File.WriteAllLines(Path.Combine(Directory.GetCurrentDirectory(), "Credentials.txt"), newLines);
                MessageBox.Show("Password updated successfully.");
                this.Close();
            }
            else
            {
                MessageBox.Show("ID does not exist.\nPlease try again.");
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
