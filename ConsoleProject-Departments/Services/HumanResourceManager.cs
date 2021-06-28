using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleProject_Departments.Models;

namespace ConsoleProject_Departments.Services
{
  class HumanResourceManager:IHumanResourceManager

    #region List and constructor
    // //This class:HumanResourceManager locate in Services folder.In this class have one list(Departments),one constructor  and 7 method all methods'
    //return type is void.FindDepartment method except all other method inherited from IHumanResourceManager interface.
    {
        public List<Department> Departments { get; set; } //Public List property //

        public HumanResourceManager() 
        {
            Departments = new List<Department>();
        }
        //I used HumanResourceManager's empty  constructor for initialize Departments List.

        #endregion

        #region Main Methods
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
        // This method add department to Departments.
        public List<Department> GetDepartments()
        {
            return Departments;
        }
        // This method show Departments(List).
        public void EditDepartments(string name, string newname)
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

        //With EditDepartments method department's name changes.




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
                Console.WriteLine("1.2-ye qayidib department yaradin.");
                throw new ArgumentOutOfRangeException(position.Length.ToString(), salary.ToString());
                throw new ArgumentNullException(department.ToString());
            }

        }

        //This method add employee to Employees List.

        public void RemoveEmployee(string no, string departmentname)
        {
            Employee employee = new Employee(no, departmentname);
            foreach (Department department in Departments)
            {
                bool Check = department.Employees.Any(n => n.DepartmentName == departmentname && n.No == no);

                if (Check == true)
                {
                    department.Employees.Remove(employee);
                }
               
                
                    else
                    {
                        Console.WriteLine("Sistemde bu nomrede ve adda isci tapilmadi.");
                    }
                
            }


         
        }

        //This method remove employee from Employees List.



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
                        Console.WriteLine("Sistemde bu adda isci tapilmadi.");
                        throw new IndexOutOfRangeException(employee.ToString());
                    }
                }
        }


        //With EditEmployee method employee's Fullname,Salary and Position changes. 

        #endregion


        #region Additional method

        public Department FindDepartment(string name)
        {
            foreach (Department department in Departments)
            {
                if (department.Name == name)
                {
                    return department;
                }
            }
            return null;
        }
        // FindDepartment check name and find department in Departments List.

        #endregion

    }

}
