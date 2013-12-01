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
using System.Collections;

namespace Project4
{
	/// <summary>
	/// The purpose of Accounts.cs is to hold all account information. All of the account information will
	/// be stored here and can only be accessed with the proper employee ID (I hope).
	/// </summary>
	public class Accounts
	{
		private List<int> employeeID = new List<int>();
		private List<String> employeeName = new List<String>();
		private List<String> employeeDepartment = new List<String>();
		private List<String> employeePosition = new List<String>();
		private List<double> employeeSalary = new List<double>();
		private List<double> employeeMedicalInsurance = new List<double>();
		private List<double> employeeLifeInsurance = new List<double>();
		private List<double> employeeRetirement = new List<double>();
		private List<double> employeeFsa = new List<double>();
		
		public Accounts()
		{
		}
	}
}
