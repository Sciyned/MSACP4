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
		
		// Instantiate Objects from other classes
		Employee accountAccess = new Employee();
		
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
				basicGroupBox.Enabled = true;
				financialGroupBox.Enabled = true;
				employmentGroupBox.Enabled = true;
				deductionsGroupBox.Enabled = true;
			}
		}
	}
}
