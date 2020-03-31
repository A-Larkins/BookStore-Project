/*
 * Andrew Larkins
 * CIS-3309-01
 * Project 2 - Bookstore
 * 03/02/20
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
    // This class is the third form. The main form
    // of the program. It is the book store transaction
    // page that the user has access to after they have
    // entered in their valid employee access id and
    // their pin is correct.
    public partial class frmBook : Form
    {
        // Class variable.
        int counter = 0;

        // Constructor.
        public frmBook()
        {
            InitializeComponent();
        }

        // Load method makes sure that when the form
        // is loaded, the cursor is put on
        // the left isbn text box.
        private void frmBook_Load(object sender, EventArgs e)
        {
            txtISBNLeft.Focus();
        }

        // Exit button click event handler to close program.
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // This method sets cursor to the right isbn text box
        // after the user enters 3 digits into the left text box.
        private void txtLeft_TextChanged(object sender, EventArgs e)
        {
            if (txtISBNLeft.Text.Length == 3)
            {
                txtISBNRight.Focus();
            }
        }

        // This method sets the focus to the ok button
        // after the user enters 3 digits into the
        // right isbn text box.
        private void txtRight_TextChanged(object sender, EventArgs e)
        {
            if (txtISBNRight.Text.Length == 3)
            {
                btnOK.Focus();
            }
        }

        // Method to handle the click event of the OK button.
        // Makes sure ISBN user input is in correct format.
        // If input is valid then reveal the rest of form
        // for user to enter book data.
        private void btnOK_Click(object sender, EventArgs e)
        {
            int ISBNLeft;
            int ISBNRight;
            if (int.TryParse(txtISBNLeft.Text, out ISBNLeft) == true
                && int.TryParse(txtISBNRight.Text, out ISBNRight) == true
                && txtISBNRight.Text.Length == 3)
            {
                lblSelectTransaction.Visible = true;
                btnAddBook.Visible = true;
                btnDeleteBook.Visible = true;
                btnUpdateBook.Visible = true;
                txtISBNLeft.Enabled = false;
                txtISBNRight.Enabled = false;
                btnOK.Enabled = false;
            }
            else
            {
                MessageBox.Show("Enter the ISBN number in the form nnn-nnn.");
                txtISBNLeft.Text = "";
                txtISBNRight.Text = "";
                counter++;
            }
            if (counter == 3)
            {
                MessageBox.Show("Too many invalid entries...", "Exiting.");
                this.Close();
            }
        }

        // Add button event handler method.
        // In order to add a book to the file, it must first be
        // checked to make sure it doesn't already exist.
        // If it doesn't already exist then disable the
        // button options and put the inputted ISBN number
        // into the data ISBN text box.
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (Globals.BookStore.checkForDuplicateRecord
                (txtISBNLeft.Text + "-" + txtISBNRight.Text) == true)
            {
                MessageBox.Show("Cannot add this book" +
                    "because it already exists on file...", "Error.");
                BookStoreClass.currentBookFile.rewindFile();
                BookStoreClass.updatedBookFile.rewindFile();
                this.Hide();
                frmBook book = new frmBook();
                book.ShowDialog();
            }
            else
            {
                lblEnterBookData.Text = "Enter Data To Add A Book:";
                makeVisible();
                btnUpdateBook.Enabled = false;
                btnDeleteBook.Enabled = false;
                btnAddBook.Enabled = false;
                txtDataISBN.Text = txtISBNLeft.Text + "-" + txtISBNRight.Text;
            }
        }

        // Click event handler for the update book button.
        // Reveal rest of form if the book has been found
        // on file. If the book is found on file then
        // show the rest of the form that allows the user
        // to udpate data on the book. If the book does
        // not exist on file then tell the user and reset
        // the isbn text boxes and rewind the files.
        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            lblEnterBookData.Text = "Enter Data To Update Book:";
            makeVisible();
            btnAddBook.Enabled = false;
            btnDeleteBook.Enabled = false;
            btnUpdateBook.Enabled = false;
            try
            {
                bool bookMatch = false;
                string bookStr = Globals.BookStore.findAndSaveBook
                    (txtISBNLeft.Text + "-" + txtISBNRight.Text, out bookMatch);
                String[] bookStrArr = bookStr.Split('*');
                txtDataISBN.Text = bookStrArr[0];
                txtDataTitle.Text = bookStrArr[1];
                txtDataAuthor.Text = bookStrArr[2];
                txtDataPrice.Text = bookStrArr[3];
                txtDataOnHand.Text = bookStrArr[4];
                txtDataDate.Text = bookStrArr[5];
            }
            catch
            {
                MessageBox.Show("The inputted ISBN does not exist on file...",
                    "Book not found.");
                BookStoreClass.currentBookFile.rewindFile();
                BookStoreClass.updatedBookFile.rewindFile();
                this.Hide();
                frmBook book = new frmBook();
                book.ShowDialog();
            }
        }

        // Click event handler method for the delete book button.
        // Checks if book exists on file. If it does then display
        // the data in the text boxes. If the inputted isbn does not
        // exist on file then tell the user and reset
        // the isbn text boxes and rewind the files.
        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            try
            {
                lblEnterBookData.Text = "Data For Book To Delete:";
                makeVisible();
                btnAddBook.Enabled = false;
                btnUpdateBook.Enabled = false;
                btnDeleteBook.Enabled = false;
                bool bookMatch = false;
                string bookString = Globals.BookStore.findAndSaveBook
                    (txtISBNLeft.Text + "-" + txtISBNRight.Text, out bookMatch);
                String[] BookArray = bookString.Split('*');
                txtDataISBN.Text = BookArray[0];
                txtDataTitle.Text = BookArray[1];
                txtDataAuthor.Text = BookArray[2];
                txtDataPrice.Text = BookArray[3];
                txtDataOnHand.Text = BookArray[4];
                txtDataDate.Text = BookArray[5];
                txtDataISBN.Enabled = false;
                txtDataTitle.Enabled = false;
                txtDataAuthor.Enabled = false;
                txtDataPrice.Enabled = false;
                txtDataOnHand.Enabled = false;
                txtDataDate.Enabled = false;
            }
            catch
            {
                MessageBox.Show("This book does not exist on file...", "Invalid.");
                BookStoreClass.currentBookFile.rewindFile();
                BookStoreClass.updatedBookFile.rewindFile();
                this.Hide();
                frmBook book = new frmBook();
                book.ShowDialog();
            }
        }

        // Method to reveal labels and done button.
        // Loads the rest of form. To be used after
        // ISBN is validated and a button option is
        // clicked on.
        private void makeVisible()
        {
            lblDataAuthor.Visible = true;
            lblDataTransactionDate.Visible = true;
            lblEnterBookData.Visible = true;
            lblDataISBN.Visible = true;
            lblDataOnHand.Visible = true;
            lblDataPrice.Visible = true;
            lblDataTitle.Visible = true;
            txtDataAuthor.Visible = true;
            txtDataDate.Visible = true;
            txtDataISBN.Visible = true;
            txtDataOnHand.Visible = true;
            txtDataPrice.Visible = true;
            txtDataTitle.Visible = true;
            btnDone.Visible = true;
        }

        // Done button to be clicked on after the user
        // is finished with the data input text boxes.
        // If-else blocks are to be used to check which
        // button the user has clicked on. So basically
        // the done button will handle each of the 3
        // actions. It will ask the user if they are sure
        // they want to go through will the transaction and
        // provide a yes or no button. If the user clicks on
        // the yes button then the transaction will be done
        // and the program will close. If they choose no then
        // the third form will basically be reset and loaded
        // again.
        private void btnDone_Click(object sender, EventArgs e)
        {
            // Case 1: update book button is clicked.
            if (lblEnterBookData.Text == "Enter Data To Update Book:")
            {
                MessageBoxButtons btnsYesNo_1 = MessageBoxButtons.YesNo;
                DialogResult finalResult_1;
                finalResult_1 = MessageBox.Show("Are you sure you want to update the book" +
                    "with this data?", "User Validation.", btnsYesNo_1);
                if (finalResult_1 == System.Windows.Forms.DialogResult.Yes)
                {
                    Globals.BookStore.writeOneRecord(txtDataISBN.Text + "*"
                        + txtDataTitle.Text + "*" + txtDataAuthor.Text + "*"
                        + txtDataPrice.Text + "*" + txtDataOnHand.Text + "*"
                        + txtDataDate.Text);
                    Globals.BookStore.copyRemainingRecords();
                    BookStoreClass.currentBookFile.closeFile();
                    BookStoreClass.updatedBookFile.closeFile();
                    this.Close();
                }
                if (finalResult_1 == System.Windows.Forms.DialogResult.No)
                {
                    MessageBox.Show("Enter a new ISBN...", "OK.");
                    BookStoreClass.currentBookFile.rewindFile();
                    BookStoreClass.updatedBookFile.rewindFile();
                    this.Hide();
                    frmBook book = new frmBook();
                    book.ShowDialog();
                }
            }

            // Case 2: delete book button is clicked.
            else if (lblEnterBookData.Text == "Data For Book To Delete:")
            {
                MessageBoxButtons btnsYesNo_2 = MessageBoxButtons.YesNo;
                DialogResult finalResult_2;
                finalResult_2 = MessageBox.Show("Are you sure you want to delete the book" +
                    "with this data?", "User Validation.", btnsYesNo_2);
                if (finalResult_2 == System.Windows.Forms.DialogResult.Yes)
                {
                    Globals.BookStore.copyRemainingRecords();
                    BookStoreClass.currentBookFile.closeFile();
                    BookStoreClass.updatedBookFile.closeFile();
                    this.Close();
                }
                if (finalResult_2 == System.Windows.Forms.DialogResult.No)
                {
                    MessageBox.Show("Enter a new ISBN...", "OK.");
                    BookStoreClass.currentBookFile.rewindFile();
                    BookStoreClass.updatedBookFile.rewindFile();
                    this.Hide();
                    frmBook book = new frmBook();
                    book.ShowDialog();
                }
            }

            // Case 3: add book button is clicked.
            else if (lblEnterBookData.Text == "Enter Data To Add A Book:")
            {
                MessageBoxButtons btnsYesNo_3 = MessageBoxButtons.YesNo;
                DialogResult finalResult_3;
                finalResult_3 = MessageBox.Show("Are you sure you want to add the book" +
                    "with this data?", "User Validation.", btnsYesNo_3);

                if (finalResult_3 == System.Windows.Forms.DialogResult.Yes)
                {
                    Globals.BookStore.writeOneRecord
                        (txtDataISBN.Text + "*" + txtDataTitle.Text + "*"
                        + txtDataAuthor.Text + "*" + txtDataPrice.Text + "*"
                        + txtDataOnHand.Text + "*" + txtDataDate.Text);
                    Globals.BookStore.copyRemainingRecords();
                    BookStoreClass.currentBookFile.closeFile();
                    BookStoreClass.updatedBookFile.closeFile();
                    this.Close();
                }
                if (finalResult_3 == System.Windows.Forms.DialogResult.No)
                {
                    MessageBox.Show("Enter a new ISBN...", "OK.");
                    BookStoreClass.currentBookFile.rewindFile();
                    BookStoreClass.updatedBookFile.rewindFile();
                    this.Hide();
                    frmBook book = new frmBook();
                    book.ShowDialog();
                }
            }
        } 
    }
}
