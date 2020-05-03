using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Fundamentals
{
    class TaxPayer
    {
        private string socialSecurityNumber;
        private double yearlyGrossIncome;
        private double taxOwed;

        public string SocialSecurityNumber 
        {
            get
            {
                return socialSecurityNumber;
            }
            set
            {
                socialSecurityNumber = value;
            }
        }
        public double YearlyGrossIncome
        {
            get
            {
                return yearlyGrossIncome;
            }
            set
            {
                yearlyGrossIncome = value;
                CalculateTax();
            }
        }
        public double TaxOwed {
            get
            {
                return taxOwed;
            }
        }

        public TaxPayer(string SSN,double income)
        {
            SocialSecurityNumber = SSN;
            YearlyGrossIncome = income;
        }

        private void CalculateTax()
        {
            if (yearlyGrossIncome < 30000)
                taxOwed = yearlyGrossIncome * 0.15;
            else
                taxOwed = yearlyGrossIncome * 0.28;
        }
    }
}
