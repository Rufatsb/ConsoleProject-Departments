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
        #region Interface
        //This interface:IHumanResourceManager locate in Services folder.In this interface have one list(Departments) and 6 method 5 methods'
        //return type are  void and one's is List .Method's body has been wrote in HumanResourceManager class.

        List<Department> Departments { get; set; }

        void AddDepartment(string name, int workerlimit, double salarylimit);
        List<Department> GetDepartments();
        void EditDepartments(string name, string newname);
        void AddEmployee(string name, string surname, string position, double salary, string departmentname);
        void RemoveEmployee(string no, string departmentname);
        void EditEmployee(string no, double salary, string position, string fullname);

        
        #endregion











    }
}
