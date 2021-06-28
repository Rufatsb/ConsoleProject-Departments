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

        void AddDepartment(string name, int workerlimit, double salarylimit);
        List<Department> GetDepartments();
        void EditDepartaments(string name, string newname);
        void AddEmployee(string name, string surname, string position, double salary, string departmentname);
        void RemoveEmployee(string no, string departmentname);
        void EditEmployee(string no, double salary, string position, string fullname);











    }
}
