using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public TimeSlot(string minutes, string guests, string start, string end, string first)
        {
            slotLength = Convert.ToInt32(minutes);
            numGuests = Convert.ToInt32(guests);
            startTime = Convert.ToDateTime(start);
            endTime = Convert.ToDateTime(end);
            firstTicket = Convert.ToInt32(first);
            lastTicket = firstTicket + (numGuests - 1);
            //ticketsIssued = tickets;
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
            ticketsIssued = ticketsIssued + 1;
        }
    }
}
