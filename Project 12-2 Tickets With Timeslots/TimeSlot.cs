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
        public int slotLength;
        public int numGuests;
        public DateTime startTime;
        private DateTime endTime;
        public int firstTicket;
        public int ticketsIssued;
        public int lastTicket;
        public int outstandingTickets;

        public TimeSlot(string minutes, string guests, string start, string end, string first, int total)
        {
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
            get
            {
                return startTime.AddMinutes((double)slotLength);
            }
        }

        public void addTicket()
        {
            ticketsIssued += 1;
            outstandingTickets += 1;
        }

        //public void addToTotal(int issued)
        //{
        //    outstandingTickets += issued;
        //}

        public void clearFields(ListBox lbox)
        {
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
