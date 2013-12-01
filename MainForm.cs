/*  Program:        
    Author:         Mike Chiu
    Class:          CISP41
    Date:           
    Description: 

    I certify that the code below is my own work.
 
 Exception(s): N/A

*/

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Project4
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class PayrollMainForm : Form
	{
		// Instantiate objects from other classes
		EditEmployee showForm = new EditEmployee();

        // Variables and array to hold employee information
        const int MAX_EMPLOYEES = 50;
        Employee[] employeeArray = new Employee[MAX_EMPLOYEES];
        int employeeCountInt = 0;
		
		public PayrollMainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void ExitButtonClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void SalaryRadioButtonCheckedChanged(object sender, EventArgs e)
		{
			hoursTextField.Enabled = false;
		}
		
		void HourlyRadioButtonCheckedChanged(object sender, EventArgs e)
		{
			hoursTextField.Enabled = true;
		}
		
		void PayrollMainFormLoad(object sender, EventArgs e)
		{
			//DataProcessing LoadData = new DataProcessing();
            // Read data from file
            DataProcessing myData = new DataProcessing("data/master.dat", true);

            while (myData.hasLine())
            {
                string[] linePieceArray = myData.getLine();
                int pieceInt = 0;
                employeeArray[employeeCountInt] = new Employee();

                foreach (string pieceString in linePieceArray)
                {
                    if (pieceString != "")
                    {
                        // Piece isn't blank, read information into array

                        if (pieceInt == 0)
                        {
                            // Employee ID
                            employeeArray[employeeCountInt].ID = int.Parse(pieceString);
                        }
                        else if (pieceInt == 1)
                        {
                            // First Name
                            employeeArray[employeeCountInt].FirstName = pieceString;
                        }
                        else if (pieceInt == 2)
                        {
                            // Last Name
                            employeeArray[employeeCountInt].LastName = pieceString;
                        }
                        else if (pieceInt == 3)
                        {
                            // Department
                            employeeArray[employeeCountInt].Department = pieceString;
                        }
                        else if (pieceInt == 4)
                        {
                            // Position
                            employeeArray[employeeCountInt].Position = pieceString;
                        }
                        else if (pieceInt == 5)
                        {
                            // Salary
                            employeeArray[employeeCountInt].Salary = double.Parse(pieceString);
                        }
                        else if (pieceInt == 6)
                        {
                            // Medical/Dental
                            employeeArray[employeeCountInt].Insurance = double.Parse(pieceString);
                        }
                        else if (pieceInt == 7)
                        {
                            // Life Insurance
                            employeeArray[employeeCountInt].LifeInsurance = double.Parse(pieceString);
                        }
                        else if (pieceInt == 8)
                        {
                            // 401k
                            employeeArray[employeeCountInt].Retirement = double.Parse(pieceString);
                        }
                        else if (pieceInt == 9)
                        {
                            // FSA
                            employeeArray[employeeCountInt].FSA = double.Parse(pieceString);
                        }
                        pieceInt++;
                    }
                }
                employeeCountInt++;
                Console.WriteLine(employeeCountInt);
            }

            // Insert results into form
            for (int i = 0; i < employeeCountInt; i++)
            {
                employeeIDComboBox.Items.Add(employeeArray[i].ID);
                employeeFirstNameComboBox.Items.Add(employeeArray[i].FirstName);
                employeeLastNameComboBox.Items.Add(employeeArray[i].LastName);
            }
		}

        void EditEmployeeToolStripMenuItemClick(object sender, EventArgs e)
		{
			showForm.ShowDialog();
		}
	}
}
