// Class for storing info about ticket uses and time intervals.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_12_2_Tickets_With_Timeslots
{
    public class TimeSlot
    {
        // Declares variables
        public int slotLength;
        public int numGuests;
        private string startStartTime;
        public DateTime startTime;
        private DateTime endTime;
        public int firstTicket;
        public int ticketsIssued;
        public int lastTicket;
        public int outstandingTickets;

        
        public TimeSlot() {}
        // Default constructor

        public TimeSlot(string minutes, string guests, string start, string end, string first, int total)
        {
            // Constructor
            slotLength = Convert.ToInt32(minutes);
            numGuests = Convert.ToInt32(guests);
            startTime = Convert.ToDateTime(start);
            endTime = Convert.ToDateTime(end);
            firstTicket = Convert.ToInt32(first);
            lastTicket = firstTicket + (numGuests - 1);
            outstandingTickets = total;
        }

        public DateTime EndTime
        {
            // Getter
            get
            {
                return startTime.AddMinutes((double)slotLength);
            }
        }

        public string  StartStartTime
        {
            // Setter
            set
            {
                startStartTime = value;
            }
        }

        public void addTicket()
        {
            // Method for incrementing accumulators
            ticketsIssued += 1;
            outstandingTickets += 1;
        }

        //public void addToTotal(int issued)
        //{
        //    outstandingTickets += issued;
        //}

        public void clearFields(ListBox lbox)
        {
            // Method for reseting values
            lbox.Items.Clear();
            firstTicket = 0;
            lastTicket = 0;
            outstandingTickets = 0;
            startTime = default(DateTime);
            endTime = default(DateTime);
            ticketsIssued = 0;
            numGuests = 0;
        }
    }
}
