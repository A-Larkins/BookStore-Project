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
    // Class used to populate employee list.

    class EmployeeListClass
    {
        List<EmployeeClass> InternalList = new List<EmployeeClass>();
        private int index; // holds index of element in list that contains the employee
        //     who has logged in

        // Constructor.
        public EmployeeListClass()
        {
            this.index = 0;
        }

        // Find an employee in the list of employees.
        public bool findEmployeeInList(int accessID)
        {
            Boolean flag = false;
            while (flag == false && index < InternalList.Count)
            {
                if (InternalList[index].checkEmployeeID(accessID) == true)
                {
                    flag = true;
                    return true;
                }
                else
                {
                    index++;
                }
            }
            return false;
        }

        // Method used to reset index.
        public void resetIndex()
        {
            this.index = 0;
        }

        // Initialize entire employee list given data in current Book File 
        public Boolean initializeEntireEmployeeList()
        {
            Boolean EOF = true;
            string nextRecord;
            Boolean couldCreateEmp;
            int recordCountWritten = 0;

            nextRecord = BookStoreClass.currentEmployeeFile.getNextRecord(ref EOF);
            while (!EOF)
            {
                recordCountWritten++;
                EmployeeClass newEmp = new EmployeeClass();
                couldCreateEmp = newEmp.createAndPopulateEmployeeObject(nextRecord);
                if (couldCreateEmp != true)
                {
                    MessageBox.Show("Employee could not be made from file. List creation failed.");
                    return false;
                }
                InternalList.Add(newEmp);
                nextRecord = BookStoreClass.currentEmployeeFile.getNextRecord(ref EOF);
            }
            if (recordCountWritten > 0)
                return true;
            else
                return false;
        }

        // Method to update the current employee with transaction date now.
        public void updateEmployeeObject()
        {
            InternalList[index].updateEmployeeTransactionDate();
        }

        // Calls employee's verify inputPin to check if
        // entered inputPin matches current saved employee inputPin.
        public Boolean verifyPin(int pin)
        {
            if (InternalList[index].verifyPin(pin) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Method to write the conent of EmployeeList object to
        // the updated employee file object.
        public void writeEntireListToFile()
        {
            string writtenEmployees = "";
            foreach (EmployeeClass emp in InternalList)
            {
                writtenEmployees = emp.createStringToDisplay();
                BookStoreClass.updatedEmployeeFile.writeNextRecord(writtenEmployees);
            }
        }
    }
}
