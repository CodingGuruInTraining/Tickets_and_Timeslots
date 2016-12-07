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
        public frmTickets()
        {
            InitializeComponent();
            timerTitle.Enabled = true;
            List<TimeSlot> allTimeSlots = new List<TimeSlot>();
        }

        private void timerTicking(object sender, EventArgs e)
        {
            DateTime timeVar = DateTime.Now;
            this.Text = timeVar.ToString();
            while (true)
            {

            }      
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            timerTitle.Stop();
            this.Close();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            Ticket ticket = new Ticket();
        }
    }
}
