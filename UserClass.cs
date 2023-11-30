// University of Technology Sydney Spring Session 2023
// 31927 - Application Development With .NET
//
// Assignment 2: Windows Forms Application
// Cinema Booking System - User Class Definitions
//
// Written by Justin Widjaya - 13602091,  
//            David Chung - 14288397,
//            Rosa Long - 98137351
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Cinema_Booking_System {
    public class User {
        // Fields
        public String id { get; set; } // Unique ID
        public String type { get; set; } // Single Character denoting user type (C, S, A) -> (Customer, Staff, Admin)
        public String userName { get; set; } // username used for login
        public String firstName { get; set; }
        public String lastName { get; set; }
        public String email { get; set; }
        public String password { get; set; }
        public String phone { get; set; }
    }

    public class Customer : User {
        public String rank { get; set; } // Single character denoting vip status (X, B, S, G) -> (none, Bronze, Silver, Gold)
        public int points { get; set; }
        // public Array<Bookings> bookings { get; set; }

        // Constructor with read and write capability for Customers.txt and Credentials.txt
        public Customer() {
            // Opens Customer List and finds largest ID
            // Adds 1 to number at the end for new ID
            string line = "";
            StreamReader r = File.OpenText(Path.Combine(Directory.GetCurrentDirectory(), "Customers.txt"));

            int nextID = -1;

            while ((line = r.ReadLine()) != null) {
                string[] data = line.Split('\t');

                if (data[0].Length >= 8)
                {
                    nextID = Convert.ToInt32(data[0].Substring(8)) + 1;
                }
                else
                {
                }
            }
            r.Close();

            if (nextID == -1) {
                nextID++;
            }
            id = "CUSTOMER" + nextID;

            points = 0;

            // Adds Customer information to Customers.txt file
            // Assuming spaces are tabs, format is:
            // id type username firstname lastname email password phone vipstatus points
            StreamWriter w = File.AppendText(Path.Combine(Directory.GetCurrentDirectory(), "Customers.txt"));
            w.WriteLine($"{id}\t{type}\t{userName}\t{firstName}\t{lastName}\t{email}\t{password}\t{phone}\t{rank}\t{points}\t");
            w.Close();

            // Adds Customer credentials to Credentials.txt file
            w = File.AppendText(Path.Combine(Directory.GetCurrentDirectory(), "Credentials.txt"));
            w.WriteLine($"{id}\t{password}\t{type}\t");
            w.Close();

            CalculateRank();
        }

        // Constructor for generation from file
        public Customer(StreamReader r, String id) {
            string line = "";

            while ((line = r.ReadLine()) != null) {
                string[] data = line.Split('\t');

                if (data[0] == id) {
                    this.id = id;
                    type = data[1];
                    userName = data[2];
                    firstName = data[3];
                    lastName = data[4];
                    email = data[5];
                    password = data[6];
                    phone = data[7];
                    rank = data[8];
                    points = Convert.ToInt32(data[9]);
                    return;
                }
            }
        }

        // public override string ToString() {
        // String name = FirstName + " " + LastName;
        // String address = StreetNumber + " " + Street + ", " + City + ", " + State;
        // return string.Format("{0,-20}|{1,-20}|{2,-30}|{3,-10}|{4,-30}", name, Doctor, Email, PhoneNumber, address);
        // }

        public void CalculateRank()
        {
            if (points >= 0 && points <= 100)
            {
                rank = "Bronze";
            }
            else if (points > 100 && points <= 200)
            {
                rank = "Silver";
            }
            else if (points > 200 && points <= 300)
            {
                rank = "Gold";
            }
            else
            {
                rank = "None";
            }
        }
    }


    public class Staff : User {

    }

    public class Admin : User {

    }
}
