using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork9
{
    class Employee
    {
        public string Name;
        public string Surname;
        public int Age;
        public string Position;
        public int Salary;
        public void money(int salary)
        {
            int res = 0;
            
            for (int i = 0; i < 31; i++)
            {
                res = res + salary;
            }
           
            Console.WriteLine(res);
           
        }
        public void FullName()
        {
            Console.WriteLine($"{Name} {Surname} {Age} {Position}");
        }
    }
}
