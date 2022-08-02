namespace SolidPrinciples;
// The Dependency Inversion Principle(DIP) states that a
// high-level class must not depend upon a lower level class.
// They must both depend upon abstractions.And, secondly,
// an abstraction must not depend upon details, but the details must depend upon abstractions.
public class SalaryCalculator
{
    public float CalculateSalary(int hoursWorked, float hourlyRate) => hoursWorked * hourlyRate;
}

public class EmployeeDetails
{
    public int HoursWorked { get; set; }
    public int HourlyRate { get; set; }
    public float GetSalary()
    {
        var salaryCalculator = new SalaryCalculator();
        return salaryCalculator.CalculateSalary(HoursWorked, HourlyRate);
    }
}u