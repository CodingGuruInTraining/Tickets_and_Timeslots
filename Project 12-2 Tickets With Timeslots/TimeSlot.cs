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
        public DateTime startTime;
        //private DateTime endTime;
        public int ticketsIssued;

        public TimeSlot(DateTime time, int length, int tickets = 0)
        {
            startTime = time;
            slotLength = length;
            ticketsIssued = tickets;
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
