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
    public partial class PurchaseForm : Form
    {

        //Change the file path to a full path in this file if relative does not work as intended
        public string CustomerFormId { get; set; }
        private string movieName;
        private string moviePrice;
        private string customerRank;

        private string customerId;
        private int totalDiscountedPrice;
        private int quantity;

        public PurchaseForm(string movieName, string moviePrice, string customerId)
        {
            InitializeComponent();
            this.movieName = movieName;
            purchaseFormTitleLabel.Text = "Purchase Ticket(s) for " + movieName;
            this.moviePrice = moviePrice;
            this.customerId = customerId;
            singleTicketPrice.Text = "$" + moviePrice;
            string customerData = GetCustomerDataById("Customers.txt", customerId);



            if (customerData != null)
            {
                string[] segment = customerData.Split('\t');
                if (segment.Length >= 6)
                {
                    string id = segment[0];
                    string firstName = segment[1];
                    string lastName = segment[2];
                    string email = segment[3];
                    string phone = segment[4];
                    string points = segment[5];
                    string status = segment[6];

                    customerRank = status;
                    rankDiscountStatusLabel.Text = "Your current Member Rank is: " + status;
                }
            }

            else
            {

            }


            selectQuantityTicketsBox.SelectedIndexChanged += SelectQuantityTicketsBox_SelectedIndexChanged;


            UpdateTicketPrice();
        }

        private string GetCustomerDataById(string customersFilePath, string userId)
        {

            string[] segments = File.ReadAllLines(customersFilePath);

            foreach (string s in segments)
            {
                string[] segment = s.Split('\t');

                if (segment.Length >= 6 && segment[0] == userId)
                {
                    return s;
                }
            }



            return null;
        }


        private void SelectQuantityTicketsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Whenever the combo box (ticket quantity) is changed, we should update the ticket price accordingly
            UpdateTicketPrice();
        }


        private void UpdateTicketPrice()
        {

            int moviePriceInt = int.Parse(moviePrice);
            if (selectQuantityTicketsBox.SelectedItem != null)
            {

                //Need to turn the TextBox's selected Items text and then turn it into string so we can use it for the discount formula
                quantity = int.Parse(selectQuantityTicketsBox.SelectedItem.ToString());
                int totalPrice = moviePriceInt * quantity;
                ticketPriceLabel.Text = selectQuantityTicketsBox.Text + " x $" + moviePrice + " = $" + totalPrice;

                int originalPrice = int.Parse(moviePrice);
                string rank = customerRank;
                int discount = 0;

                //Depending on the status/rank of the customer they are given a discount ranging from a dollar to two dollars

                if (rank == "Bronze")
                {
                    discount = 0;
                }
                else if (rank == "Silver")
                {
                    discount = 1;
                }
                else if (rank == "Gold")
                {
                    discount = 2;
                }

                //Discount formula

                int discountedPrice = originalPrice - discount;
                totalDiscountedPrice = discountedPrice * quantity;


                discountedPriceLabel.Text = selectQuantityTicketsBox.Text + " x $" + discountedPrice + " = $" + totalDiscountedPrice;

            }
            else
            {


            }
        }

        private void ticketPriceLabel_Click(object sender, EventArgs e)
        {

        }

        private void purchaseTicketCancelButton_Click(object sender, EventArgs e)
        {
            MovieBookingForm movieBookingForm = new MovieBookingForm();
            movieBookingForm.Show();
            this.Close();
        }

        private void purchaseTicketConfirmButton_Click(object sender, EventArgs e)
        {
            //Add id, movie name to bookings.txt + session time/day) add that to purchase form design!



            string cId = customerId;
            int ticketQuantity = quantity;
            string ticketQuantityString = ticketQuantity.ToString();
            string movieNameString = movieName;

            string bookingData = $"{movieNameString};{cId};{ticketQuantityString}";

            string bookingsFilePath = Path.Combine(Directory.GetCurrentDirectory(), "Bookings.txt");

            File.AppendAllText(bookingsFilePath, bookingData + Environment.NewLine);



            int additionalPoints = ticketQuantity * 100;

            string[] lines = File.ReadAllLines("Customers.txt");

            string updatedLine = null;
            for (int i = 0; i < lines.Length; i++)
            {
                string[] fields = lines[i].Split('\t');
                if (fields.Length >= 7 && fields[0] == cId)
                {

                    int currentPoints = int.Parse(fields[5]);
                    int newPoints = currentPoints + additionalPoints;
                    fields[5] = newPoints.ToString();
                    string rank;

                    if (newPoints >= 0 && newPoints <= 100)
                    {
                        rank = "Bronze";
                    }
                    else if (newPoints > 100 && newPoints <= 200)
                    {
                        rank = "Silver";
                    }
                    else if (newPoints > 200)
                    {
                        rank = "Gold";
                    }
                    else
                    {
                        rank = "Bronze";
                    }

                    fields[6] = rank;

                    updatedLine = string.Join("\t", fields);
                    lines[i] = updatedLine;
                    break;
                }
            }

            if (updatedLine != null)
            {
                File.WriteAllLines("Customers.txt", lines);
            }
            else
            {

            }

            MessageBox.Show("Purchase Confirmed!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MovieBookingForm movieBookingForm = new MovieBookingForm();
            movieBookingForm.Show();
            this.Close();

        }

        private void selectQuantityTicketsBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
