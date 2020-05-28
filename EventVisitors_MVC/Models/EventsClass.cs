﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventVisitors_MVC.Models
{
    public class EventsClass
    {
        public int Event_id { get; set; }

        public string Event_Name { get; set; }

        public bool Event_Active { get; set; }

        public int Event_Arranger_Id { get; set; }

        public bool Event_Seeking_Volunteers { get; set; }

        public int Event_Location_Id { get; set; }

        public string Event_Category_Name { get; set; }

        public string Event_Description { get; set; }

        public string Event_Imagelink { get; set; }

        public int Event_Ticket_Price { get; set; }

        public string Event_Start_Datetime { get; set; }

        public string Event_End_Datetime { get; set; }

        public string Event_Create_Datetime { get; set; }

    }
}