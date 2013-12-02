/*  Program:        
    Author:         Mike Chiu/Oscar Campos
    Class:          CISP41
    Date:           
    Description: 	Allows the user to make more specific adjustments to the employee.

    I certify that the code below is my own work.
 
 Exception(s): N/A

*/

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project4
{
	/// <summary>
	/// The EditEmployee form is to make more detailed adjustments to the specific employee. Compared
	/// to the MainForm, EditEmployee form has more information regarding the employee, in terms of
	/// deduction amounts.
	/// </summary>
	public partial class EditEmployee : Form
	{
		// Declare variables for 
        int employeeCountInt = 0;

		// Instantiate Objects from other classes
        Employee[] employeeArray;

        // Property method for passing employee information
        public Employee[] EmployeeArray
        {
            get
            {
                return employeeArray;
            }
            set
            {
                employeeArray = value;
            }
        }

        public int EmployeeCount
        {
            get
            {
                return employeeCountInt;
            }
            set
            {
                employeeCountInt = value;
            }
        }
		
		public EditEmployee()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void HelpToolStripMenuItem1Click(object sender, EventArgs e)
		{
			// Instantiate Help
			EditHelp showForm = new EditHelp();
			showForm.ShowDialog();
		}
		
		void CancelButtonClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void EmployeeIDComboBoxSelectedIndexChanged(object sender, EventArgs e)
		{
			// An employee ID needs to be selected in order to modify the attributes of the employee.
			if (employeeIDComboBox.SelectedIndex != -1)
			{
                // Clear form
                clearForm();

                // Enable controls
                basicGroupBox.Enabled = true;
                financialGroupBox.Enabled = true;
                employmentGroupBox.Enabled = true;
                deductionsGroupBox.Enabled = true;
                newMedicalTextField.Enabled = true;
                newLifeInsuranceTextField.Enabled = true;
                newRetirementTextField.Enabled = true;
                newFsaTextField.Enabled = true;
                
                // Enable groupboxes based on deductions
                if (medicalInsuranceCheckBox.Checked == true)
					newMedicalTextField.Enabled = true;
				else
					newMedicalTextField.Enabled = false;
				
				if (lifeInsuranceCheckBox.Checked == true)
					newLifeInsuranceTextField.Enabled = true;
				else
					newLifeInsuranceTextField.Enabled = false;

				if (retirementCheckBox.Checked == true)
					newRetirementTextField.Enabled = true;
				else
					newRetirementTextField.Enabled = false;
				
				if (fsaCheckBox.Checked == true)
					newFsaTextField.Enabled = true;
				else
					newFsaTextField.Enabled = false;
				
                // Display proper information in the form
                employeeFirstNameTextField.Text = employeeArray[employeeIDComboBox.SelectedIndex].FirstName;
                employeeLastNameTextField.Text = employeeArray[employeeIDComboBox.SelectedIndex].LastName;
                if (employeeArray[employeeIDComboBox.SelectedIndex].Position == "Manager")
                {
                    employeePositionComboBox.SelectedIndex = 0;
                    salaryRadioButton.Checked = true;
                    newRateTextField.Text = employeeArray[employeeIDComboBox.SelectedIndex].Salary.ToString();
                }
                else if (employeeArray[employeeIDComboBox.SelectedIndex].Position == "Engineer")
                {
                    employeePositionComboBox.SelectedIndex = 1;
                    salaryRadioButton.Checked = true;
                    newRateTextField.Text = employeeArray[employeeIDComboBox.SelectedIndex].Salary.ToString();
                }
                else if (employeeArray[employeeIDComboBox.SelectedIndex].Position == "Technician")
                {
                    employeePositionComboBox.SelectedIndex = 2;
                    hourlyRadioButton.Checked = true;
                    newRateTextField.Text = employeeArray[employeeIDComboBox.SelectedIndex].Salary.ToString();
                }
                else if (employeeArray[employeeIDComboBox.SelectedIndex].Position == "Clerk")
                {
                    employeePositionComboBox.SelectedIndex = 3;
                    hourlyRadioButton.Checked = true;
                    newRateTextField.Text = employeeArray[employeeIDComboBox.SelectedIndex].Salary.ToString();
                }
                else if (employeeArray[employeeIDComboBox.SelectedIndex].Position == "Producer")
                {
                    employeePositionComboBox.SelectedIndex = 4;
                    hourlyRadioButton.Checked = true;
                    newRateTextField.Text = employeeArray[employeeIDComboBox.SelectedIndex].Salary.ToString();
                }
                // Select proper department
                if (employeeArray[employeeIDComboBox.SelectedIndex].Department == "HR")
                    employeeDepartmentComboBox.SelectedIndex = 0;
                else if (employeeArray[employeeIDComboBox.SelectedIndex].Department == "Accounting")
                    employeeDepartmentComboBox.SelectedIndex = 1;
                else if (employeeArray[employeeIDComboBox.SelectedIndex].Department == "R&D")
                    employeeDepartmentComboBox.SelectedIndex = 2;
                else if (employeeArray[employeeIDComboBox.SelectedIndex].Department == "Sales")
                    employeeDepartmentComboBox.SelectedIndex = 3;
                else if (employeeArray[employeeIDComboBox.SelectedIndex].Department == "Production")
                    employeeDepartmentComboBox.SelectedIndex = 4;
                // Select proper deductions
                if (employeeArray[employeeIDComboBox.SelectedIndex].Insurance != 0.0)
                {
                    medicalInsuranceCheckBox.Checked = true;
                    newMedicalTextField.Text = employeeArray[employeeIDComboBox.SelectedIndex].Insurance.ToString();
                }
                if (employeeArray[employeeIDComboBox.SelectedIndex].LifeInsurance != 0.0)
                {
                    lifeInsuranceCheckBox.Checked = true;
                    newLifeInsuranceTextField.Text = employeeArray[employeeIDComboBox.SelectedIndex].LifeInsurance.ToString();
                }
                if (employeeArray[employeeIDComboBox.SelectedIndex].Retirement != 0.0)
                {
                    retirementCheckBox.Checked = true;
                    newRetirementTextField.Text = employeeArray[employeeIDComboBox.SelectedIndex].Retirement.ToString();
                }
                if (employeeArray[employeeIDComboBox.SelectedIndex].FSA != 0.0)
                {
                    fsaCheckBox.Checked = true;
                    newFsaTextField.Text = employeeArray[employeeIDComboBox.SelectedIndex].FSA.ToString();
                }
			}
		}

        void clearForm()
        {
            // Clear the form for other data
            employeeFirstNameTextField.Text = "";
            employeeLastNameTextField.Text = "";
            employeePositionComboBox.SelectedIndex = -1;
            employeeDepartmentComboBox.SelectedIndex = -1;
            salaryRadioButton.Checked = false;
            hourlyRadioButton.Checked = false;
            //newHoursTextField.Text = "";
            newRateTextField.Text = "";
            medicalInsuranceCheckBox.Checked = false;
            newMedicalTextField.Text = "0";
            lifeInsuranceCheckBox.Checked = false;
            newLifeInsuranceTextField.Text = "0";
            retirementCheckBox.Checked = false;
            newRetirementTextField.Text = "0";
            fsaCheckBox.Checked = false;
            newFsaTextField.Text = "0";
        }

        private void EditEmployee_Load(object sender, EventArgs e)
        {
            // Insert values on form load
            for (int i = 0; i < employeeCountInt; i++)
            {
                employeeIDComboBox.Items.Add(employeeArray[i].ID);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            // Update values
            if (employeeIDComboBox.SelectedIndex != -1)
            {
                if (employeeFirstNameTextField.Text == "")
                {
                    MessageBox.Show("Please enter a First Name.");
                    employeeFirstNameTextField.Focus();
                }
                else if (employeeLastNameTextField.Text == "")
                {
                    MessageBox.Show("Please enter a Last Name.");
                    employeeLastNameTextField.Focus();
                }
                else if (employeePositionComboBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a Position.");
                }
                else if (employeeDepartmentComboBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a Department.");
                }
                /*else if (newHoursTextField.Text == "")
                {
                    MessageBox.Show("Please enter hours worked.");
                    newHoursTextField.Focus();
                }*/
                else if (newRateTextField.Text == "")
                {
                    MessageBox.Show("Please enter a pay rate.");
                    newRateTextField.Focus();
                }
                else
                {
                    if (medicalInsuranceCheckBox.Checked && newMedicalTextField.Text == "")
                    {
                        MessageBox.Show("Please enter a medical insurance deductible amount.");
                        newMedicalTextField.Focus();
                    }
                    else if (lifeInsuranceCheckBox.Checked && newLifeInsuranceTextField.Text == "")
                    {
                        MessageBox.Show("Please enter a life insurance deductible amount.");
                        newLifeInsuranceTextField.Focus();
                    }
                    else if (retirementCheckBox.Checked && newRetirementTextField.Text == "")
                    {
                        MessageBox.Show("Please enter a 401k deductible amount.");
                        newRetirementTextField.Focus();
                    }
                    else if (fsaCheckBox.Checked && newFsaTextField.Text == "")
                    {
                        MessageBox.Show("Please enter an FSA deductible amount.");
                        newFsaTextField.Focus();
                    }
                    else
                    {
                        string employeeFirstName = employeeFirstNameTextField.Text;
                        string employeeLastName = employeeLastNameTextField.Text;
                        int employeePosition = employeePositionComboBox.SelectedIndex;
                        int employeeDepartment = employeeDepartmentComboBox.SelectedIndex;
                        int selectedEmployee = employeeIDComboBox.SelectedIndex;

                        // Try parsing rate
                        try
                       	{
                        	double employeeRate = double.Parse(newRateTextField.Text);
                            // Try parsing medical
							try
							{
								double medicalDeductible = double.Parse(newMedicalTextField.Text);
								// Try parsing life insurance
								try
								{
									double lifeInsuranceDeductible = double.Parse(newLifeInsuranceTextField.Text);
									// Try parsing 401k deductible
									try
									{
										double retirementDeductible = double.Parse(newRetirementTextField.Text);
										// Try parsing fsa deductible
										try
										{
											double fsaDeductible = double.Parse(newFsaTextField.Text);

											// Updating confirmation dialog box
											var result = MessageBox.Show("Do you wish to update the information of " + employeeArray[selectedEmployee].FirstName + " " + employeeArray[selectedEmployee].LastName + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
											if (result == DialogResult.Yes)
											{
												// Save new values
												employeeArray[selectedEmployee].FirstName = employeeFirstName;
												employeeArray[selectedEmployee].LastName = employeeLastName;
												employeeArray[selectedEmployee].Position = employeePositionComboBox.Items[employeePosition].ToString();
												employeeArray[selectedEmployee].Department = employeeDepartmentComboBox.Items[employeeDepartment].ToString();
												employeeArray[selectedEmployee].Salary = employeeRate;
												if (medicalInsuranceCheckBox.Checked)
													employeeArray[selectedEmployee].Insurance = medicalDeductible;
												else
													employeeArray[selectedEmployee].Insurance = 0.0;
												if (lifeInsuranceCheckBox.Checked)
													employeeArray[selectedEmployee].LifeInsurance = lifeInsuranceDeductible;
												else
													employeeArray[selectedEmployee].LifeInsurance = 0.0;
												if (retirementCheckBox.Checked)
													employeeArray[selectedEmployee].Retirement = retirementDeductible;
												else
													employeeArray[selectedEmployee].Retirement = 0.0;
												if (fsaCheckBox.Checked)
													employeeArray[selectedEmployee].FSA = fsaDeductible;
												else
													employeeArray[selectedEmployee].FSA = 0.0;

												// Success message
												MessageBox.Show("Employee information updated.");
											}
											else
												MessageBox.Show("Update cancelled.");
											
										}
										catch (FormatException ex)
										{
											MessageBox.Show("Please enter a valid decimal number for FSA amount.");
											newFsaTextField.Focus();
										}
									}
									catch (FormatException ex)
									{
										MessageBox.Show("Please enter a valid decimal number for 401k amount.");
										newRetirementTextField.Focus();
									}
								}
								catch (FormatException ex)
								{
									MessageBox.Show("Please enter a valid decimal number for life insurance amount.");
									newLifeInsuranceTextField.Focus();
								}
							}
							catch (FormatException ex)
							{
								MessageBox.Show("Please enter a valid decimal number for medical insurance amount.");
								newMedicalTextField.Focus();
							}
                        }
						catch (FormatException ex)
                    	{
                        	MessageBox.Show("Please enter a valid decimal number for rate.");
                        	newRateTextField.Focus();
                    	}	                              
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an employee to edit.");
            }
        }
		
		void MedicalInsuranceCheckBoxCheckedChanged(object sender, EventArgs e)
		{
			if (medicalInsuranceCheckBox.Checked == true)
				newMedicalTextField.Enabled = true;
			else
				newMedicalTextField.Enabled = false;
		}
		
		void LifeInsuranceCheckBoxCheckedChanged(object sender, EventArgs e)
		{
			if (lifeInsuranceCheckBox.Checked == true)
				newLifeInsuranceTextField.Enabled = true;
			else
				newLifeInsuranceTextField.Enabled = false;
		}
		
		void RetirementCheckBoxCheckedChanged(object sender, EventArgs e)
		{
			if (retirementCheckBox.Checked == true)
				newRetirementTextField.Enabled = true;
			else
				newRetirementTextField.Enabled = false;
		}
		
		void FsaCheckBoxCheckedChanged(object sender, EventArgs e)
		{
			if (fsaCheckBox.Checked == true)
				newFsaTextField.Enabled = true;
			else
				newFsaTextField.Enabled = false;
		}
	}
}
