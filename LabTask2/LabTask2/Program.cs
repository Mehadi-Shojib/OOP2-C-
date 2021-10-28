using System;

namespace LabTask2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("///////////// Object 1////////////");
            Mehadi taib = new Mehadi();//created one object by calling default and static constructor
           //setting value to all attributes
            taib.setName("TANZIR TAIB");
            taib.setId("20-42713-1");
            taib.setCgpa(3.07F);
            taib.setSemester(5);
            taib.setProgram("CSE");
            taib.setUniversity("AIUB");
           //printing all the attributes by getter method
            Console.WriteLine("Name = " + taib.getName());
            Console.WriteLine("ID = " + taib.getId());
            Console.WriteLine("cgpa = " + taib.getCgpa());
            Console.WriteLine("Semester = " + taib.getSemester());
            Console.WriteLine("Program = " + taib.getProgram());
            Console.WriteLine("University = " + taib.getUniversity());

            Console.WriteLine("///////////// Object 2////////////");
            //creating one object by parameterized constructor
            Mehadi shojib = new Mehadi("MEHADI HASAN SHOJIB","20-42713-1", 3.76F, 6, "CSE", "AIUB");
            shojib.show();//calling show methods
            Console.WriteLine("///////////// Object 3////////////");
            Mehadi fahim = new Mehadi(taib);//created one object and copying
            fahim.show();//show methods
            Console.ReadKey();
        }
    }
}
