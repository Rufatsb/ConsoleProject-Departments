using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject_Departments.Models
{
    class Department
    {
        #region props
        public string Name { get; set; } //Property
        public int WorkerLimit { get; set; } //Property
        public double SalaryLimit { get; set; }//Property
        public List<Employee> Employees { get; set; } // List//

        #endregion


        #region constructor
        public Department(string name, int workerlimit, double salarylimit) //Department's Constructor 
        {
            Name = name;
            WorkerLimit = workerlimit;
            SalaryLimit = salarylimit;
            Employees = new List<Employee>();
        }
        //Employees List intialize in Department constructor.
        #endregion

        #region method CalcSalaryAvr
        public double CalcSalaryAvr()
        {
            double sum = 0;
            foreach (Employee employee in Employees)
            {
                sum += employee.Salary;
            }

            return sum / Employees.Count;
        }
        //This method calculate average of employees' salary.

        #endregion
        #region tostring
        public override string ToString()
        {
            return $"{Name} {WorkerLimit} {SalaryLimit}";
        }
        //With help ToString method's  {Name} ,{WorkerLimit} and {SalaryLimit} converted to string.
        #endregion

    }
}
