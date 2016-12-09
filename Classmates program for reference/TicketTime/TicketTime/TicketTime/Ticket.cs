using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketTime
{
    class Ticket
    {
        public int ticketNum;
        public DateTime ticketSlot;

        public Ticket() { }
        public Ticket( int ticketNum, DateTime ticketSlot)
        {
            this.TicketNum = ticketNum;
            this.TicketSlot = ticketSlot;
        }

        public int TicketNum
        {
            get { return ticketNum; }
            set { ticketNum = value; }
        }
        public DateTime TicketSlot
        {
            get { return ticketSlot; }
            set { ticketSlot = value; }
        }
        public int nextTicket(int ticketNum)
        {
            TicketNum++;
            return TicketNum;
        }

        public void removeTicket()
        {
            
        }

        public string displayTicket()
        {
            string ticketString = TicketNum.ToString() + ": " + String.Format("{0:t}", TicketSlot);
            return ticketString;
        }
    }
}
