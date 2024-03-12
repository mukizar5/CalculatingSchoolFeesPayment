namespace Calculating_School_Fees_Payment.@enum 
{
public class Child
{
public string? Name { get; set; }
public Schools School { get; set; }
public GradeKabojja GradeKabojja ;
public GradeMartys GradeMartys ;
public GradeKampala GradeKampala ;
}

public decimal CalculateFeesBySchoolAndGrade(Schools school, GradeKabojja gradeKabojja, GradeMartys gradeMartys, GradeKampala gradeKampala)
{
    decimal fees = 0;

    switch (school)
    {
        case Schools.kabojjaJuniorSchool:
            fees = (decimal)gradeKabojja + 1000;
            break;
        case Schools.ugandaMartyrsSchool:
            fees = (decimal)gradeMartys + 1200;
            break;
        case Schools.kampalaParentsSchool:
            fees = (decimal)gradeKampala + 1500;
            break;
        default:
            Console.WriteLine("Invalid School");
            break;
    }
    return fees;
}
}
}
