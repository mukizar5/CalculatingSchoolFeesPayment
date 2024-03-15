namespace Calculating_School_Fees_Payment.@enum 
{
public class Child
{
public string? Name { get; set; }
public Schools School { get; set; }
public Grade Grade ;



public decimal CalculateFeesBySchoolAndGrade(Schools school, Grade grade)
{
    decimal fees = 0;

    switch (school)
    {
        case Schools.kabojjaJuniorSchool:
            fees = grade+ 1000;
            break;
       
        default:
            Console.WriteLine("Invalid School");
            break;
    }
    return fees;

    
}
}
}

