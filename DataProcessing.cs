/*  Program:        
    Author:         Mike Chiu/Oscar Campos
    Class:          CISP41
    Date:           
    Description: 	This class processes all the data from retrieval to sending.

    I certify that the code below is my own work.
 
 Exception(s): N/A

*/

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections;

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
        private bool readFileBool;
        private StreamReader dataReader;
        private StreamWriter dataWriter;

        public DataProcessing()
        {
            dataFileString = "";
        }

        public DataProcessing(string file, bool readFile)
        {
            dataFileString = file;
            readFileBool = readFile;

            if (readFileBool)
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

        // Property methods
        public string DataFile
        {
            get
            {
                return dataFileString;
            }
            set
            {
                dataFileString = value;
            }
        }

        public bool ReadFile
        {
            get
            {
                return readFileBool;
            }
            set
            {
                readFileBool = value;
                if (readFileBool)
                {
                    // Reading
                    dataReader = new StreamReader(dataFileString);
                }
                else
                {
                    // Writing
                    dataWriter = new StreamWriter(dataFileString);
                }
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
                List<String> dataList = new List<String>();

                foreach (string dataPiece in dataPieces)
                {
                    // Ignore empty pieces
                    if (dataPiece != "")
                    {
                        dataList.Add(dataPiece);
                    }
                }

                return dataList.ToArray();
            }
            else
            {
                // Return empty string when no more lines are available
                return new string[0];
            }
        }

        // Closes the current file
        public void closeFile()
        {
            if (dataReader != null)
                dataReader.Close();
            if (dataWriter != null)
                dataWriter.Close();
        }
    }
}
