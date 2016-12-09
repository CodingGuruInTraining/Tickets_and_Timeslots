using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TicketTime
{
    public partial class Form2 : Form
    {
       // private Form1 form1 = new Form1();
        public Form2()
        {
            InitializeComponent();
        }

        private Timer timerPass;
        public Form2(Timer timer) : this()
        {
            this.timerPass = timer;
        }
        DateTime defaultStart = DateTime.Now;
        public int MinPerWin = 0;
        public string StartTime = "";
        public int GuestsPerWin = 0;
        public string EndTime = "";
        public int FirstTicket = 0;
        public string[] timelist;
        public void btnOK_Click(object sender, EventArgs e)
        {
            if (validation() == true)
            {
                MinPerWin = Convert.ToInt32(txtBoxMinPerWin.Text);
                StartTime = txtBoxStartTime.Text;
                EndTime = txtBoxEndTime.Text;
                GuestsPerWin = Convert.ToInt32(txtBoxGuesterWin.Text);
                FirstTicket = Convert.ToInt32(txtBoxFirstTicket.Text);
                TimeSlot timeslot = new TimeSlot(txtBoxStartTime.Text, txtBoxEndTime.Text, txtBoxMinPerWin.Text, txtBoxFirstTicket.Text, txtBoxGuesterWin.Text);
                timelist = timeslot.TimeList();
                timerPass.Start();
                this.Close();
            }
            
        }
        //public TimeSlot(string startTime, string endTime, string minPerWin, string ticketIssued, string guestPerWin)
    
        private void Form2_Load(object sender, EventArgs e)
        {
            
            txtBoxStartTime.Text = defaultStart.ToShortTimeString();
            DateTime defaultEnd = defaultStart.AddHours(4);
            txtBoxEndTime.Text = defaultEnd.ToShortTimeString();
        }

        private bool validation()
        {
            if (Validation.IsPresent(txtBoxStartTime, "Start Time") &&
             Validation.IsPresent(txtBoxEndTime, "End Time") &&
             Validation.IsPresent(txtBoxFirstTicket, "First Ticket Number") &&
             Validation.IsPresent(txtBoxGuesterWin, "Guests Per Window") &&
             Validation.IsPresent(txtBoxMinPerWin, "Minute Per Window") &&
             Validation.IsDateFormat(txtBoxStartTime, "Start Time") &&
             Validation.IsDateFormat(txtBoxEndTime, "End Time") &&
             Validation.IsInt(txtBoxMinPerWin, "Minute Per Window") &&
             Validation.IsInt(txtBoxGuesterWin, "Guest Per Window") &&
             Validation.IsInt(txtBoxFirstTicket, "First Ticket Number"))
            {
                return true;
            }
            else
                return false;
        }
    }
}
