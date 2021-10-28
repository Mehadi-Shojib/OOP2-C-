using System;
using System.Collections.Generic;
using System.Text;

namespace LabTask4
{
    class Employee:Person
    {
        private Account acc;

        public Employee() 
        {

            Console.WriteLine("Empty Employee called"); 
        }

        public Employee(string name, string dob, Account acc) : base(name, dob)
        {
            this.acc = acc;
        }
        public void setAcc(Account acc)
        {
            this.acc = acc;
        }
        /*public Account getAcc()
      {
          return acc;
      }*/
        public void display()
        {

           Console.WriteLine("Name= " +base.getName());
           Console.WriteLine("DOB= " +base.getDob());
           acc.displayAccDetails();
          

        }
    }
}
