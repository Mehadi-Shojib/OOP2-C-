using System;

namespace LabTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account(10001, 60000.00, "Emp");
            Account a2 = new Account(10002, 50000.00, "Cus");
            Console.WriteLine("-----------Employee Details------------");
            Employee e1 = new Employee();
            e1.setName("Yami Sukihero");
            e1.setDob("17-Sept-1982");
            e1.setAcc(a1);
            Console.WriteLine("Name= " + e1.getName());
            Console.WriteLine("Dob= " + e1.getDob());
            a1.displayAccDetails();

            Console.WriteLine();
            Console.WriteLine();
            Employee e2 = new Employee("Uchiha Itachi", "15-sept-1900", a1);
            e2.display();
            Console.WriteLine("-----------Customer Details------------");
            Customer c1 = new Customer();
            c1.setName("Kaneki Ken");
            c1.setDob("11-Jan-2000");
            c1.setAcc(a1);
            Console.WriteLine("Name= " + c1.getName());
            Console.WriteLine("Dob= " + c1.getDob());
            a2.displayAccDetails();
            Console.WriteLine();
            Console.WriteLine();
            Customer c2 = new Customer("Sasuke Uchiha", "20-May-2001", a2);
            c2.display();
            Console.ReadKey();
        }
    }
}
