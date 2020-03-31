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
using ALarkins_BookStoreProject_Stage2.Forms;

namespace ALarkins_BookStoreProject_Stage2
{

    // This class is the first form that is used to
    // get the Employee id from the user.

    public partial class frmAccessID : Form
    {
        // Class variables.
        int numAttempts = 0;
        
        // Constructor.
        public frmAccessID()
        {
            InitializeComponent();
        }
        
        // Event handler for the Access Id form to load.
        // Creates entire employee list from the
        // Employees text file.
        private void frmAccessID_Load(object sender, EventArgs e)
        {
            bool listInit = Globals.BookStore.EmployeeList.initializeEntireEmployeeList();
            if (!listInit)
            {
                MessageBox.Show("List unable to be initialized.");
                this.Close();
            }
        }

        // Click event handler for exit button to close program.
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Click event handler method for the find me button.
        // Gets num input from text box, this num is the employee id.
        // It needs to be length 5 and exist in the exmployee file.
        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                int inputLength = txtAccessId.Text.Length;
                int accessId = Convert.ToInt32(txtAccessId.Text);
                if (inputLength == 5 && Globals.BookStore.findEmployee(accessId) == true)
                {
                    // Load form 2 if the id is valid.
                    this.Hide();
                    frmPinID frmPIN = new frmPinID();
                    frmPIN.ShowDialog();
                }
                else
                    {
                        // Employee Access Id is not valid.
                        // increment attempts.
                        Globals.BookStore.EmployeeList.resetIndex();
                        numAttempts++;
                        MessageBox.Show("Employee Access Id is invalid...");
                        txtAccessId.Text = "";
                        txtAccessId.Focus();
                    }
                }
                catch
                {
                    numAttempts++;
                    MessageBox.Show("Employee Access Id is invalid...");
                    txtAccessId.Text = "";
                    txtAccessId.Focus();
                }
                // Only allows for 3 wrong attempts, or else the program will close.
                if (numAttempts == 3)
                {
                    MessageBox.Show("Too many invalid entries...", "Exiting Program.");
                    this.Close();
            }
        }
    }
}
