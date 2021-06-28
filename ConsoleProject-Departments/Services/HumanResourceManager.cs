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
        public void AddDepartment(string name, int workerlimit, double salarylimit)
        {
            if (name.Length >= 2 && workerlimit >= 1 && salarylimit >= 250)
            {
                Department department = new Department(name, workerlimit, salarylimit);
                Departments.Add(department);
            }
            else
            {

                Console.WriteLine($"Department adi 2-den kicik ola bilmez,workerlimit 1-den kicik ola bilmez,salarylimit 250-den kicik ola bilmez.");
            }


        }

        public List<Department> GetDepartments()
        {
            return Departments;
        }
        public void EditDepartaments(string name, string newname)
        {
            if (FindDepartment(newname) != null && name.Length >= 2) return;

            Department exitDepartment = FindDepartment(name);

            if (exitDepartment != null && newname.Length >= 2)
            {
                exitDepartment.Name = newname;
            }

            else
            {
                Console.WriteLine("Departament adini sehv daxil etdiniz ve ya daxil etdiyiniz yeni adin uzunlugu 2-den azdir.");


            }
        }


        public void AddEmployee(string name, string surname, string position, double salary, string departmentname)
        {

            Department department = FindDepartment(departmentname);

            if (position.Length >= 2 && salary >= 250)

            {
                Employee employee = new Employee(name, surname, position, salary, departmentname) { };
                department.Employees.Add(employee);

            }
            else
            {
                throw new ArgumentOutOfRangeException(position.Length.ToString(), salary.ToString());
                throw new ArgumentNullException(department.ToString());
            }

        }

        public void RemoveEmployee(string no, string departmentname)
        {
            foreach (Department department in Departments)
            {
                foreach (Employee employee in department.Employees)
                {
                    if (employee.No == no && employee.DepartmentName == departmentname)
                    {
                        department.Employees.Remove(employee);
                    }

                    else
                    {
                        throw new ArgumentNullException(no, departmentname);
                    }
                }
            }
        }






        public void EditEmployee(string no, double salary, string position, string fullname)
        {

            foreach (Department department in Departments)

                foreach (Employee employee in department.Employees)
                {
                    if (employee.No == no)
                    {
                        employee.Salary = salary;
                        employee.Position = position;
                        employee.Fullname = fullname;


                    }

                    else
                    {
                        throw new IndexOutOfRangeException(employee.ToString());
                    }
                }
        }
        // Additional methods 

        public Department FindDepartment(string name)
        {
            foreach (Department item in Departments)
            {
                if (item.Name == name)
                {
                    return item;
                }
            }
            return null;
        }


    }

}
