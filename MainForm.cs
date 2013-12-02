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

        // Month data
        const int MAX_MONTHS = 12;
        MonthData[] monthsArray = new MonthData[MAX_MONTHS];

        // Structure for storing individual month data
        public struct MonthData
        {
            public int[] employeeIds;
            public double[] employeeHours;
        }

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

        // Clear deduction checkboxes
        void clearCheckboxes()
        {
            medicalCheckBox.Checked = false;
            lifeInsuranceCheckBox.Checked = false;
            fourCheckBox.Checked = false;
            fsaCheckBox.Checked = false;
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
                employeeCountInt++;
                Console.WriteLine(employeeCountInt);
            }
            // Close the file
            myData.closeFile();
            myData = null;

            // Read month data
            int monthsInt = 0;
            while (monthsInt < MAX_MONTHS)
            {
                DataProcessing monthData = new DataProcessing();
                if (monthsInt == 0)
                    monthData.DataFile = "data/jan.dat";
                else if (monthsInt == 1)
                    monthData.DataFile = "data/feb.dat";
                else if (monthsInt == 2)
                    monthData.DataFile = "data/mar.dat";
                else if (monthsInt == 3)
                    monthData.DataFile = "data/apr.dat";
                else if (monthsInt == 4)
                    monthData.DataFile = "data/may.dat";
                else if (monthsInt == 5)
                    monthData.DataFile = "data/jun.dat";
                else if (monthsInt == 6)
                    monthData.DataFile = "data/jul.dat";
                else if (monthsInt == 7)
                    monthData.DataFile = "data/aug.dat";
                else if (monthsInt == 8)
                    monthData.DataFile = "data/sep.dat";
                else if (monthsInt == 9)
                    monthData.DataFile = "data/oct.dat";
                else if (monthsInt == 10)
                    monthData.DataFile = "data/nov.dat";
                else if (monthsInt == 11)
                    monthData.DataFile = "data/dec.dat";
                monthData.ReadFile = true;

                // Read file
                List<int> employeeIdList = new List<int>();
                List<double> employeeHoursList = new List<double>();
                while (monthData.hasLine())
                {
                    string[] linePieceArray = monthData.getLine();
                    int pieceInt = 0;

                    foreach (string pieceString in linePieceArray)
                    {
                        if (pieceInt == 0)
                        {
                            employeeIdList.Add(int.Parse(pieceString));
                        }
                        else if (pieceInt == 1)
                        {
                            employeeHoursList.Add(double.Parse(pieceString));
                        }
                        pieceInt++;
                    }
                }
                monthsArray[monthsInt] = new MonthData();
                monthsArray[monthsInt].employeeIds = employeeIdList.ToArray();
                monthsArray[monthsInt].employeeHours = employeeHoursList.ToArray();
                monthsInt++;
                Console.WriteLine("Month: " + monthsInt.ToString());
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

        private void employeeIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Change other form components when this is changed
            int indexInt = employeeIDComboBox.SelectedIndex;

            employeeFirstNameComboBox.SelectedIndex = indexInt;
            employeeLastNameComboBox.SelectedIndex = indexInt;
            
            // Select proper position
            if (employeeArray[indexInt].Position == "Manager")
            {
                positionComboBox.SelectedIndex = 0;
                salaryRadioButton.Checked = true;
                rateTextField.Text = employeeArray[indexInt].Salary.ToString();
            }
            else if (employeeArray[indexInt].Position == "Engineer")
            {
                positionComboBox.SelectedIndex = 1;
                salaryRadioButton.Checked = true;
                rateTextField.Text = employeeArray[indexInt].Salary.ToString();
            }
            else if (employeeArray[indexInt].Position == "Technician")
            {
                positionComboBox.SelectedIndex = 2;
                hourlyRadioButton.Checked = true;
                rateTextField.Text = employeeArray[indexInt].Salary.ToString();
            }
            else if (employeeArray[indexInt].Position == "Clerk")
            {
                positionComboBox.SelectedIndex = 3;
                hourlyRadioButton.Checked = true;
                rateTextField.Text = employeeArray[indexInt].Salary.ToString();
            }
            else if (employeeArray[indexInt].Position == "Production")
            {
                positionComboBox.SelectedIndex = 4;
                hourlyRadioButton.Checked = true;
                rateTextField.Text = employeeArray[indexInt].Salary.ToString();
            }
            
            // Select proper department
            if (employeeArray[indexInt].Department == "HR")
                departmentComboBox.SelectedIndex = 0;
            else if (employeeArray[indexInt].Department == "Accounting")
                departmentComboBox.SelectedIndex = 1;
            else if (employeeArray[indexInt].Department == "R&D")
                departmentComboBox.SelectedIndex = 2;
            else if (employeeArray[indexInt].Department == "Sales")
                departmentComboBox.SelectedIndex = 3;
            else if (employeeArray[indexInt].Department == "Production")
                departmentComboBox.SelectedIndex = 4;

            // Check proper deductions
            clearCheckboxes();
            if (employeeArray[indexInt].Insurance != 0.0)
                medicalCheckBox.Checked = true;
            if (employeeArray[indexInt].LifeInsurance != 0.0)
                lifeInsuranceCheckBox.Checked = true;
            if (employeeArray[indexInt].Retirement != 0.0)
                fourCheckBox.Checked = true;
            if (employeeArray[indexInt].FSA != 0.0)
                fsaCheckBox.Checked = true;

            // Clear selected month
            monthComboBox.SelectedIndex = -1;
            hoursTextField.Text = "";
        }

        private void employeeFirstNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Change other form components when this is changed
            int indexInt = employeeFirstNameComboBox.SelectedIndex;

            employeeIDComboBox.SelectedIndex = indexInt;
            employeeLastNameComboBox.SelectedIndex = indexInt;

            // Select proper position
            if (employeeArray[indexInt].Position == "Manager")
            {
                positionComboBox.SelectedIndex = 0;
                salaryRadioButton.Checked = true;
                rateTextField.Text = employeeArray[indexInt].Salary.ToString();
            }
            else if (employeeArray[indexInt].Position == "Engineer")
            {
                positionComboBox.SelectedIndex = 1;
                salaryRadioButton.Checked = true;
                rateTextField.Text = employeeArray[indexInt].Salary.ToString();
            }
            else if (employeeArray[indexInt].Position == "Technician")
            {
                positionComboBox.SelectedIndex = 2;
                hourlyRadioButton.Checked = true;
                rateTextField.Text = employeeArray[indexInt].Salary.ToString();
            }
            else if (employeeArray[indexInt].Position == "Clerk")
            {
                positionComboBox.SelectedIndex = 3;
                hourlyRadioButton.Checked = true;
                rateTextField.Text = employeeArray[indexInt].Salary.ToString();
            }
            else if (employeeArray[indexInt].Position == "Production")
            {
                positionComboBox.SelectedIndex = 4;
                hourlyRadioButton.Checked = true;
                rateTextField.Text = employeeArray[indexInt].Salary.ToString();
            }

            // Select proper department
            if (employeeArray[indexInt].Department == "HR")
                departmentComboBox.SelectedIndex = 0;
            else if (employeeArray[indexInt].Department == "Accounting")
                departmentComboBox.SelectedIndex = 1;
            else if (employeeArray[indexInt].Department == "R&D")
                departmentComboBox.SelectedIndex = 2;
            else if (employeeArray[indexInt].Department == "Sales")
                departmentComboBox.SelectedIndex = 3;
            else if (employeeArray[indexInt].Department == "Production")
                departmentComboBox.SelectedIndex = 4;

            // Check proper deductions
            clearCheckboxes();
            if (employeeArray[indexInt].Insurance != 0.0)
                medicalCheckBox.Checked = true;
            if (employeeArray[indexInt].LifeInsurance != 0.0)
                lifeInsuranceCheckBox.Checked = true;
            if (employeeArray[indexInt].Retirement != 0.0)
                fourCheckBox.Checked = true;
            if (employeeArray[indexInt].FSA != 0.0)
                fsaCheckBox.Checked = true;

            // Clear selected month
            monthComboBox.SelectedIndex = -1;
            hoursTextField.Text = "";
        }

        private void employeeLastNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Change other form components when this is changed
            int indexInt = employeeLastNameComboBox.SelectedIndex;

            employeeFirstNameComboBox.SelectedIndex = indexInt;
            employeeIDComboBox.SelectedIndex = indexInt;

            // Select proper position
            if (employeeArray[indexInt].Position == "Manager")
            {
                positionComboBox.SelectedIndex = 0;
                salaryRadioButton.Checked = true;
                rateTextField.Text = employeeArray[indexInt].Salary.ToString();
            }
            else if (employeeArray[indexInt].Position == "Engineer")
            {
                positionComboBox.SelectedIndex = 1;
                salaryRadioButton.Checked = true;
                rateTextField.Text = employeeArray[indexInt].Salary.ToString();
            }
            else if (employeeArray[indexInt].Position == "Technician")
            {
                positionComboBox.SelectedIndex = 2;
                hourlyRadioButton.Checked = true;
                rateTextField.Text = employeeArray[indexInt].Salary.ToString();
            }
            else if (employeeArray[indexInt].Position == "Clerk")
            {
                positionComboBox.SelectedIndex = 3;
                hourlyRadioButton.Checked = true;
                rateTextField.Text = employeeArray[indexInt].Salary.ToString();
            }
            else if (employeeArray[indexInt].Position == "Production")
            {
                positionComboBox.SelectedIndex = 4;
                hourlyRadioButton.Checked = true;
                rateTextField.Text = employeeArray[indexInt].Salary.ToString();
            }

            // Select proper department
            if (employeeArray[indexInt].Department == "HR")
                departmentComboBox.SelectedIndex = 0;
            else if (employeeArray[indexInt].Department == "Accounting")
                departmentComboBox.SelectedIndex = 1;
            else if (employeeArray[indexInt].Department == "R&D")
                departmentComboBox.SelectedIndex = 2;
            else if (employeeArray[indexInt].Department == "Sales")
                departmentComboBox.SelectedIndex = 3;
            else if (employeeArray[indexInt].Department == "Production")
                departmentComboBox.SelectedIndex = 4;

            // Check proper deductions
            clearCheckboxes();
            if (employeeArray[indexInt].Insurance != 0.0)
                medicalCheckBox.Checked = true;
            if (employeeArray[indexInt].LifeInsurance != 0.0)
                lifeInsuranceCheckBox.Checked = true;
            if (employeeArray[indexInt].Retirement != 0.0)
                fourCheckBox.Checked = true;
            if (employeeArray[indexInt].FSA != 0.0)
                fsaCheckBox.Checked = true;

            // Clear selected month
            monthComboBox.SelectedIndex = -1;
            hoursTextField.Text = "";
        }
		
		void AboutToolStripMenuItemClick(object sender, EventArgs e)
		{
			// Instantiate About
			AboutMainForm showForm = new AboutMainForm();
			showForm.ShowDialog();
		}

        private void monthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Display proper information if employee and month is selected
            if (employeeIDComboBox.SelectedIndex != -1 && monthComboBox.SelectedIndex != -1)
            {
                int selectedMonthInt = monthComboBox.SelectedIndex;
                Console.WriteLine(selectedMonthInt);
                double empHoursDouble = 0.0;

                for (int i = 0; i < monthsArray[selectedMonthInt].employeeIds.Length; i++)
                {
                    if (monthsArray[selectedMonthInt].employeeIds[i].ToString() == employeeIDComboBox.Items[employeeIDComboBox.SelectedIndex].ToString())
                    {
                        empHoursDouble = monthsArray[selectedMonthInt].employeeHours[i];
                    }
                }

                hoursTextField.Text = empHoursDouble.ToString();
            }
        }
		
		void ClearButtonClick(object sender, EventArgs e)
		{
			monthComboBox.Text = "";
			employeeIDComboBox.Text = "";
			employeeFirstNameComboBox.Text = "";
			employeeLastNameComboBox.Text = "";
			positionComboBox.Text = "";
			departmentComboBox.Text = "";
			rateTextField.Text = "";
			hoursTextField.Text = "";
			medicalCheckBox.Checked = false;
			fourCheckBox.Checked = false;
			lifeInsuranceCheckBox.Checked = false;
			fsaCheckBox.Checked = false;
			hourlyRadioButton.Checked = false;
			salaryRadioButton.Checked = false;
		}
	}
}
