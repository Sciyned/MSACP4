/*  Program:        
    Author:         Mike Chiu/Oscar Campos
    Class:          CISP41
    Date:           
    Description: 	This help form shows what EditEmployee form can do.

    I certify that the code below is my own work.
 
 Exception(s): N/A

*/

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project4
{
	/// <summary>
	/// Description of EditHelp.
	/// </summary>
	public partial class EditHelp : Form
	{
		public EditHelp()
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
	}
}
