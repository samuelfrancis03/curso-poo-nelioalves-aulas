using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExercicioLista
{
    internal class Employee
    {

        public int Id { get; private set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public Employee() { }

        public Employee(int id, string name, double salary) : this() 
        {
            Id = id;
            Name = name;
            Salary = salary;
        }


        public void IncraseSalary(double percentage)  
        {
            
            Salary = Salary + (Salary * (percentage/100));

        }

        public override string ToString()
        {
            return Id + ", "
                + Name + ", "
                + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
