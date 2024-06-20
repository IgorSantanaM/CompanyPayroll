﻿using System;

public class BasePlusCommissionEmployee : CommissionEmployee
{
    private decimal baseSalary; // base salary per week
    public BasePlusCommissionEmployee(string first, string last,
        string ssn, decimal sales, decimal rate, decimal salary) : base(first, last, ssn, sales, rate)
    {
        BaseSalary = salary; // validate base salary via property
    } // end six-parameter BasePlusCommissionEmployee constructor
        
    public decimal BaseSalary
    {
        get
        {
            return baseSalary;
        } // end get
        set
        {
            if (value >= 0)
                baseSalary = value;
            else
                throw new ArgumentOutOfRangeException("BaseSalary",
                    value, "BaseSalary must be >= 0");
        } // end set
    } // end property BaseSalary

    public override decimal Earnings()
    {
        return baseSalary + base.Earnings();
    } // end method Earnings

    public override string ToString()
    {
        return string.Format("base-salaried {0}\nbase salary: {1:C}",
        base.ToString(), BaseSalary);
    } // end method ToString
} // end class BasePlusCommissionEmployee
