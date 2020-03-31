/*
 * Andrew Larkins
 * CIS-3309-01
 * Project 2 - Bookstore
 * 02/20/20
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALarkins_BookStoreProject_Stage2.Classes
{
    // Class used to create Employee objects.

    class EmployeeClass
    {
        // Class variables.
        string hiddenName;
        int hiddenAccessId;
        int hiddenPin;
        decimal hiddenAnnualPay;
        DateTime hiddenLastDateOfAccess;
        
        // Constructor.
        public EmployeeClass()
        {
            this.hiddenName = "";
            this.hiddenAccessId = 0;
            this.hiddenPin = 0;
            this.hiddenAnnualPay = 0;
            this.hiddenLastDateOfAccess = DateTime.Now;
        }

        // Method used to check if id entered is in the list.
        public Boolean checkEmployeeID(int accessId)
        {
            if (accessId == this.hiddenAccessId)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Method checks if pin matches the correct employee.
        public Boolean verifyPin(int pinIn)
        {
            if (pinIn == this.hiddenPin)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Sets most recent access to now.
        public void updateEmployeeTransactionDate()
        {
            this.hiddenLastDateOfAccess = DateTime.Now;
        }

        // proper to string display.
        public string createStringToDisplay()
        {
            return this.hiddenAccessId.ToString() +
                " * " + this.hiddenName + " * " +
                this.hiddenPin.ToString() + " * " + "$" +
                this.hiddenAnnualPay.ToString() + " * " +
                this.hiddenLastDateOfAccess.ToShortDateString();
        }

        // This method takes the string from the employee text file and splits
        // the information into 5 parts. Gets rid of *'s.
        // Gets rid of whitespace. It will validate the data and stores
        // references in an employee object and stores in list.
        public Boolean createAndPopulateEmployeeObject(string str)
        {
            EmployeeClass Employee = this;
            string[] employeeStringArray = str.Split('*');
            int lengthOfEmployeeString = employeeStringArray.GetLength(0);
            for (int i = 0; i < lengthOfEmployeeString; i++)
            {
                employeeStringArray[i] = employeeStringArray[i].Trim();
            }
            // Zero-th index is the employee access id.
            if (employeeStringArray[0].Length != 5)
            {
                MessageBox.Show("Invalid length of employee access id...", "Invalid.");
                return false;
            }
            try
            {
                this.hiddenAccessId = Convert.ToInt32(employeeStringArray[0]);
            }
            catch
            {
                MessageBox.Show("Invalid length of employee access id...", "Invalid.");
                return false;
            }

            // First index is the employee name.
            this.hiddenName = employeeStringArray[1];
            if (this.hiddenName == " " || this.hiddenName == "")
            {
                MessageBox.Show("Name is blank...", "Invalid.");
                return false;
            }

            // Second index is the employee pin. Convert to int.
            if (employeeStringArray[2].Length != 4)
            {
                MessageBox.Show("Pin is invalid..", "Invalid.");
                return false;
            }
            try
            {
                this.hiddenPin = Convert.ToInt32(employeeStringArray[2]);
            }
            catch
            {
                MessageBox.Show("Pin is invalid..", "Invalid.");
                return false;
            }

            // Third index is the annual pay. Convert to decimal.
            try
            {
                this.hiddenAnnualPay = Convert.ToDecimal(employeeStringArray[3].Replace
                    (",","").Replace("$", ""));
            }
            catch
            {
                MessageBox.Show("Annual pay is invalid...", "Invalid.");
                return false;
            }

            // Fourth index is the date of last access.
            try
            {
                this.hiddenLastDateOfAccess = DateTime.Parse(employeeStringArray[4]);
            }
            catch
            {
                MessageBox.Show("Date of last access is invalid...", "Invalid.");
                return false;
            }

            // All data is valid.
            return (true);
        }
    }
}
