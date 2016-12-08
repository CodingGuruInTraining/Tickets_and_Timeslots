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

        public frmTickets()
        {
            InitializeComponent();
            timerTitle.Enabled = true;
            
            List<TimeSlot> allTimeSlots = new List<TimeSlot>();
        }

        private void timerTicking(object sender, EventArgs e)
        {
            DateTime timeVar = DateTime.Now;
            this.Text = timeVar.ToLongTimeString();
            
            //while (true)
            //{

            //}      
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            timerTitle.Stop();
            this.Close();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {


            Ticket ticket = new Ticket();
            timeSlot.addTicket();
            lblOutstandTicks.Text = timeSlot.ticketsIssued.ToString();
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            DialogResult warningMsg = MessageBox.Show("WARNING; all outstanding tickets will be terminated should you continue. Would you like to continue?", "WARNING", MessageBoxButtons.YesNo);
            if (warningMsg == DialogResult.Yes)
            {
                // clear listbox listbox.items.clear()
                frmOpt.ShowDialog();
                timeSlot = new TimeSlot(frmOpt.optsList[0], frmOpt.optsList[1], frmOpt.optsList[2], frmOpt.optsList[3], frmOpt.optsList[4]);
                lblGuests.Text = timeSlot.firstTicket.ToString() + " - " + timeSlot.lastTicket.ToString();
                //lblOutstandTicks.Text = lboxTickets.Items.Count.ToString();
                lblNextSlot.Text = (timeSlot.startTime.AddMinutes(timeSlot.slotLength)).ToShortTimeString();
            }
        }
    }
}
// TO DO STILL:
//      get options form to start first
//      intantiate ticket class
//      add ticket to listbox
//      check if open or closed (available tickets?)
