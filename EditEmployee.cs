/*  Program:        
    Author:         Mike Chiu
    Class:          CISP41
    Date:           
    Description: 

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
		Accounts accountAccess = new Accounts();
		
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
		
		
		void EmployeeIDComboBoxSelectedIndexChanged(object sender, EventArgs e)
		{
			if (employeeIDComboBox.SelectedIndex != -1)
			{
				basicGroupBox.Enabled = true;
				financialGroupBox.Enabled = true;
				employmentGroupBox.Enabled = true;
				deductionsGroupBox.Enabled = true;
			}
		}
		
		
		void ExitToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void HelpToolStripMenuItem1Click(object sender, EventArgs e)
		{
			// Instantiate EditHelp
			EditHelp showForm = new EditHelp();
			showForm.ShowDialog();
		}
	}
}
