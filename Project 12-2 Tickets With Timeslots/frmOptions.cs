﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Murach.Validation;

namespace Project_12_2_Tickets_With_Timeslots
{
    public partial class frmOptions : Form
    {
        public frmOptions()
        {
            InitializeComponent();
            txtMins.Text = (5).ToString();
            txtGuests.Text = (5).ToString();
            txtStart.Text = DateTime.Now.ToShortTimeString();
            txtEnd.Text = (DateTime.Now.AddHours(4)).ToShortTimeString();
            txtFirst.Text = (1).ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (goodDataCheck(txtMins, "The Minutes field", 1) && goodDataCheck(txtGuests, "The Number of Allowed Guests field", 1) && goodDataCheck(txtStart, "The Start Time", 2) && goodDataCheck(txtEnd, "The End Time", 2) && goodDataCheck(txtFirst, "The First Ticket Number field", 1))
                {

                }
            }
            catch (Exception)
            {
                MessageBox.Show("An unknown error has occurred");
            }
        }

        private bool goodDataCheck(TextBox textboxv, string namev, byte type)
        {   // type 1 = int; type 2 = datetime
            if (!isPresent(textboxv, namev))
            {
                //MessageBox.Show(namev + " is empty still");
                return false;
            }
            switch (type)
            {
                case 1:
                    if (!isInt(textboxv, namev))
                    {
                        //MessageBox.Show(namev + " is not an integer");
                        return false;
                    }
                    break;
                case 2:
                    DateTime datevalue;
                    if (!DateTime.TryParse(textboxv.Text, out datevalue))
                    {
                        MessageBox.Show(namev + " is not a valid time value");
                        return false;
                    }
                    break;
            }
            return true;
        }

        private bool isPresent(TextBox vtextbox, string vname)
        {
            // Checks if textbox is empty or not
            if (vtextbox.Text == "")
            {
                MessageBox.Show(vname + " is empty. Try again.", "Missing Entry");
                vtextbox.Focus();
                return false;
            }
            return true;
        }

        private bool isInt(TextBox vtextbox, string vname)
        {
            // Checks if textbox value can be converted correctly
            int number = 0;
            if (Int32.TryParse(vtextbox.Text, out number))
                return true;
            else
            {
                MessageBox.Show(vname + " isn't an integer number. Try again.", "Incorrect Entry");
                vtextbox.Focus();
                return false;
            }
        }
        //public static int Minutes
        //{
        //    get
        //    {
        //        return Convert.ToInt32(txtMins.Text);
        //    }
        //}
        //public static int Guests
        //{
        //    get
        //    {
        //        return Convert.ToInt32(txtGuests.Text);
        //    }
        //}
        //public static DateTime Start
        //{
        //    get
        //    {
        //        return Convert.ToDateTime(txtStart.Text);
        //    }
        //}
        public DateTime End
        {
            get
            {
                return Convert.ToDateTime(txtEnd.Text);
            }
        }
        public int FirstNum
        {
            get
            {
                return Convert.ToInt32(txtFirst.Text);
            }
        }
    }
}
