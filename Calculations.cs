/*  Program:        
    Author:         Mike Chiu
    Class:          CISP41
    Date:           
    Description: 

    I certify that the code below is my own work.
 
 Exception(s): N/A

*/

using System;

namespace Project4
{
	/// <summary>
	/// Calculations.cs is for calculating all of the business elements of this application. Should there
	/// be an additional portion that must be calculated, please put it in this class.
	/// </summary>
	public class Calculations
	{
		public Calculations()
		{
			
		}
		
		// Declare variables
		double medicalBenefitsDouble;
		double lifeInsuranceDouble;
		double retirementPlanDouble;
		double fsaDouble;
		
		bool medicalBenefitsBoolean = false;
		bool lifeInsuranceBoolean = false;
		bool retirementPlanBoolean = false;
		bool fsaBoolean = false;
		
		double salaryDouble;
		
		// Declare constants: These constants are mandatory in calculation
		const double SOCIAL_SECURITY_TAX_DOUBLE = 0.10;
		const double FEDERAL_INCOME_TAX_DOUBLE = 0.15;
		const double STATE_INCOME_TAX_DOUBLE = 0.05;
		
		// Mutator methods
		public bool setMedicalBenefitsValidation
		{
			set
			{
				medicalBenefitsBoolean = value;
			}
		}
		public bool setLifeInsuranceValidation
		{
			set
			{
				lifeInsuranceBoolean = value;
			}
		}
		public bool setRetirementPlanValidation
		{
			set
			{
				retirementPlanBoolean = value;
			}
		}
		public bool setFsaValidation
		{
			set
			{
				fsaBoolean = value;
			}
		}
		
		
		public double setMedicalBenefits
		{
			set
			{
				medicalBenefitsDouble = value;
			}
		}
		public double setLifeInsurance
		{
			set
			{
				lifeInsuranceDouble = value;
			}
		}
		public double setRetirementPlan
		{
			set
			{
				retirementPlanDouble = value;
			}
		}
		public double setFsa
		{
			set
			{
				fsaDouble = value;
			}
		}
		public double setSalary
		{
			set
			{
				salaryDouble = value;
			}
		}
		
		// Accessor methods
		public double getMedicalBenefits()
		{
			return medicalBenefitsDouble;
		}
		public double getLifeInsurance()
		{
			return lifeInsuranceDouble;
		}
		public double getRetirementPlan()
		{
			return retirementPlanDouble;
		}
		public double getFsa()
		{
			return fsaDouble;
		}
		public double getTotalSalary()
		{
			return salaryDouble;
		}
		
		// Methods for Calculations.cs
		private void calculateDeductibles()
		{
			if (medicalBenefitsBoolean == true)
			{
				salaryDouble -= medicalBenefitsDouble;
			}
			else if (lifeInsuranceBoolean == true)
			{
				salaryDouble -= lifeInsuranceDouble;
			}
			else if (retirementPlanBoolean == true)
			{
				salaryDouble -= retirementPlanDouble;
			}
			else if(fsaBoolean == true)
			{
				salaryDouble -= fsaDouble;
			}
		}
		
		private void calculateTaxes()
		{
			double socialSecurityTax;
			double federalIncomeTax;
			double stateIncomeTax;
			
			calculateDeductibles();
			socialSecurityTax = salaryDouble * SOCIAL_SECURITY_TAX_DOUBLE;
			federalIncomeTax = salaryDouble * FEDERAL_INCOME_TAX_DOUBLE;
			stateIncomeTax = salaryDouble * STATE_INCOME_TAX_DOUBLE;
			
			salaryDouble = salaryDouble - (socialSecurityTax + federalIncomeTax + stateIncomeTax);
			
		}
	}
}
