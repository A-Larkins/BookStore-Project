/*
 * Andrew Larkins
 * CIS-3309-01
 * Project 2 - Bookstore
 * 03/02/20
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALarkins_BookStoreProject_Stage2.Classes
{

    // This class contains all things owned by the bookstore.
    
    class BookStoreClass
    {
        // Objects owned by the book store.
        public BookClass Book = new BookClass();
        public EmployeeListClass EmployeeList = new EmployeeListClass();

        // These are the files used.
        private static string currentEmployeeFilePath = "Employees.txt";
        private static string currentBookFilePath = "Books.txt";
        private static string updatedEmployeeFilePath = "updatedEmployeeFile.txt";
        private static string updatedBookFilePath = "updatedBookFile.txt";

        // References to the files.
        public static currentFileClass currentBookFile = new currentFileClass(currentBookFilePath);
        public static updatedFileClass updatedBookFile = new updatedFileClass(updatedBookFilePath);
        public static currentFileClass currentEmployeeFile = new currentFileClass(currentEmployeeFilePath);
        public static updatedFileClass updatedEmployeeFile = new updatedFileClass(updatedEmployeeFilePath);

        // Class variables.
        private int hiddenMaxLoginAttempts = 3;
        private int hiddenISBNLeftLength = 3;
        private int hiddenISBNRightLength = 3;
        private int hiddenAccessIDLength = 5;
        
        // Constructor.
        public BookStoreClass()
        {

        }

        // Method to find and save book according to the inputten isbn number.
        public string findAndSaveBook(string ISBN, out Boolean found)
        {
            string nextRecord;
            Boolean isEndOfFile = true;
            nextRecord = currentBookFile.getNextRecord(ref isEndOfFile);
            found = false;
            while (!isEndOfFile)
            {
                if (Book.bookMatch(ISBN, nextRecord))
                {
                    found = true;
                    return (nextRecord);
                }
                else
                {
                    updatedBookFile.writeNextRecord(nextRecord);
                    Book.displayBookRecord(nextRecord);
                    nextRecord = currentBookFile.getNextRecord(ref isEndOfFile);
                }
            }
            return (nextRecord);
        }

        // Method to check if an employee exists in the employees list.
        public bool findEmployee(int ID)
        {
            return EmployeeList.findEmployeeInList(ID);

        }
        
        // Method to write a new list to updated employees list.
        public void writeEntireEmployeeList()
        {
            EmployeeList.writeEntireListToFile();
        }

        // Method used when the add button is clicked on. It will
        // check for if the book already exists.
        public Boolean checkForDuplicateRecord (string ISBN)
        {
            Boolean found = false;
            findAndSaveBook(ISBN, out found);
            if (found == true)
            {
                currentBookFile.rewindFile();
            }
            return found;
        }

        public void writeOneRecord(string record)
        {
            updatedBookFile.writeNextRecord(record);
            Book.displayBookRecord(record);
        }
        
        // Method used to update the updated file.
        public void copyRemainingRecords()
        {
            Boolean EOF = false;
            string nextRecord;
            nextRecord = currentBookFile.getNextRecord(ref EOF);
            while (!EOF)
            {
                updatedBookFile.writeNextRecord(nextRecord);
                Book.displayBookRecord(nextRecord);
                nextRecord = currentBookFile.getNextRecord(ref EOF);
            }
            MessageBox.Show("The book file has been updated!");
        }

        // Method to reset the files.
        public void rewindFiles()
        {
            currentBookFile.rewindFile();
            updatedBookFile.rewindFile();
            currentEmployeeFile.rewindFile();
            updatedEmployeeFile.rewindFile();
        }

        // Method to close the files.
        public void closeFiles()
        {
            currentBookFile.closeFile();
            updatedBookFile.closeFile();
            currentEmployeeFile.closeFile();
            updatedEmployeeFile.closeFile();
        }

        // These methods return class variables when
        // called upon from other classes.
        public int accessIDLength
        {
            get
            {
                return hiddenAccessIDLength;
            }
        }
        public int ISBNLeftLength
        {
            get
            {
                return hiddenISBNLeftLength;
            }
        }
        public int ISBNRightLength
        {
            get
            {
                return hiddenISBNRightLength;
            }
        }
        public int tryCountMax
        {
            get
            {
                return hiddenMaxLoginAttempts;
            }
        }
    }
}
