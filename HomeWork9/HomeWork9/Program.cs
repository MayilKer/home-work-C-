using System;

namespace HomeWork9
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Employee mon = new Employee();
            mon.Name = "Mayil";
            mon.Surname = "Kerimov";
            mon.Age = 22;
            mon.Position = "Fehle";
            mon.Salary = 30;//$
            mon.FullName();
            mon.money(mon.Salary);

        }
    }
}