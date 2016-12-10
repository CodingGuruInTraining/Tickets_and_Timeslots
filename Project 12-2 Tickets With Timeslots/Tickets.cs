// This program acts as a ticket dispenser that utilizes multiple
// classes to track specific information and display it correctly.
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
        // Creates Options form and declares timeslot variable
        frmOptions frmOpt = new frmOptions();
        TimeSlot timeSlot;
        List<TimeSlot> allTimeSlots;

        public frmTickets()
        {
            InitializeComponent();
            // Starts timer
            timerTitle.Enabled = true;
            // Creates list for timeslot objects
            allTimeSlots = new List<TimeSlot>();
        }

        private void timerTicking(object sender, EventArgs e)
        {
            // Gets current time and displays in form's text property
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
            // Stops timer and closes application.
            timerTitle.Stop();
            this.Close();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            // First checks if it is time for a new timeslot and instantiates one if so
            if (timeSlot.ticketsIssued == timeSlot.numGuests)
            {
                makeTimeSlot();
                //timeSlot = new TimeSlot(frmOpt.optsList[0], frmOpt.optsList[1], timeSlot.EndTime.ToString(), frmOpt.optsList[3], (timeSlot.lastTicket + 1).ToString(), timeSlot.outstandingTickets);
                //updateLabels(timeSlot);
            }
            //else if (timeSlot.ticketsIssued < timeSlot.numGuests)
            //{

            //}
            // Creates new ticket object with latest timeslot object's info
            Ticket aticket = new Ticket(timeSlot.startTime, timeSlot.firstTicket + timeSlot.ticketsIssued);
            // Increases accumulator variable,  updates label info, and adds to listbox
            timeSlot.addTicket();
            lblOutstandTicks.Text = timeSlot.outstandingTickets.ToString();
            lboxTickets.Items.Add(aticket.ticketText);
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            // Warns user they will be resetting data if they continue
            DialogResult warningMsg = MessageBox.Show("WARNING; all outstanding tickets will be terminated should you continue. Would you like to continue?", "WARNING", MessageBoxButtons.YesNo);
            if (warningMsg == DialogResult.Yes)
            {
                // Clears/resets data, presents Options form, and creates timeslot object
                timeSlot.clearFields(lboxTickets);
                frmOpt.ShowDialog();
                makeTimeSlot();
            }
        }

        private void updateLabels(TimeSlot timeslot)
        {
            // Method for updating label's text property using provided timeslot object
            allTimeSlots.Add(timeslot);
            lblGuests.Text = timeslot.firstTicket.ToString() + " - " + timeslot.lastTicket.ToString();
            lblNextSlot.Text = (timeslot.startTime.AddMinutes(timeslot.slotLength)).ToShortTimeString();
            lblOutstandTicks.Text = timeslot.outstandingTickets.ToString();
        }
        private void makeTimeSlot()
        {
            // Instantiates new timeslot object
            int outstandingTickets = 0;
            timeSlot = new TimeSlot(frmOpt.optsList[0], frmOpt.optsList[1], frmOpt.optsList[2], frmOpt.optsList[3], frmOpt.optsList[4], outstandingTickets);
            updateLabels(timeSlot);
        }
        private void frmTickets_Load(object sender, EventArgs e)
        {
            // Loads options form and creates timeslot object
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
