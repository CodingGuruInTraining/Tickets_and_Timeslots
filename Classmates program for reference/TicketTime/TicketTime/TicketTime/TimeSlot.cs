using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketTime
{
    public class TimeSlot                   // Creating the TimeSlot class
    {
        private string startTime;           // Creating the fields
        private string endTime;
        private string minPerWin;
        private string ticketIssued;
        private string guestPerWin;

        public TimeSlot() { }               // An empty constructor

        public TimeSlot(string startTime, string endTime, string minPerWin, string ticketIssued, string guestPerWin)
        {                                   // Custom Constructor for the time and ticket
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.MinPerWin = minPerWin;
            this.TicketIssued = ticketIssued;
            this.GuestPerWin = guestPerWin;
        }

        public string StartTime             // The property code for the fields
        {
            get { return startTime; }       // Getting and returning the start time
            set { startTime = value; }
        }
        public string EndTime
        {
            get { return endTime; }         // Getting and returning the end time
            set { endTime = value; }
        }
        public string MinPerWin
        {
            get { return minPerWin; }       // Getting and returning the minute per window
            set { minPerWin = value; }
        }
        public string TicketIssued
        {
            get { return ticketIssued; }    // Getting and returning the ticket 
            set { ticketIssued = value; }
        }
        public string GuestPerWin           // Getting and returning the number of guest per window
        {
            get { return guestPerWin; }
            set { guestPerWin = value; }
        }


        public string[] TimeList()          // Putting all vaules into the correct text box
        {
            string[] time  = { StartTime, EndTime, MinPerWin, TicketIssued, GuestPerWin };
            return time;
        }
     
    }
}
