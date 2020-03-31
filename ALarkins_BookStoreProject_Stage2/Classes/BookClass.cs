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

// Class used to show data related to the books.

namespace ALarkins_BookStoreProject_Stage2.Classes
{
    class BookClass
    {
        // Class variables.
        string bookISBN;
        string bookTitle;
        string bookAuthor;
        decimal bookPrice;
        int bookNumberOnHand;
        DateTime lastTransaction;

        // Constructor to create book object.
        public BookClass()
        {
            this.bookISBN = "";
            this.bookTitle = "";
            this.bookAuthor = "";
            this.bookPrice = 0;
            this.bookNumberOnHand = 0;
            this.lastTransaction = DateTime.Now;
        }

        // Method to see if isbn number is a match.
        public Boolean bookMatch(string ISBN, string nextRecord)
        {
            if (nextRecord.Substring(0, 7) == ISBN)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Returns the string formatted properly.
        public string displayBookRecord(string s)
        {
            String[] book = s.Split('*');
            return "ISBN: " + book[0] + "Title: " + book[1] +"Author: "
                + book[2] + "Price: " + book[3]
               + "Number On Hand: " + book[4] +
               "Last Transaction: " + book[5];
        }
    }
}
