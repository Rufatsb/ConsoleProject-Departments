using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleProject_Departments.Models
{
    class Employee
    {
       
        public string Fullname;
        public string Position { get; set; }
        public double Salary { get; set; }
        public string DepartmentName { get; set; }
        private static readonly int _count = 1000;
        public string No { get; set; }
        //Employee-isci classinda her bir isci ucun, Fullname-Ad Soyad,Vezife,Maas,Departament adi,isciye mexsus olan unique Nomre proportyleri qeyd olundu.

        public Employee(string name, string surname, string position, double salary, string departmentname)
        {
            Fullname = name + surname;
            Position = position;
            Salary = salary;
            DepartmentName = departmentname;
            No = departmentname.Substring(0, 2).ToUpper() + _count.ToString();

        }
        //Ici bos olmayan Employee constructoru yaradildi ve yuxarida qeyd etdiyimiz proportiler(Fullname, Position, Salary, DepartmentName) deyisenlere set olundu.
        //ToUpper,ToString metodlari vasitesi Departamentin ilk iki herfi ve 1000-den baslayan Count ededi birlesdirilerek her bir isci ucun No(unique number) set olundu.




        public override string ToString()
        {
            return $"{Fullname} {Salary} {DepartmentName} {Position} {No}";
        }
    }
    //ToString metodu override olundu ve {No} {FullName} {Salary} {DepartmentName} {Position} stringe cevrildi.

}
