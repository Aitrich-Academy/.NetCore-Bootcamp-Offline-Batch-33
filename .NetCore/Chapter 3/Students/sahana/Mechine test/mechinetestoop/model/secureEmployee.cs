using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mechinetestoop.model
{
    public class Employee
    {
        private string _name;
        private string _position;
        private decimal _salary;

        public string Name
        {
            get { return _name; }
        }
        public string Position
        {
            get { return _position; }
        }
        public decimal Salary
        {
            get { return _salary; }
        }

        public  Employee(string name,string position,decimal salary)
        {
            this._name = name;
            this._position = position;
            this._salary = salary;
        }
        public void Incresesalary(decimal percentage)
        {
            if (percentage > 0 && percentage <= 20)
            {
                _salary += _salary * (percentage / 100);
                Console.WriteLine($"salary incresed {percentage}%.new salary:{_salary:15}");
            }
            else
            {
                Console.WriteLine("invalid increse percentage between 0% and 20%");
            }
        }

    }
    }
