using System;

public class Employee
{
    private string name;
    private double salary;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public double Salary
    {
        get { return salary; }
        set { salary = value; }
    }

    public static double operator +(Employee emp, double increase)
    {
        return emp.salary + increase;
    }

    public static double operator -(Employee emp, double decrease)
    {
        return emp.salary - decrease;
    }

    public static bool operator ==(Employee emp1, Employee emp2)
    {
        return emp1.salary == emp2.salary;
    }

    public static bool operator !=(Employee emp1, Employee emp2)
    {
        return emp1.salary != emp2.salary;
    }

    public override bool Equals(object obj)
    {
        if (obj == null || !(obj is Employee))
            return false;

        Employee emp = (Employee)obj;
        return this.salary == emp.salary;
    }
}
