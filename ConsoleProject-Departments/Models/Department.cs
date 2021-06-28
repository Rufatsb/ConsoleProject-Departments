using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject_Departments.Models
{
    class Department
    {
        public string Name { get; set; }
        public int WorkerLimit { get; set; }
        public double SalaryLimit { get; set; }
        public List<Employee> Employees { get; set; }

        //Department- classinda her bir departamentin Name-Adi,WorkerLimit-muessedeki iscilerin maximum sayini bildiren limit,
        //SalaryLimitiscilere umumi odenilecek maaslarin ceminim maximumu ve Employees arrayi yaradildi.

        public Department(string name, int workerlimit, double salarylimit)
        {
            Name = name;
            WorkerLimit = workerlimit;
            SalaryLimit = salarylimit;
            Employees = new List<Employee>();
        }
        //Ici bos olmayan Department constructoru yaradildi ve yuxarida qeyd etdiyimiz proportiler(Name, WorkerLimit, SalaryLimit)deyisenlere set olundu.
        ////Employees arrayi initiliase olundu ve baslangic Lengthi 0 verildi.

        public double CalcSalaryAvr()
        {
            double sum = 0;
            foreach (Employee employee in Employees)
            {
                sum += employee.Salary;
            }

            return sum / Employees.Count;
        }
        // Departamentdeki iscilerin maas ortalamasini qaytaran method CalcSalaryAverage yaradildi.Metod Employees arrayindaki Employee tipinden olan her bir iscinin
        // maasini cemleyir ve arrayin uzunluguna bolunmekle ortalama maas tapilir.
        public override string ToString()
        {
            return $"{Name} {WorkerLimit} {SalaryLimit}";
        }
        //ToString metodu override olundu ve {Name} {WorkerLimit} {SalaryLimit} stringe cevrildi.


    }
}
