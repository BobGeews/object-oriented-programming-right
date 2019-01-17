using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeOlio
{
    class Employee
    {
        public string name;
        public int id;
        public string position;
        public double salary;

        public Employee(string name, int id, string position, double salary)
        {
            this.name = name;
            this.id = id;
            this.position = position;
            this.salary = salary;

        }
        public string CompareSalary(Employee employee)
        {
            string text = "";
            if (this.salary > employee.salary)
            {
               text = ($"Työntekijä {this.name} palkka ({this.salary}e) on suurempi kuin työntekijä {employee.name} palkka ({employee.salary}e).");
            }
            else
            {
                text = ($"Työntekijä {employee.name} palkka ({employee.salary}e) on suurempi kuin työntekijä {this.name} palkka ({this.salary}e).");
            }
            return text;
        }
        public string PrintEmployeeInfo()
        {
            string info = this.name +" "+ this.id +" "+ this.position +" "+ this.salary;
            return info;
            
        }
        
    }
}
