using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Validation
{
    public static class Validator
    {
        //Static class used for data validation.

        private static string title = "Entry Error";

        public static string Title
        {
            get { return title; }
            set { title = value; }
        }

        public static bool IsPresent(TextBox textbox, string name)
        {
            //determines whether a TextBox has data entered
            if (textbox.Text == "")
            {
                MessageBox.Show(name + " is required.", Title);
                textbox.Focus();
                return false;
            }
            else
                return true;
        }
        public static bool IsDateFormat(TextBox textbox, string name)
        {
            //determines whether the Text property of a TextBox can be parsed to DateTime
            DateTime tripDate;
            if (DateTime.TryParse(textbox.Text, out tripDate))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Please enter mm/dd/yyyy date format in the " + name + " textbox.", Title);
                textbox.Focus();
                return false;
            }

        }
        public static bool IsDecimal(TextBox textbox, string name)
        {
            //Determines whether the Text property of a TextBox can be parsed to Decimal
            decimal number = 0m;
            if (Decimal.TryParse(textbox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " needs to be a decimal.", Title);
                textbox.Focus();
                return false;
            }
        }
        public static bool IsInt(TextBox textbox, string name)
        {
            //Determines whether the Text property of a TextBox can be parsed to Decimal
            Int32 number = 0;
            if (Int32.TryParse(textbox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " needs to be a number with no decimal values.", Title);
                textbox.Focus();
                return false;
            }
        }
        public static bool IsWithinRange(TextBox textbox, string name, decimal min, decimal max)
        { //Validates which numbers can be used within a range specified.
            decimal number = Convert.ToDecimal(textbox.Text); //Converts textbox to decimal.
            if (number < min || number > max)
            {
                MessageBox.Show(name + " must be between " + min.ToString() + " and " + max.ToString() + ".", Title);
                textbox.Focus(); //Returns focus to the textbox that triggered the error.
                return false;
            }
            return true;
        }
    }
}

