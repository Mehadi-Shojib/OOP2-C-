using System;

namespace LaTask1b
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("MEHADI HASAN SHOJIB");//printing full name
            Console.WriteLine("20-42713-1");//printing ID

            //Implicit type casting between int and char
            int word = 'S';
            Console.WriteLine(word);
            //Explicit type casting between int and double
            double big =20.008;
            int small = (int)big;//casted by casting operator 
            Console.WriteLine(small);
            Console.ReadKey();
            

        }
    }
}
