/*
 * Andrew Larkins
 * CIS-3309-01
 * Project 2 - Bookstore
 * 02/20/20
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ALarkins_BookStoreProject_Stage2.Classes;

namespace ALarkins_BookStoreProject_Stage2.Forms
{

    // This is the second form for the user to enter their
    // pin after the employee id has been matched.

    public partial class frmPinID : Form
    {
        // Class variables.
        int numAttempts = 0;

        // Constructor.
        public frmPinID()
        {
            InitializeComponent();
        }
        
        // Exit button that will close the program when clicked on.
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Go button click event handler method.
        // Gets user input from text box and checks if it is valid length.
        // Also will check if the pin matches the employee id.
        private void btnGo_Click(object sender, EventArgs e)
        {
            try
            {
                int pinLength = txtPin.Text.Length;
                int inputPin = Convert.ToInt32(txtPin.Text);
                if (pinLength == 4 && Globals.BookStore.EmployeeList.verifyPin(inputPin) == true)
                {
                    Globals.BookStore.EmployeeList.updateEmployeeObject();
                    Globals.BookStore.writeEntireEmployeeList();
                    BookStoreClass.currentEmployeeFile.closeFile();
                    BookStoreClass.updatedEmployeeFile.closeFile();

                    MessageBox.Show("You have logged in to the bookstore inventory.", "Welcome");
                    // Hide pin form, load third form.
                    this.Hide();
                    frmBook book = new frmBook();
                    book.ShowDialog();
                }
                else
                {
                    numAttempts++;
                    MessageBox.Show("Invalid pin.");
                    txtPin.Text = "";
                    txtPin.Focus();
                }
            }
            catch
            {
                numAttempts++;
                MessageBox.Show("Invalid pin.");
            }
            // Only allow 3 wrong tries.
            if (numAttempts == 3)
            {
                MessageBox.Show("Too many attempts.", "Closing");
                this.Close();
            }
        }
    }
}
