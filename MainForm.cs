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
			DataProcessing LoadData = new DataProcessing();
		}
	}
}
