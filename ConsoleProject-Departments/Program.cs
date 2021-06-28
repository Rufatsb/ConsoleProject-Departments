using ConsoleProject_Departments.Models;
using ConsoleProject_Departments.Services;
using System;

namespace ConsoleProject_Departments
{
    class Program
    {
        static void Main(string[] args)
        {

            HumanResourceManager hrm = new HumanResourceManager();


            string answer;

            do
            {
                Console.WriteLine("\n-------------------------------------------\n");


                Console.WriteLine("1.1 - Departamentlerin siyahisini gostermek");
                Console.WriteLine("1.2 - Yeni Department yaratmaq");
                Console.WriteLine("1.3 - Departament uzerinde deyisiklik etmek");
                Console.WriteLine("2.1 - Isci elave etmek ");
                Console.WriteLine("2.2 - Departamentdeki iscilerin siyahisini gostermek");
                Console.WriteLine("2.3 - Butun iscilerin siyahisini gostermek");
                Console.WriteLine("2.4 - Isci uzerinde deyisiklik etmek");
                Console.WriteLine("2.5 - Departamentden isci silinmesi");
                Console.WriteLine("3 - Cixis");

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
                        ShowDepartment(hrm);
                        break;
                    case "2.4":
                        ShowDepartment(hrm);
                        break;
                    case "2.5":
                        ShowDepartment(hrm);
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
            hrm.EditDepartaments(name, newname);



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

        static void RemoveEmployee(HumanResourceManager hrm)
        {
            Console.WriteLine("Silmek istediyiniz iscinin Nomresini daxil edin.");
            string no = Console.ReadLine();
            Console.WriteLine("Silmek istediyiniz iscinin departmentname-ni daxil edin.");
            string departmentname = Console.ReadLine();
            hrm.RemoveEmployee(no, departmentname);
        }

    }
}



        
    


        




