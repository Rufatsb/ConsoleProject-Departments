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
        public List<Department> Departments { get; set; }
        public HumanResourceManager()
        {
            Departments = new List<Department>();
        }

        

        public void AddDepartment(string name, int workerylimit, int salarylimit)
        {
           
            
        }
    }
}
