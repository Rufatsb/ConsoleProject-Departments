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

        void AddDepartment(string name,int workerylimit,int salarylimit);
      

 






    }
}
