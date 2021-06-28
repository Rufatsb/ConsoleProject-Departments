using ConsoleProject_Departments.Models;
using ConsoleProject_Departments.Services;
using System;
using System.Collections.Generic;

namespace ConsoleProject_Departments
{
    class Program
    {
        static void Main(string[] args)
        {

            #region process 
            // We created hrm object from HumanResourceManager because most of the process goes in HumanResourceManager class ,especially 
            //most methods locate in there and we use that methods.
            HumanResourceManager hrm = new HumanResourceManager();


            string answer;

            do
            {
                Console.WriteLine("\n-------------------------------------------\n");


                Console.WriteLine("1.1 - Departamentlerin siyahisini gostermek");
                Console.WriteLine("1.2 - Yeni Department yaratmaq");
                Console.WriteLine("1.3 - Departament uzerinde deyisiklik etmek");
                Console.WriteLine("2.1 - Iscinin sisteme elave olunmasi. ");
                Console.WriteLine("2.2 - Iscinin sistemden silinmesi.");
                Console.WriteLine("2.3 - Isci uzerinde deyisiklik etmek.");
                Console.WriteLine("2.4 - Butun iscilerin siyahisini gostermek.");
                Console.WriteLine("2.5 - Departamentdeki iscilerin siyahisini gostermek.");
                Console.WriteLine("3   - Cixis");

                Console.WriteLine("\nIcra etmek istediyiniz emeliyyati secin:");
                answer = Console.ReadLine();


                Console.WriteLine("\n-------------------------------------------\n");


                switch (answer)
                {
                    case "1.1":
                        ShowDepartment(hrm);
                        break;
                    case "1.2":
                        AddDepartment(hrm);
                        break;
                    case "1.3":
                        EditDepartment(hrm);
                        break;
                    case "2.1":
                        AddEmployee(hrm);
                        break;
                    case "2.2":
                        RemoveEmployee(hrm);
                        break;
                    case "2.3":
                        EditEmployee(hrm);
                        break;
                    case "2.4":
                        ShowEmployees(hrm);
                        break;
                    case "2.5":
                        ShowDepartmentEmployees(hrm);
                        break;
                    default:
                        if (answer != "3")
                        {
                            Console.WriteLine("Zehmet olmasa duzgun deyer daxil edin");
                        }
                        break;

                }

            } while (answer != "3");
        }

        //With do while loop we start process and wait answer from user ,user only can apply aprropiate values (Which we show to them )

        #endregion
        #region Program cs Methods
        static void ShowDepartment(HumanResourceManager hrm)
        {
            if (hrm.Departments.Count > 0)
            {
                foreach (Department department in hrm.Departments)
                {
                    Console.WriteLine($"Name:{department.Name}-Worklimit:{department.WorkerLimit}-SalaryAverage:{department.CalcSalaryAvr()}");
                }
            }
            else
            {
                Console.WriteLine("Sistemde hec bir departament yoxdur.");
            }

        }

        static void AddDepartment(HumanResourceManager hrm)
        {
            Console.WriteLine("Department adi daxil edin.");
            string name = Console.ReadLine();
            Console.WriteLine("Workerlimiti  daxil edin.");
            int workerlimit = int.Parse(Console.ReadLine());
            Console.WriteLine("Salarylimiti daxil edin.");
            double salarylimit = double.Parse(Console.ReadLine());
            if (name.Length >= 2 && workerlimit >= 1 && salarylimit >= 250)
            {
                hrm.AddDepartment(name, workerlimit, salarylimit);
            }



        }

        static void EditDepartment(HumanResourceManager hrm)
        {

            Console.WriteLine("Deyisiklik etmek istediyiniz departamentin adini daxil edin.");
            string name = Console.ReadLine();
            Console.WriteLine("Departamentin yeni adini daxil edin.");
            string newname = Console.ReadLine();
            hrm.EditDepartments(name, newname);



        }

