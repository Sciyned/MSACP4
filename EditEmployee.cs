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
