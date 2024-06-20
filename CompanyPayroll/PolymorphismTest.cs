﻿using System;

public class PolymorphismTest
{
    public static void Main(string[] args)
    {
        // assign base-class reference to base-class variable
        CommissionEmployee commissionEmployee = new CommissionEmployee(
            "Sue", "Jones", "222-22-2222", 10000.00M, 0.06M);

        // assign derived-class reference to derived-class variable
        BasePlusCommissionEmployee basePlusCommissionEmployee = new BasePlusCommissionEmployee(
            "Bob", "Lewis", "333-33-3333", 5000.00M, 0.04M, 300.00M);

        // invoke ToString and Earnings on base-class object using base-class variable
        Console.WriteLine("{0} {1}:\n\n{2}\n{3}: {4:C}\n",
            "Call CommissionEmployee's ToString and Earnings methods",
            "with base-class reference to base class object",
            commissionEmployee.ToString(),
            "earnings", commissionEmployee.Earnings());

        // invoke ToString and Earnings on derived-class object using derived-class variable
        Console.WriteLine("{0} {1}:\n\n{2}\n{3}: {4:C}\n",
            "Call BasePlusCommissionEmployee's ToString and Earnings methods",
            "with derived class reference to derived-class object",
            basePlusCommissionEmployee.ToString(),
            "earnings", basePlusCommissionEmployee.Earnings());

        // invoke ToString and Earnings on derived-class object using base-class variable
        CommissionEmployee commissionEmployee2 = basePlusCommissionEmployee;

        Console.WriteLine("{0} {1}:\n\n{2}\n{3}: {4:C}",
            "Call BasePlusCommissionEmployee's ToString and Earnings methods",
            "with base class reference to derived-class object",
            commissionEmployee2.ToString(),
            "earnings", commissionEmployee2.Earnings());
    }
}
