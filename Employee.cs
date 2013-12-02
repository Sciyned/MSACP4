/*  Program:        
    Author:         Mike Chiu/Oscar Campos
    Class:          CISP41
    Date:           
    Description:    This class stores employee information that will be read from the master.dat file.
                    Calculations for pay, etc. will also be done here.

    I certify that the code below is my own work.
 
 Exception(s): N/A

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project4
{
    public class Employee
    {
        private int employeeIDInt;
        private string employeeFirstNameString;
        private string employeeLastNameString;
        private string employeeDepartmentString;
        private string employeePositionString;
        private double employeeSalaryDouble;
        private double employeeMedicalInsuranceDouble;
        private double employeeLifeInsuranceDouble;
        private double employeeRetirementDouble;
        private double employeeFsaDouble;

        // Default constructor
        public Employee()
        {
            employeeIDInt = 0;
            employeeFirstNameString = "";
            employeeLastNameString = "";
            employeeDepartmentString = "";
            employeePositionString = "";
            employeeSalaryDouble = 0.0;
            employeeMedicalInsuranceDouble = 0.0;
            employeeLifeInsuranceDouble = 0.0;
            employeeRetirementDouble = 0.0;
            employeeFsaDouble = 0.0;
        }

        // Overloaded constructor
        public Employee(int id, string fName, string lName, string department, string position, double salary, double insurance, double lifeInsurance, double retirement, double fsa)
        {
            employeeIDInt = id;
            employeeFirstNameString = fName;
            employeeLastNameString = lName;
            employeeDepartmentString = department;
            employeePositionString = position;
            employeeSalaryDouble = salary;
            employeeMedicalInsuranceDouble = insurance;
            employeeLifeInsuranceDouble = lifeInsurance;
            employeeRetirementDouble = retirement;
            employeeFsaDouble = fsa;
        }

        // Property methods
        public int ID
        {
            get
            {
                return employeeIDInt;
            }
            set
            {
                employeeIDInt = value;
            }
        }

        public string FirstName
        {
            get
            {
                return employeeFirstNameString;
            }
            set
            {
                employeeFirstNameString = value;
            }
        }

        public string LastName
        {
            get
            {
                return employeeLastNameString;
            }
            set
            {
                employeeLastNameString = value;
            }
        }

        public string Department
        {
            get
            {
                return employeeDepartmentString;
            }
            set
            {
                employeeDepartmentString = value;
            }
        }

        public string Position
        {
            get
            {
                return employeePositionString;
            }
            set
            {
                employeePositionString = value;
            }
        }

        public double Salary
        {
            get
            {
                return employeeSalaryDouble;
            }
            set
            {
                employeeSalaryDouble = value;
            }
        }

        public double Insurance
        {
            get
            {
                return employeeMedicalInsuranceDouble;
            }
            set
            {
                employeeMedicalInsuranceDouble = value;
            }
        }

        public double LifeInsurance
        {
            get
            {
                return employeeLifeInsuranceDouble;
            }
            set
            {
                employeeLifeInsuranceDouble = value;
            }
        }

        public double Retirement
        {
            get
            {
                return employeeRetirementDouble;
            }
            set
            {
                employeeRetirementDouble = value;
            }
        }

        public double FSA
        {
            get
            {
                return employeeFsaDouble;
            }
            set
            {
                employeeFsaDouble = value;
            }
        }


    }
}
