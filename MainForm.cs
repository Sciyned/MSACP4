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
            // Send employee array with count
            showForm.EmployeeArray = employeeArray;
            showForm.EmployeeCount = employeeCountInt;
			showForm.ShowDialog();
            // Get new employee array with new info
            employeeArray = showForm.EmployeeArray;
            // Refresh names in comboboxes
            for (int i = 0; i < employeeCountInt; i++)
            {
                employeeFirstNameComboBox.Items[i] = employeeArray[i].FirstName;
                employeeLastNameComboBox.Items[i] = employeeArray[i].LastName;
            }
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
            else if (employeeArray[indexInt].Position == "Producer")
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
            else if (employeeArray[indexInt].Position == "Producer")
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
            else if (employeeArray[indexInt].Position == "Producer")
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
            clearForm();
		}

        void clearForm()
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

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (monthComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a month to update.");
            }
            else if (employeeIDComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a valid employee ID.");
            }
            else if (employeeFirstNameComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a valid first name.");
            }
            else if (employeeLastNameComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a valid last name.");
            }
            else if (positionComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a valid position.");
            }
            else if (departmentComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a valid department.");
            }
            else if (hoursTextField.Text == "")
            {
                MessageBox.Show("Please enter new hours value.");
                hoursTextField.Focus();
            }
            else if (rateTextField.Text == "")
            {
                MessageBox.Show("Please enter a new rate value.");
                rateTextField.Focus();
            }
            else
            {
                // Try parsing new hours
                try
                {
                    double newHours = double.Parse(hoursTextField.Text);
                    // Try parsing new rate
                    try
                    {
                        double newRate = double.Parse(rateTextField.Text);
                        string newPosition = positionComboBox.Items[positionComboBox.SelectedIndex].ToString();
                        string newDepartment = departmentComboBox.Items[departmentComboBox.SelectedIndex].ToString();
                        int currentEmployee = employeeIDComboBox.SelectedIndex;
                        int currentEmployeeId = int.Parse(employeeIDComboBox.Items[currentEmployee].ToString());
                        int currentMonth = monthComboBox.SelectedIndex;

                        // Confirmation box before saving the data
						var result = MessageBox.Show("Do you wish to update the information of " + employeeArray[currentEmployee].FirstName + " " + employeeArray[currentEmployee].LastName + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                        if (result == DialogResult.Yes)
                        {
                        	// Save new data
	                        employeeArray[currentEmployee].Salary = newRate;
	                        employeeArray[currentEmployee].Position = newPosition;
	                        employeeArray[currentEmployee].Department = newDepartment;
	                        if (!medicalCheckBox.Checked)
	                            employeeArray[currentEmployee].Insurance = 0.0;
	                        if (!lifeInsuranceCheckBox.Checked)
	                            employeeArray[currentEmployee].LifeInsurance = 0.0;
	                        if (!fourCheckBox.Checked)
	                            employeeArray[currentEmployee].Retirement = 0.0;
	                        if (!fsaCheckBox.Checked)
	                            employeeArray[currentEmployee].FSA = 0.0;
	                        for (int i = 0; i < monthsArray[currentMonth].employeeIds.Length; i++)
	                        {
	                            if (monthsArray[currentMonth].employeeIds[i] == currentEmployeeId)
	                                monthsArray[currentMonth].employeeHours[i] = newHours;
	                        }
	
	                        // Success message
	                        MessageBox.Show("Employee information updated.");
                        }
                        else
                        	MessageBox.Show("Update cancelled.");
                        
                        
                    }
                    catch (FormatException ex)
                    {
                        MessageBox.Show("Please enter a valid decimal number for rate.");
                        rateTextField.Focus();
                    }
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Please enter a valid decimal number for hours.");
                    hoursTextField.Focus();
                }
            }
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Save all files
            DataProcessing employeeFile = new DataProcessing("data/master.dat", false);

            // Loop through employees and write line to master.dat
            for (int i = 0; i < employeeCountInt; i++)
            {
                // Store temporary data to list
                List<string> dataList = new List<string>();
                dataList.Add(employeeArray[i].ID.ToString());
                dataList.Add(employeeArray[i].FirstName);
                dataList.Add(employeeArray[i].LastName);
                dataList.Add(employeeArray[i].Department);
                dataList.Add(employeeArray[i].Position);
                dataList.Add(employeeArray[i].Salary.ToString());
                dataList.Add(employeeArray[i].Insurance.ToString());
                dataList.Add(employeeArray[i].LifeInsurance.ToString());
                dataList.Add(employeeArray[i].Retirement.ToString());
                dataList.Add(employeeArray[i].FSA.ToString());
                // Write line to file
                employeeFile.setLine(dataList.ToArray());
            }
            // Close employee file
            employeeFile.closeFile();
            employeeFile = null;

            // Loop through months
            int curMonth = 0;
            while (curMonth < MAX_MONTHS)
            {
                DataProcessing monthFile = new DataProcessing();
                if (curMonth == 0)
                    monthFile.DataFile = "data/jan.dat";
                else if (curMonth == 1)
                    monthFile.DataFile = "data/feb.dat";
                else if (curMonth == 2)
                    monthFile.DataFile = "data/mar.dat";
                else if (curMonth == 3)
                    monthFile.DataFile = "data/apr.dat";
                else if (curMonth == 4)
                    monthFile.DataFile = "data/may.dat";
                else if (curMonth == 5)
                    monthFile.DataFile = "data/jun.dat";
                else if (curMonth == 6)
                    monthFile.DataFile = "data/jul.dat";
                else if (curMonth == 7)
                    monthFile.DataFile = "data/aug.dat";
                else if (curMonth == 8)
                    monthFile.DataFile = "data/sep.dat";
                else if (curMonth == 9)
                    monthFile.DataFile = "data/oct.dat";
                else if (curMonth == 10)
                    monthFile.DataFile = "data/nov.dat";
                else if (curMonth == 11)
                    monthFile.DataFile = "data/dec.dat";
                monthFile.ReadFile = false;

                for (int i = 0; i < monthsArray[curMonth].employeeIds.Length; i++)
                {
                    // Store temporary data to list
                    List<string> dataList = new List<string>();
                    dataList.Add(monthsArray[curMonth].employeeIds[i].ToString());
                    dataList.Add(monthsArray[curMonth].employeeHours[i].ToString());
                    // Write line
                    monthFile.setLine(dataList.ToArray());
                }
                // Close month file
                monthFile.closeFile();
                monthFile = null;

                curMonth++;
            }

            // Success message
            MessageBox.Show("Saved data files successfully.");
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            // Remove selected employee
            if (employeeIDComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an employee to remove.");
            }
            else
            {
                int selectedEmployee = employeeIDComboBox.SelectedIndex;
                int selectedEmployeeID = employeeArray[selectedEmployee].ID;
                Employee[] tempArray = new Employee[MAX_EMPLOYEES];

                // Copy values from main array to temp array
                int k = 0;
                for(int i = 0; i < employeeCountInt; i++)
                {
                    if (employeeArray[i].ID != selectedEmployeeID)
                    {
                        tempArray[k] = new Employee();
                        tempArray[k].ID = employeeArray[i].ID;
                        tempArray[k].FirstName = employeeArray[i].FirstName;
                        tempArray[k].LastName = employeeArray[i].LastName;
                        tempArray[k].Department = employeeArray[i].Department;
                        tempArray[k].Position = employeeArray[i].Position;
                        tempArray[k].Salary = employeeArray[i].Salary;
                        tempArray[k].Insurance = employeeArray[i].Insurance;
                        tempArray[k].LifeInsurance = employeeArray[i].LifeInsurance;
                        tempArray[k].Retirement = employeeArray[i].Retirement;
                        tempArray[k].FSA = employeeArray[i].FSA;
                        k++;
                    }
                }
                
                // Clear main array and copy values back
                //employeeArray = null;
                //employeeArray = new Employee[MAX_EMPLOYEES];
                employeeCountInt = 0;
                for(int i = 0; i < k; i++)
                {
                    employeeArray[i] = new Employee();
                    employeeArray[i].ID = tempArray[i].ID;
                    employeeArray[i].FirstName = tempArray[i].FirstName;
                    employeeArray[i].LastName = tempArray[i].LastName;
                    employeeArray[i].Department = tempArray[i].Department;
                    employeeArray[i].Position = tempArray[i].Position;
                    employeeArray[i].Salary = tempArray[i].Salary;
                    employeeArray[i].Insurance = tempArray[i].Insurance;
                    employeeArray[i].LifeInsurance = tempArray[i].LifeInsurance;
                    employeeArray[i].Retirement = tempArray[i].Retirement;
                    employeeArray[i].FSA = tempArray[i].FSA;
                    employeeCountInt++;
                }

                // Refresh form values
                employeeIDComboBox.Items.Clear();
                employeeFirstNameComboBox.Items.Clear();
                employeeLastNameComboBox.Items.Clear();
                clearForm();
                for (int i = 0; i < employeeCountInt; i++)
                {
                    employeeIDComboBox.Items.Add(employeeArray[i].ID);
                    employeeFirstNameComboBox.Items.Add(employeeArray[i].FirstName);
                    employeeLastNameComboBox.Items.Add(employeeArray[i].LastName);
                }

                // Success message
                MessageBox.Show("Employee removed.");
            }
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            // Print monthly report
            if (monthComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a month to print a document for.");
            }
            else if (employeeIDComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an employee to print a document for.");
            }
            else if (employeeFirstNameComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an employee to print a document for.");
            }
            else if (employeeLastNameComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an employee to print a document for.");
            }
            else
            {
                // Calculate totals
                int employeeId = employeeArray[employeeIDComboBox.SelectedIndex].ID;
                employeeArray[employeeIDComboBox.SelectedIndex].resetTotals();

                for (int i = 0; i < monthsArray.Length; i++)
                {
                    double monthHours = 0.0;
                    // Find corresponding hours
                    for (int k = 0; k < monthsArray[i].employeeIds.Length; k++)
                    {
                        if (monthsArray[i].employeeIds[k] == employeeId)
                        {
                            monthHours = monthsArray[i].employeeHours[k];
                        }
                    }

                    // Run calculations
                    employeeArray[employeeIDComboBox.SelectedIndex].calculateMonth(i, monthHours);
                }

                // Show print preview
                printPreviewDialog1.Document = employeeMonthlyDocument;
                printPreviewDialog1.ShowDialog();
            }
        }

        private void employeeMonthlyDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Generate monthly report
            int selectedMonth = monthComboBox.SelectedIndex;
            int selectedEmployee = employeeIDComboBox.SelectedIndex;
            Font headerFont = new Font("Courier", 16, FontStyle.Bold);
            Font docFont = new Font("Courier", 12);
            float xFloat = e.MarginBounds.Left;
            float yFloat = e.MarginBounds.Top;
            float fontHeight = docFont.GetHeight();

            // Set pay type and hours worked
            double hoursWorked = 0.0;
            string payType = "";
            if (employeeArray[selectedEmployee].Position == "Manager" || employeeArray[selectedEmployee].Position == "Engineer")
                payType = "Salary";
            else
                payType = "Hourly";
            for (int i = 0; i < monthsArray[selectedMonth].employeeIds.Length; i++)
            {
                if (monthsArray[selectedMonth].employeeIds[i] == employeeArray[selectedEmployee].ID)
                {
                    hoursWorked = monthsArray[selectedMonth].employeeHours[i];
                }
            }

            // Draw title string
            if (selectedMonth == 0)
                e.Graphics.DrawString("January report for " + employeeArray[selectedEmployee].FirstName + " " + employeeArray[selectedEmployee].LastName, headerFont, Brushes.Black, xFloat, yFloat);
            else if (selectedMonth == 1)
                e.Graphics.DrawString("February report for " + employeeArray[selectedEmployee].FirstName + " " + employeeArray[selectedEmployee].LastName, headerFont, Brushes.Black, xFloat, yFloat);
            else if (selectedMonth == 2)
                e.Graphics.DrawString("March report for " + employeeArray[selectedEmployee].FirstName + " " + employeeArray[selectedEmployee].LastName, headerFont, Brushes.Black, xFloat, yFloat);
            else if (selectedMonth == 3)
                e.Graphics.DrawString("April report for " + employeeArray[selectedEmployee].FirstName + " " + employeeArray[selectedEmployee].LastName, headerFont, Brushes.Black, xFloat, yFloat);
            else if (selectedMonth == 4)
                e.Graphics.DrawString("May report for " + employeeArray[selectedEmployee].FirstName + " " + employeeArray[selectedEmployee].LastName, headerFont, Brushes.Black, xFloat, yFloat);
            else if (selectedMonth == 5)
                e.Graphics.DrawString("June report for " + employeeArray[selectedEmployee].FirstName + " " + employeeArray[selectedEmployee].LastName, headerFont, Brushes.Black, xFloat, yFloat);
            else if (selectedMonth == 6)
                e.Graphics.DrawString("July report for " + employeeArray[selectedEmployee].FirstName + " " + employeeArray[selectedEmployee].LastName, headerFont, Brushes.Black, xFloat, yFloat);
            else if (selectedMonth == 7)
                e.Graphics.DrawString("August report for " + employeeArray[selectedEmployee].FirstName + " " + employeeArray[selectedEmployee].LastName, headerFont, Brushes.Black, xFloat, yFloat);
            else if (selectedMonth == 8)
                e.Graphics.DrawString("September report for " + employeeArray[selectedEmployee].FirstName + " " + employeeArray[selectedEmployee].LastName, headerFont, Brushes.Black, xFloat, yFloat);
            else if (selectedMonth == 9)
                e.Graphics.DrawString("October report for " + employeeArray[selectedEmployee].FirstName + " " + employeeArray[selectedEmployee].LastName, headerFont, Brushes.Black, xFloat, yFloat);
            else if (selectedMonth == 10)
                e.Graphics.DrawString("November report for " + employeeArray[selectedEmployee].FirstName + " " + employeeArray[selectedEmployee].LastName, headerFont, Brushes.Black, xFloat, yFloat);
            else if (selectedMonth == 11)
                e.Graphics.DrawString("December report for " + employeeArray[selectedEmployee].FirstName + " " + employeeArray[selectedEmployee].LastName, headerFont, Brushes.Black, xFloat, yFloat);
            yFloat += fontHeight * 3;

            // Draw document contents
            e.Graphics.DrawString("ID:\t\t" + employeeArray[selectedEmployee].ID.ToString(), docFont, Brushes.Black, xFloat, yFloat);
            yFloat += fontHeight;
            e.Graphics.DrawString("Employee Name:\t" + employeeArray[selectedEmployee].FirstName + " " + employeeArray[selectedEmployee].LastName, docFont, Brushes.Black, xFloat, yFloat);
            yFloat += fontHeight;
            e.Graphics.DrawString("Department:\t" + employeeArray[selectedEmployee].Department, docFont, Brushes.Black, xFloat, yFloat);
            yFloat += fontHeight;
            e.Graphics.DrawString("Position:\t\t" + employeeArray[selectedEmployee].Position, docFont, Brushes.Black, xFloat, yFloat);
            yFloat += fontHeight;
            e.Graphics.DrawString("Pay Type:\t" + payType, docFont, Brushes.Black, xFloat, yFloat);
            yFloat += fontHeight;
            e.Graphics.DrawString("Hours Worked:\t" + hoursWorked.ToString(), docFont, Brushes.Black, xFloat, yFloat);
            yFloat += fontHeight;
            e.Graphics.DrawString("Gross Pay:\t" + employeeArray[selectedEmployee].MonthlyGrossPay[selectedMonth].ToString("C"), docFont, Brushes.Black, xFloat, yFloat);
            yFloat += fontHeight;
            e.Graphics.DrawString("Medical/Dental:\t" + employeeArray[selectedEmployee].MonthlyMedical[selectedMonth].ToString("C"), docFont, Brushes.Black, xFloat, yFloat);
            yFloat += fontHeight;
            e.Graphics.DrawString("Life Insurance:\t" + employeeArray[selectedEmployee].MonthlyLifeInsurance[selectedMonth].ToString("C"), docFont, Brushes.Black, xFloat, yFloat);
            yFloat += fontHeight;
            e.Graphics.DrawString("401k:\t\t" + employeeArray[selectedEmployee].MonthlyRetirement[selectedMonth].ToString("C"), docFont, Brushes.Black, xFloat, yFloat);
            yFloat += fontHeight;
            e.Graphics.DrawString("FSA:\t\t" + employeeArray[selectedEmployee].MonthlyFSA[selectedMonth].ToString("C"), docFont, Brushes.Black, xFloat, yFloat);
            yFloat += fontHeight;
            e.Graphics.DrawString("Social Security:\t" + employeeArray[selectedEmployee].MonthlySocialSecurity[selectedMonth].ToString("C"), docFont, Brushes.Black, xFloat, yFloat);
            yFloat += fontHeight;
            e.Graphics.DrawString("Federal Tax:\t" + employeeArray[selectedEmployee].MonthlyFederalIncomeTax[selectedMonth].ToString("C"), docFont, Brushes.Black, xFloat, yFloat);
            yFloat += fontHeight;
            e.Graphics.DrawString("State Tax:\t" + employeeArray[selectedEmployee].MonthlyStateIncomeTax[selectedMonth].ToString("C"), docFont, Brushes.Black, xFloat, yFloat);
            yFloat += fontHeight;
            e.Graphics.DrawString("Net Pay:\t\t" + employeeArray[selectedEmployee].MonthlyNetPay[selectedMonth].ToString("C"), docFont, Brushes.Black, xFloat, yFloat);
            yFloat += fontHeight;
        }
	}
}
