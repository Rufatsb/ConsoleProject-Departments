using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleProject_Departments.Models
{
    class Employee
    {
        public string FullName { get; set; }
        public string Position { get; set; }
        public int Salary { get; set; }
        public string DepartmentName { get; set; }
        public string No { get; set; }
        private static int _Count = 1000;
        //Employee-isci classinda her bir isci ucun, Fullname-Ad Soyad,Vezife,Maas,Departament adi,isciye mexsus olan unique Nomre proportyleri qeyd olundu.

        public Employee(string fullname,string position,int salary,string departmentName)
        {
            _Count++;
            No = departmentName.ToUpper()[0].ToString() + departmentName.ToUpper()[1].ToString() + _Count.ToString();
            FullName = fullname;
            Position = position;
            Salary =   salary;
            DepartmentName = departmentName;
            
        }
        //Ici bos olmayan Employee constructoru yaradildi ve yuxarida qeyd etdiyimiz proportiler(Fullname, Position, Salary, DepartmentName) deyisenlere set olundu.
        //ToUpper,ToString metodlari vasitesi Departamentin ilk iki herfi ve 1000-den baslayan Count ededi birlesdirilerek her bir isci ucun No(unique number) set olundu.

    
        public override string ToString()
        {
            return $"{No} {FullName} {Salary} {DepartmentName} {Position}";
        }
    }
    //ToString metodu override olundu ve {No} {FullName} {Salary} {DepartmentName} {Position} stringe cevrildi.

}
