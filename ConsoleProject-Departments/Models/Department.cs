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
        public int SalaryLimit { get; set; }
        public List<Employee> Employees { get; set; }

        //Department- classinda her bir departamentin Name-Adi,WorkerLimit-muessedeki iscilerin maximum sayini bildiren limit,
        //SalaryLimitiscilere umumi odenilecek maaslarin ceminim maximumu ve Employees arrayi yaradildi.

         public Department()
        {

        }


        public Department(string name, int workerlimit, int salarylimit) : this()
        {
            Name = name;
            WorkerLimit = workerlimit;
            SalaryLimit = salarylimit;
            Employees = new List<Employee>();
        }
        //Ici bos olmayan Department constructoru yaradildi ve yuxarida qeyd etdiyimiz proportiler(Name, WorkerLimit, SalaryLimit)deyisenlere set olundu.
        ////Employees arrayi initiliase olundu ve baslangic Lengthi 0 verildi.

        public int CalcSalaryAverage()
        {
            int sum = 0;
            int avg;
            foreach (Employee employee in Employees)
            {
                sum += employee.Salary;
            }
            if (Employees.Count!= 0)
            {
                avg = sum / this.Employees.Count;
                return avg;

            }
            else
                return 0;

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
