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
        // Employee information variables
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

        // Constants
        private const int MAX_MONTHS = 12;
        private const double SOCIAL_SECURITY_TAX = 0.10;
        private const double FEDERAL_INCOME_TAX = 0.15;
        private const double STATE_INCOME_TAX = 0.05;
        private const int MAX_401K_CONTRIBUTION = 17500;

        // Employee earnings/taxes variables
        private double[] monthlyGrossPayArray = new double[MAX_MONTHS];
        private double totalGrossPayDouble = 0;
        private double[] monthlyTaxesArray = new double[MAX_MONTHS];
        private double totalTaxesDouble = 0;
        private double[] monthlyMedicalArray = new double[MAX_MONTHS];
        private double totalMedicalDouble = 0;
        private double[] monthlyLifeInsuranceArray = new double[MAX_MONTHS];
        private double totalLifeInsuranceDouble = 0;
        private double[] monthlyRetirementArray = new double[MAX_MONTHS];
        private double totalRetirementDouble = 0;
        private double[] monthlyFsaArray = new double[MAX_MONTHS];
        private double totalFsaDouble = 0;
        private double[] monthlyNetPayArray = new double[MAX_MONTHS];
        private double totalNetPayDouble = 0;
        private double[] monthlySocialSecurityArray = new double[MAX_MONTHS];
        private double totalSocialSecurityDouble = 0;
        private double[] monthlyFederalIncomeTaxArray = new double[MAX_MONTHS];
        private double totalFederalIncomeTaxDouble = 0;
        private double[] monthlyStateIncomeTaxArray = new double[MAX_MONTHS];
        private double totalStateIncomeTaxDouble = 0;

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

        public double[] MonthlyGrossPay
        {
            get
            {
                return monthlyGrossPayArray;
            }
        }
        public double TotalGrossPay
        {
            get
            {
                return totalGrossPayDouble;
            }
        }

        public double[] MonthlyTaxes
        {
            get
            {
                return monthlyTaxesArray;
            }
        }
        public double TotalTaxes
        {
            get
            {
                return totalTaxesDouble;
            }
        }

        public double[] MonthlyMedical
        {
            get
            {
                return monthlyMedicalArray;
            }
        }
        public double TotalMedical
        {
            get
            {
                return totalMedicalDouble;
            }
        }

        public double[] MonthlyLifeInsurance
        {
            get
            {
                return monthlyLifeInsuranceArray;
            }
        }
        public double TotalLifeInsurance
        {
            get
            {
                return totalLifeInsuranceDouble;
            }
        }

        public double[] MonthlyRetirement
        {
            get
            {
                return monthlyRetirementArray;
            }
        }
        public double TotalRetirement
        {
            get
            {
                return totalRetirementDouble;
            }
        }

        public double[] MonthlyFSA
        {
            get
            {
                return monthlyFsaArray;
            }
        }
        public double TotalFSA
        {
            get
            {
                return totalFsaDouble;
            }
        }

        public double[] MonthlyNetPay
        {
            get
            {
                return monthlyNetPayArray;
            }
        }
        public double TotalNetPay
        {
            get
            {
                return totalNetPayDouble;
            }
        }

        public double[] MonthlySocialSecurity
        {
            get
            {
                return monthlySocialSecurityArray;
            }
        }
        public double TotalSocialSecurity
        {
            get
            {
                return totalSocialSecurityDouble;
            }
        }

        public double[] MonthlyFederalIncomeTax
        {
            get
            {
                return monthlyFederalIncomeTaxArray;
            }
        }
        public double TotalFederalIncomeTax
        {
            get
            {
                return totalFederalIncomeTaxDouble;
            }
        }

        public double[] MonthlyStateIncomeTax
        {
            get
            {
                return monthlyStateIncomeTaxArray;
            }
        }
        public double TotalStateIncomeTax
        {
            get
            {
                return totalStateIncomeTaxDouble;
            }
        }

        public void resetTotals()
        {
            totalGrossPayDouble = 0.0;
            totalTaxesDouble = 0.0;
            totalMedicalDouble = 0.0;
            totalLifeInsuranceDouble = 0.0;
            totalRetirementDouble = 0.0;
            totalFsaDouble = 0.0;
            totalNetPayDouble = 0.0;
            totalSocialSecurityDouble = 0.0;
            totalFederalIncomeTaxDouble = 0.0;
            totalStateIncomeTaxDouble = 0.0;
        }

        // Calculate specified month
        public void calculateMonth(int month, double hours)
        {
            // Validate values
            if (month >= 0 && month < MAX_MONTHS)
            {
                if (hours >= 0)
                {
                    double tempPayDouble = 0;
                    if (employeePositionString == "Manager" || employeePositionString == "Engineer")
                    {
                        // Salary based pay
                        monthlyGrossPayArray[month] = employeeSalaryDouble;
                        totalGrossPayDouble += employeeSalaryDouble;
                        tempPayDouble = employeeSalaryDouble;
                    }
                    else
                    {
                        // Hourly based pay
                        monthlyGrossPayArray[month] = employeeSalaryDouble * hours;
                        totalGrossPayDouble += employeeSalaryDouble * hours;
                        tempPayDouble = employeeSalaryDouble * hours;
                    }

                    // Deductions
                    if (employeeMedicalInsuranceDouble != 0.0)
                    {
                        monthlyMedicalArray[month] = employeeMedicalInsuranceDouble;
                        totalMedicalDouble += employeeMedicalInsuranceDouble;
                        tempPayDouble -= employeeMedicalInsuranceDouble;
                    }
                    else
                    {
                        monthlyMedicalArray[month] = 0.0;
                    }
                    if (employeeLifeInsuranceDouble != 0.0)
                    {
                        monthlyLifeInsuranceArray[month] = employeeLifeInsuranceDouble;
                        totalLifeInsuranceDouble += employeeLifeInsuranceDouble;
                        tempPayDouble -= employeeLifeInsuranceDouble;
                    }
                    else
                    {
                        monthlyLifeInsuranceArray[month] = 0.0;
                    }
                    if (employeeRetirementDouble != 0.0)
                    {
                        double tempRetirement = totalRetirementDouble + employeeRetirementDouble;
                        if (tempRetirement > MAX_401K_CONTRIBUTION)
                        {
                            // 401k limit reached
                            if ((tempRetirement - MAX_401K_CONTRIBUTION) > employeeRetirementDouble)
                            {
                                // 401k already at limit, don't adjust deduction
                                monthlyRetirementArray[month] = 0.0;
                            }
                            else
                            {
                                // 401k reaches limit with this deduction, adjust deduction to stop at limit
                                double adjRetirement = employeeRetirementDouble - (tempRetirement - MAX_401K_CONTRIBUTION);
                                monthlyRetirementArray[month] = adjRetirement;
                                totalRetirementDouble += adjRetirement;
                                tempPayDouble -= adjRetirement;
                            }
                        }
                        else
                        {
                            // Continue to add to 401k
                            monthlyRetirementArray[month] = employeeRetirementDouble;
                            totalRetirementDouble += employeeRetirementDouble;
                            tempPayDouble -= employeeRetirementDouble;
                        }
                    }
                    else
                    {
                        monthlyRetirementArray[month] = 0.0;
                    }
                    if (employeeFsaDouble != 0.0)
                    {
                        monthlyFsaArray[month] = employeeFsaDouble;
                        totalFsaDouble += employeeFsaDouble;
                        tempPayDouble -= employeeFsaDouble;
                    }
                    else
                    {
                        monthlyFsaArray[month] = 0.0;
                    }

                    // Taxes
                    monthlySocialSecurityArray[month] = (tempPayDouble * SOCIAL_SECURITY_TAX);
                    totalSocialSecurityDouble += (tempPayDouble * SOCIAL_SECURITY_TAX);

                    monthlyFederalIncomeTaxArray[month] = (tempPayDouble * FEDERAL_INCOME_TAX);
                    totalFederalIncomeTaxDouble += (tempPayDouble * FEDERAL_INCOME_TAX);

                    monthlyStateIncomeTaxArray[month] = (tempPayDouble * STATE_INCOME_TAX);
                    totalStateIncomeTaxDouble += (tempPayDouble * STATE_INCOME_TAX);

                    monthlyTaxesArray[month] = (monthlySocialSecurityArray[month] + monthlyFederalIncomeTaxArray[month] + monthlyStateIncomeTaxArray[month]);
                    totalTaxesDouble += (monthlySocialSecurityArray[month] + monthlyFederalIncomeTaxArray[month] + monthlyStateIncomeTaxArray[month]);

                    // Get new total
                    tempPayDouble -= (monthlySocialSecurityArray[month] + monthlyFederalIncomeTaxArray[month] + monthlyStateIncomeTaxArray[month]);
                    monthlyNetPayArray[month] = tempPayDouble;
                    totalNetPayDouble += tempPayDouble;
                }
            }
        }
    }
}
