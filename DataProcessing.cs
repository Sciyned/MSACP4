/*  Program:        
    Author:         Mike Chiu
    Class:          CISP41
    Date:           
    Description: 

    I certify that the code below is my own work.
 
 Exception(s): N/A

*/

using System;
using System.IO;

namespace Project4
{
    /// <summary>
    /// The purpose of this class is to process the data. This class will retrieve data when the form
    /// loads from the .dat files. This class will also be used to save/overwrite the .dat files should
    /// there be things that have been changed. 
    /// 
    /// For the most part, try and take the information from Accounts.cs
    /// </summary>
    public class DataProcessing
    {
        private string dataFileString;
        private StreamReader dataReader;
        private StreamWriter dataWriter;

        public DataProcessing()
        {
            dataFileString = "";
        }

        public DataProcessing(string file, bool readFile)
        {
            dataFileString = file;
            if (readFile)
            {
                // Open file for reading
                dataReader = new StreamReader(dataFileString);
            }
            else
            {
                // Open file for writing
                dataWriter = new StreamWriter(dataFileString);
            }
        }

        public bool hasLine()
        {
            if (dataReader != null)
            {
                // Reader object was created
                if (dataReader.Peek() != -1)
                {
                    // There are lines available to read
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                // Reader object not created
                return false;
            }
        }

        // Returns the read line as an array. Line is split every ' ' (space) character.
        public string[] getLine()
        {
            if (dataReader == null)
            {
                // Create StreamReader object
                dataReader = new StreamReader(dataFileString);
            }

            if (hasLine())
            {
                // Lines available to read
                string[] dataPieces = dataReader.ReadLine().Split(' ');

                return dataPieces;
            }
            else
            {
                // Return empty string when no more lines are available
                return new string[0];
            }
        }
    }
}
