// University of Technology Sydney Spring Session 2023
// 31927 - Application Development With .NET
//
// Assignment 2: Windows Forms Application
// Cinema Booking System - Cinema Class Definitions
//
// Written by Justin Widjaya - 13602091,  
//            David Chung - 14288397,
//            Rosa Long - 98137351
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema_Booking_System {
    
    public class Booking {
        public String userId;
        public Dictionary<String, Dictionary<String, int>> session { get; set; }
    }

    public class Comment {
        public String userId;
        public String comment;

        public Comment(String id, String comment) {
            userId = id;
            this.comment = comment;
        }
    }

    public class Movie {

        public String title { get; set; }
        public String genre { get; set; }
        public String runTime { get; set; }

        public String price { get; set; }
        
        // session is dictionary containing (sessionDay and sessionTimes(time and capacity))
        public Dictionary<String, Dictionary<String, int>> session { get; set; }
    }
}
