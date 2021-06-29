using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleProject_Departments.Models
{
    class Employee
    {
        #region properties
        //Properties created.
        public string Fullname;
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Position { get; set; }
        public double Salary { get; set; }
        public string DepartmentName { get; set; }
        private static  int _count = 1000;
        public string No { get; set; }
       
        #endregion
        #region constructor
        //Employee constructor and method for No proporty.
        public Employee(string name, string surname, string position, double salary, string departmentname)
        {
            _count++;
            Name = name;
            SurName = surname;
            Fullname = name + surname;
            Position = position;
            Salary = salary;
            DepartmentName = departmentname;
            No = departmentname.Substring(0, 2).ToUpper() + _count.ToString();

        }
       
        //Employee constructor with departmetname and no.
        public Employee(string departmentname,string no)
        {
            DepartmentName = departmentname;
            No = no;
        }
        #endregion

        #region tostring
        //ToString method has been override and   {No} {FullName} {Salary} {DepartmentName} {Position} converted to string .
        public override string ToString()
        {
            return $"{Fullname} {Salary} {DepartmentName} {Position} {No}";
        }
    }
  
    #endregion

}
