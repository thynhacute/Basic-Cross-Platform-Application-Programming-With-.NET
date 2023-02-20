using System.Transactions;

namespace ModelEntity.Entities;
public class Employee:Person
{
    public int WorkingDay { get; set; } 
    public double SalaryRate { get; set; }

    public Employee()
    {
    }

    public Employee(int workingDay, double salaryRate)
    {
        WorkingDay = workingDay;
        SalaryRate = salaryRate;
    }
    public Employee(int workingDay, double salaryRate,
        int id, string name, string address, short dob)
        :base(id,name, address, dob)
    {
        
        WorkingDay = workingDay;
        SalaryRate = salaryRate;
    }

    public override string? ToString()
        => $"{base.ToString()}, Salary is: {GetSalary()}";
    
    //manual methods
    private double _getSalary()
        => SalaryRate * WorkingDay;

    public double GetSalary()
        => _getSalary();
}
