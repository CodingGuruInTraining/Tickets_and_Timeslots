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
    public partial class Form1 : Form
    {
        private Form2 form2 = new Form2();
        public Timer timer = new Timer();
        Ticket ticket = new Ticket();
        string[] listPass;
        DateTime startTime;
        DateTime endTime;
        DateTime ticketTime;
        int guestWinConst;
        int minPerWin;
        int firstTicket;
        int guestPerWin;
        int guestConst;
        public Form1()
        {
            InitializeComponent();
        }

      
        int Ticketcount = 0;
        DialogResult msgResult;
        

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            msgResult = MessageBox.Show("Selecting Ok will delete all outstanding tickets","Warning", MessageBoxButtons.OKCancel);
            
            if (msgResult == DialogResult.OK)
            {
                listBox1.Items.Clear();                
                form2.ShowDialog();
                listPass = form2.timelist;
                minPerWin = Convert.ToInt32(listPass[2]);
                startTime = Convert.ToDateTime(listPass[0]).AddMinutes(minPerWin);
                ticketTime = startTime;
                endTime = Convert.ToDateTime(listPass[1]);
                firstTicket = Convert.ToInt32(listPass[3]);
                Ticketcount = firstTicket - 1;
                guestPerWin = Convert.ToInt32(listPass[4]);
                guestWinConst = guestPerWin;
                guestConst = Convert.ToInt32(listPass[4]);
                lblGuestWin.Text = Convert.ToString(firstTicket) + " - " + Convert.ToString(guestPerWin);
                lblEntryTime.Text = String.Format("{0:t}", startTime);
            }
        }
        private void btnIssueTicket_Click(object sender, EventArgs e)
        {
            if (Ticketcount == guestWinConst)
            {
                guestWinConst += guestConst;
                ticketTime = ticketTime.AddMinutes(minPerWin);
                lblEntryTime.Text = String.Format("{0:t}", ticketTime);

            }
            Ticketcount++;
            ticket = new Ticket(Ticketcount, ticketTime);
            DateTime currentDateTime = DateTime.Now;
            listBox1.Items.Add("Ticket " + ticket.displayTicket());
            lblGuestTicket.Text = Convert.ToString(listBox1.Items.Count);
        }
           
        private void displayTime(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            string timeNow = String.Format("{0:t}", currentTime);
            this.Text = String.Format("{0:T}", currentTime);
            if (timeNow == String.Format("{0:t}", startTime))
            {
                for (int index = listBox1.Items.Count - 1; index >= 0; --index)
                {
                    string removeTicket = String.Format("{0:t}", startTime);
                    if (listBox1.Items[index].ToString().Contains(removeTicket))
                    {
                        listBox1.Items.RemoveAt(index);
                        lblGuestTicket.Text = Convert.ToString(listBox1.Items.Count);
                    }
                }

                firstTicket = guestPerWin + 1;
                guestPerWin += guestConst;
                startTime = startTime.AddMinutes(minPerWin);
                //lblEntryTime.Text = String.Format("{0:t}", startTime);
                lblGuestWin.Text = Convert.ToString(firstTicket) + " - " + Convert.ToString(guestPerWin);
                
            }
            

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Interval = 1000;
            timer.Tick += new EventHandler(displayTime);
            form2 = new Form2(timer);
            form2.ShowDialog();
            listPass = form2.timelist;
            minPerWin = Convert.ToInt32(listPass[2]);
            startTime = Convert.ToDateTime(listPass[0]).AddMinutes(minPerWin);
            ticketTime = startTime;
            endTime = Convert.ToDateTime(listPass[1]);
            firstTicket = Convert.ToInt32(listPass[3]);
            Ticketcount = firstTicket - 1;
            guestPerWin = Convert.ToInt32(listPass[4]);
            guestWinConst = guestPerWin;
            guestConst = Convert.ToInt32(listPass[4]);
            lblGuestWin.Text = Convert.ToString(firstTicket) + " - " + Convert.ToString(guestPerWin);
            lblEntryTime.Text = String.Format("{0:t}", startTime);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

    }
}
