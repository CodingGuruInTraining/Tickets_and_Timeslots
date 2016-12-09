using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project_12_2_Tickets_With_Timeslots
{
    public class Ticket
    {
        public int ticketNum;
        public DateTime slotTime;
        public string ticketText;

        public Ticket(DateTime start, int number)
        {
            ticketNum = number;
            slotTime = start;
            ticketText = "Ticket " + (ticketNum).ToString() + ": " + (slotTime).ToShortTimeString();
            //int num = frmOptions.Minutes;
            //frmOptions.Minutes.


        }
    }
}