        static void AddEmployee(HumanResourceManager hrm)
        {
            Console.WriteLine("Sisteme daxil etmek istediyiniz iscinin adini qeyd edin.");
            string name = Console.ReadLine();
            Console.WriteLine("Sisteme daxil etmek istediyiniz iscinin soyadini qeyd edin.");
            string surname = Console.ReadLine();
            Console.WriteLine("Sisteme daxil etmek istediyiniz iscinin vezifesini qeyd edin.");
            string position = Console.ReadLine();
            Console.WriteLine("Sisteme daxil etmek istediyiniz iscinin maasini qeyd edin.");
            double salary = double.Parse(Console.ReadLine());
            Console.WriteLine("Sisteme daxil etmek istediyiniz isciye uygun departament adini  qeyd edin.");
            string departmentname = Console.ReadLine();
            hrm.AddEmployee(name, surname, position, salary, departmentname);
        }

        static void EditEmployee(HumanResourceManager hrm)
        {

            foreach (Department department in hrm.Departments)

                foreach (Employee employee in department.Employees)
                {
                    Console.WriteLine("Deyisiklik etmek istediyiniz iscinin No-sunu qeyd edin.");
                    string no = Console.ReadLine();
                    if (employee.No == no)
                    {
                        Console.WriteLine($"Iscinin maasi:{employee.Salary},Iscinin vezifesi:{employee.Position},Iscinin ad ve soyadi:{employee.Name}  {employee.SurName}");

                        Console.WriteLine("Isci ucun yeni maas teyin edin. ");
                        double newsalary = employee.Salary;
                        newsalary = double.Parse(Console.ReadLine());
                        Console.WriteLine("Isci ucun yeni vezife teyin edin. ");
                        string newposition = employee.Position;
                        newposition = Console.ReadLine();

                        Console.WriteLine($"Yeni maas:{newsalary},yeni vezife:{newposition}");



                    }

                    else
                    {
                        Console.WriteLine("Sistemde bu Nomrede isci tapilmadi.");

                    }
                }
        }
            static void RemoveEmployee(HumanResourceManager hrm)
            {

                foreach (Department department in hrm.Departments)

                    foreach (Employee employee in department.Employees)
                    {
                        Console.WriteLine("Silmek  istediyiniz iscinin No-sunu qeyd edin.");
                        string no = Console.ReadLine();
                        Console.WriteLine("Deyisiklik etmek istediyiniz iscinin departmentname-ni qeyd edin.");
                        string departmentname = Console.ReadLine();
                        hrm.RemoveEmployee(no, departmentname);
                    }
            }

        static List<Employee> GetEmployees(HumanResourceManager hrm)
        {
            List<Employee> employees = new List<Employee>();
            foreach (Department department in hrm.Departments)
            {
                foreach (Employee employee in department.Employees)
                {
                    employees.Add(employee);
                }
            }
            return employees;

        }
        static void ShowEmployees(HumanResourceManager hrm)
        {
            List<Employee> employees = GetEmployees(hrm);

            if (employees.Count > 0)
            {
                Console.WriteLine("--------------------------------------");
                Console.WriteLine(" Isciler:");
                foreach (var employee in employees)
                {
                    Console.WriteLine($"Isci nomresi:{employee.No} Isci adi: {employee.Name} Isci soyadi:{employee.SurName} Iscinin aid oldugu departmentadi:  {employee.DepartmentName}  Iscinin maasi: {employee.Salary}");
                }
            }
            else
            {
                Console.WriteLine("Sistemde hec bir isci yoxdur.");
            }

            GetEmployees(hrm);
        }

        static void ShowDepartmentEmployees(HumanResourceManager hrm)
        {
            bool checkdepartment= true;
            string departmentname;

            
            do
            {
                if (checkdepartment)
                {
                    Console.WriteLine("Departament adini daxil edin.");
                }
                else
                {
                    Console.WriteLine("Daxil etdiyiniz department movcud deyil,yeniden daxil edin:");
                }
                departmentname = Console.ReadLine();
                checkdepartment = false;

            } while (hrm.FindDepartment(departmentname) == null);


            if (hrm.FindDepartment(departmentname).Employees.Count > 0)
            {

                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine($"{departmentname} Departmentdeki Isciler:");
                foreach (Employee employee in hrm.FindDepartment(departmentname).Employees)
                {
                    Console.WriteLine($"Isci nomresi:{employee.No} Isci adi: {employee.Name} Isci soyadi:{employee.SurName} Iscinin vezifesi:  {employee.Position}  Iscinin maasi: {employee.Salary}");
                }
            }
            else
            {
                Console.WriteLine("Secdiyiniz departmentde hec bir isci tapilmadi!!!");
            }

        }
        #endregion

    }
}




        
    


        




