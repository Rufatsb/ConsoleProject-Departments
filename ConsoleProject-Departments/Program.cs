using ConsoleProject_Departments.Models;
using ConsoleProject_Departments.Services;
using System;

namespace ConsoleProject_Departments
{
    class Program
    {
        static void Main(string[] args)
        {

            HumanResourceManager h1 = new HumanResourceManager();

            do
            {
                Console.WriteLine("Etmek Isdediyniz Emelliyyati Secin");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("1.1 Department Elave Et");
                Console.WriteLine("1.2 Departmentlerin Siyahisini goster.");
                Console.WriteLine("1.3 Departamentde deyisiklik etmek");
                Console.WriteLine("2.1 Iscilerin siyahisini gostermek");
                Console.WriteLine("2.2 Departamentdeki iscilerin siyahisini gostermek");
                Console.WriteLine("2.3 Isci elave etmek");
                Console.WriteLine("2.4 Isci uzerinde deyisiklik etmek");
                Console.WriteLine("2.5 Departamentden isci silinmesi ");
                string answer = Console.ReadLine();

                switch (answer)
                {
                    case "1.1":
                        AddDepartmentu(h1);
                        break;
                    case "1.2":
                        ShowListu(h1);
                        break;
                    //case "1.3":
                    //    EditDepartmentu(h1);
                    //    break;
                    //case "2.1":
                    //    ShowEmployeeListu(h1);

                    //case "2.2":
                    //    CountDepartmentu(h1);
                    //case "2.3":
                    //    AddEmployeeu(h1);

                    //case "2.4":
                    //    EditEmployeeu(h1);
                    default:
                        break;
                }

            } while (true);
        }
            static void AddDepartmentu(HumanResourceManager humanresourcemanager)
            {

                bool nameloop = true;
                bool workerlimitloop = true;
                bool salarylimitloop = true;
                string departmentname = "";
                int departmentworkerlimit = 0;
                int departmentsalarylimit = 0;
                Console.WriteLine("Department adini daxil edin");
                while (nameloop)
                {
                    try
                    {
                        departmentname = Console.ReadLine();
                        if (departmentname.Length >= 2)
                        {
                            nameloop = false;
                        }

                      
                    }
                    catch
                    {
                        Console.WriteLine("Duzgun ad daxil edin.");
                    }
                    while (salarylimitloop)
                        try
                        {
                            departmentsalarylimit = int.Parse(Console.ReadLine());
                            if (departmentsalarylimit >= 250)
                            {
                                salarylimitloop = false;
                            }

                            
                        }
                        catch
                        {
                            Console.WriteLine("Duzgun salarylimit daxil edin.");
                        }
                    while (workerlimitloop)
                        try
                        {
                            departmentworkerlimit = int.Parse(Console.ReadLine());
                            if (departmentworkerlimit >= 1)
                            {
                                workerlimitloop = false;
                            }

                           
                        }
                        catch
                        {
                            Console.WriteLine("Duzgun workerlimit daxil edin.");
                        }


                    Department department = new Department(departmentname, departmentworkerlimit, departmentsalarylimit);
                    humanresourcemanager.AddDepartment(departmentname, departmentworkerlimit, departmentsalarylimit);

                }





            }

            static void ShowListu(HumanResourceManager humanresourcemanager)
            {

            if (humanresourcemanager.Departments.Count>0)
            {
                foreach (Department item in humanresourcemanager.Departments)
                {
                    Console.WriteLine($"Name:{item.Name}-Worklimit:{item.WorkerLimit}-SalaryAverage:{item.CalcSalaryAverage()}");
                }
            }
            else
            {
                Console.WriteLine("Sistemde hec bir department yoxdur");
            }
        }


    }
        }
    


        




