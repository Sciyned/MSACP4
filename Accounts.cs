/*  Program:        
    Author:         Mike Chiu/Oscar Campos
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
		// Declare temporary variables to assign to lists
		private int employeeIDInteger;
		private double employeeSalaryDouble, employeeMedicalInsuranceDouble, employeeLifeInsuranceDouble, employeeRetirementDouble, employeeFsaDouble;
		private String employeeFirstNameString, employeeLastNameString, employeeDepartmentString, employeePositionString;
		
		// Declare lists to hold employee information
		private List<int> employeeID = new List<int>();
		private List<String> employeeFirstName = new List<String>();
		private List<String> employeeLastName = new List<String>();
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
		
		// Mutator Methods
		public int setEmployeeID
		{
			set
			{
				employeeIDInteger = value;
			}
		}
		public String setFirstName
		{
			set
			{
				employeeFirstNameString = value;
			}
		}
		public String setLastName
		{
			set
			{
				employeeLastNameString = value;
			}
		}
		public String setDepartment
		{
			set
			{
				employeeDepartmentString = value;
			}
		}
		public String setPosition
		{
			set
			{
				employeePositionString = value;
			}
		}
		public double setSalary
		{
			set
			{
				employeeSalaryDouble = value;
			}
		}
		public double setMedicalInsurance
		{
			set
			{
				employeeMedicalInsuranceDouble = value;
			}
		}
		public double setLifeInsurance
		{
			set
			{
				employeeLifeInsuranceDouble = value;
			}
		}
		public double setRetirement
		{
			set
			{
				employeeRetirementDouble = value;
			}
		}
		public double setFsa
		{
			set
			{
				employeeFsaDouble = value;
			}
		}
		
		// Accessor Methods
		public int getEmployeeID()
		{
			return employeeIDInteger;
		}
		public double getSalary()
		{
			return employeeSalaryDouble;
		}
		public String getFirstName()
		{
			return employeeFirstNameString;
		}
		public String getLastName()
		{
			return employeeLastNameString;
		}
		public String getPosition()
		{
			return employeePositionString;
		}
		public String getDepartment()
		{
			return employeeDepartmentString;
		}
	}
}
