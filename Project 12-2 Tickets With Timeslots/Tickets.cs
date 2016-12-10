using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_12_2_Tickets_With_Timeslots
{ 
    public partial class frmTickets : Form
    {
        frmOptions frmOpt = new frmOptions();
        TimeSlot timeSlot;
        List<TimeSlot> allTimeSlots;

        public frmTickets()
        {
            InitializeComponent();
            timerTitle.Enabled = true;
            
            allTimeSlots = new List<TimeSlot>();
        }

        private void timerTicking(object sender, EventArgs e)
        {
            DateTime timeVar = DateTime.Now;
            string status = "";
            if (timeSlot != null)
            {
                //if (timeSlot.startTime > DateTime.Now)
                //{
                //    status = " [OPEN]";
                //    if (timeSlot.startTime < timeSlot.startTime.AddMinutes(timeSlot.slotLength))
                //        lblGuests.Text = timeSlot.firstTicket.ToString() + " - " + timeSlot.lastTicket.ToString();
                //}
                //else
                //    status = " [CLOSED]";
            }
            this.Text = timeVar.ToLongTimeString() + status;    
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            timerTitle.Stop();
            this.Close();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (timeSlot.ticketsIssued == timeSlot.numGuests)
            {
                // Recursion:?
                makeTimeSlot();
                //timeSlot = new TimeSlot(frmOpt.optsList[0], frmOpt.optsList[1], timeSlot.EndTime.ToString(), frmOpt.optsList[3], (timeSlot.lastTicket + 1).ToString(), timeSlot.outstandingTickets);
                //updateLabels(timeSlot);
            }
            //else if (timeSlot.ticketsIssued < timeSlot.numGuests)
            //{

            //}

            Ticket aticket = new Ticket(timeSlot.startTime, timeSlot.firstTicket + timeSlot.ticketsIssued);
            timeSlot.addTicket();
            lblOutstandTicks.Text = timeSlot.outstandingTickets.ToString();
            lboxTickets.Items.Add(aticket.ticketText);
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            DialogResult warningMsg = MessageBox.Show("WARNING; all outstanding tickets will be terminated should you continue. Would you like to continue?", "WARNING", MessageBoxButtons.YesNo);
            if (warningMsg == DialogResult.Yes)
            {
                timeSlot.clearFields(lboxTickets);
                // clear listbox listbox.items.clear()
                frmOpt.ShowDialog();
                makeTimeSlot();
            }
        }

        private void updateLabels(TimeSlot timeslot)
        {
            allTimeSlots.Add(timeslot);
            lblGuests.Text = timeslot.firstTicket.ToString() + " - " + timeslot.lastTicket.ToString();
            lblNextSlot.Text = (timeslot.startTime.AddMinutes(timeslot.slotLength)).ToShortTimeString();
            lblOutstandTicks.Text = timeslot.outstandingTickets.ToString();
        }
        private void makeTimeSlot()
        {
            int outstandingTickets = 0;
            timeSlot = new TimeSlot(frmOpt.optsList[0], frmOpt.optsList[1], frmOpt.optsList[2], frmOpt.optsList[3], frmOpt.optsList[4], outstandingTickets);
            updateLabels(timeSlot);
        }
        private void frmTickets_Load(object sender, EventArgs e)
        {
            frmOpt = new frmOptions();
            frmOpt.ShowDialog();
            makeTimeSlot();
        }
    }
}
// TO DO STILL:



//      check if open or closed (available tickets?)
//      guests label needs to go off something else, separately
//      counts and stuff don't reset when go back to options form
//      next available entry label not reseting
//          use startStart as initial time?
