using ConsoleProject_Departments.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleProject_Departments.Services
{
    interface IHumanResourceManager
    {
        List<Department> Departments { get; set; }

        void AddDepartment(string name, int workerlimit, int salarylimit);

       List <Department > GetDepartments();

        void EditDepartments(string name, string newname);
        void AddEmployee(string fullname, string position, int salary, string departmentName,string no, List<Employee> Employees);
        void RemoveEmployee(string no, string departmentname, Employee employee, List<Employee> Employees);
        void EditEmployee(string no, string fullname, string position);











    }
}
