using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleProject_Departments.Models;

namespace ConsoleProject_Departments.Services
{
  class HumanResourceManager:IHumanResourceManager
    {
        private Department department { get; set; }

        public List<Department> Departments { get; set; }

       


        public void AddDepartment(string name, int workerlimit, int salarylimit)
        {
           
            
            if (Departments.Any(n => n.Name == name && n.WorkerLimit == workerlimit && n.SalaryLimit == salarylimit))
            {
                Departments.Add(department);
            }
            

            
            
        }

        public List<Department> GetDepartments()
        {
            return Departments;
        }

        public void EditDepartments(string name, string newname)
        {

            if (Departments.Any(n => n.Name != newname))
            {
                department.Name = newname;
            }
            else
            {
                department.Name = name;
            }

        }
        public void AddEmployee(string fullname, string position, int salary, string departmentName, string no, List<Employee> Employees)
        {
           

            if (Employees.Any(n => n.FullName == fullname && n.Position == position && n.DepartmentName == departmentName && n.No == no))
            {
                Employee employee = new Employee();

                Employees.Add(employee);
            }
        }

        public void RemoveEmployee(string no, string departmentname, Employee employee, List<Employee> Employees)
        {
            if (employee.No == no && employee.DepartmentName == departmentname)
            {
                Employees.Remove(employee);
            }
            

        }
       public  void EditEmployee(string no, string fullname, string position, List<Employee> Employees)
        {
            foreach (Employee employee in Employees)
            {
                if (employee.No != null && employee.FullName != null && employee.Position != null )
                {
                    employee.No = no;
                    employee.FullName = fullname;
                    employee.Position = position;

                }

                
            }
        }

    }

}
