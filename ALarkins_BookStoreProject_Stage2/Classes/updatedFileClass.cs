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
using System.IO;

namespace ALarkins_BookStoreProject_Stage2.Classes
{
    // Class used to update a file.
    class updatedFileClass
    {
        // Class variables.
        private int recordWrittenCount;
        private string updatedFilePath;
        private StreamWriter updatedFileSW;

        // Constructor that creates stream writer object and sets class variables.
        public updatedFileClass(string filePath)
        {
            recordWrittenCount = 0;
            updatedFilePath = filePath;
            try
            {
                updatedFileSW = new System.IO.StreamWriter(updatedFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot open file, (" + updatedFilePath + ") terminating write out");
            }
        }

        // Method to write a line of the record into the text file.
        public void writeNextRecord(string record)
        {
            try
            {
                updatedFileSW.WriteLine(record);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Text file write error...");
            }
            recordWrittenCount += 1;
        }
        
        // Number of records written.
        public int getRecordsWrittenCount()
        {
            return recordWrittenCount;
        }
        
        // Close method.
        public void closeFile()
        {
            updatedFileSW.Flush();
            updatedFileSW.Close();
        }
        
        // Rewind the output file.
        public void rewindFile()
        {
            recordWrittenCount = 0;
            closeFile();
            updatedFileSW = new System.IO.StreamWriter(updatedFilePath);
            updatedFileSW.BaseStream.Seek(0, System.IO.SeekOrigin.Begin);
        } // end rewindFile
    }
}
