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

        // Properties and Employees List
        public string Name { get; set; } 
        public int WorkerLimit { get; set; } 
        public double SalaryLimit { get; set; }
        public List<Employee> Employees { get; set; } 

        #endregion


        #region constructor
        //Employees List intialize in Department constructor.
        public Department(string name, int workerlimit, double salarylimit) //Department's Constructor 
        {
            Name = name;
            WorkerLimit = workerlimit;
            SalaryLimit = salarylimit;
            Employees = new List<Employee>();
        }
        
        #endregion

        #region method CalcSalaryAvr
        //This method calculate average of employees' salary.
        public double CalcSalaryAvr()
        {
            double sum = 0;
            foreach (Employee employee in Employees)
            {
                sum += employee.Salary;
            }

            return sum / Employees.Count;
        }


        #endregion
        #region tostring
        //With help ToString method's  {Name} ,{WorkerLimit} and {SalaryLimit} converted to string.
        public override string ToString()
        {
            return $"{Name} {WorkerLimit} {SalaryLimit}";
        }
       
        #endregion

    }
}
