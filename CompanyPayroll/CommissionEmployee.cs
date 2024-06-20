using System;

public class CommissionEmployee
{
    private string firstName;
    private string lastName;
    private string socialSecurityNumber;
    private decimal grossSales; // gross weekly sales
    private decimal commissionRate; // commission percentage
    public CommissionEmployee(string first, string last, string ssn, decimal sales, decimal rate)
    {
        firstName = first;
        lastName = last;
        socialSecurityNumber = ssn;
        GrossSales = sales;
        CommissionRate = rate;
    }
    public string FirstName
    {
        get { return firstName; }
    }

    public string LastName
    {
        get { return lastName; }
    }

    public string SocialSecurityNumber
    {
        get { return socialSecurityNumber; }
    }

    public decimal GrossSales
    {
        get { return grossSales; }
        set
        {
            if (value >= 0)
                grossSales = value;
            else
                throw new ArgumentOutOfRangeException(nameof(GrossSales), value, "GrossSales must be >= 0");
        }
    }

    public decimal CommissionRate
    {
        get { return commissionRate; }
        set
        {
            if (value > 0 && value < 1)
                commissionRate = value;
            else
                throw new ArgumentOutOfRangeException(nameof(CommissionRate), value, "CommissionRate must be > 0 and < 1");
        }
    }

    public virtual decimal Earnings()
    {
        return commissionRate * grossSales;
    }
    

    public override string ToString()
    {
        return string.Format(
            "{0}: {1} {2}\n{3}: {4}\n{5}: {6:C}\n{7}: {8:F2}",
            "commission employee", firstName, lastName,
            "social security number", socialSecurityNumber,
            "gross sales", grossSales, "commission rate", commissionRate);
    }
}
