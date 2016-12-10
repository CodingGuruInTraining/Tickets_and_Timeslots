// Class for storing info about individual ticket.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_12_2_Tickets_With_Timeslots
{
    public class Ticket
    {
        // Declares variables
        public int ticketNum;
        public DateTime slotTime;
        public string ticketText;

        public Ticket() { }
        // Default constructor

        public Ticket(DateTime start, int number)
        {
            // Constructor
            ticketNum = number;
            slotTime = start;
            // Creates string for listbox entry
            ticketText = "Ticket " + (ticketNum).ToString() + ": " + (slotTime).ToShortTimeString();
            //int num = frmOptions.Minutes;
            //frmOptions.Minutes.
        }
    }
}
