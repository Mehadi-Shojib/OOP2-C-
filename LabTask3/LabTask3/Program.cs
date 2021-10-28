using System;

namespace LabTask3
{
    class Program
    {   
       /*ID =20-42713-1
        middle part's last three=713
       last=1
       */
        public static void add(int a)
        {
            a = a + 713;

        }
        public static void mul(ref int a)
        {
            a = a * 713;
        }
        public static void Out(out int three)
        {
            three = 713;
            
            Console.WriteLine("Out = " + (three * 1));
        }
        public static void para(params int[]a)

        {
            foreach(int i in a)
            {
                Console.Write(i+" ");
            }
        }
        public static void Named( string firstName,string lastName)
        {

            Console.WriteLine("Named= "+"First Name= "+firstName + "  Last Name= " + lastName);
        }
        static void Main(string[] args)
        {
            int a = 713;
            Console.WriteLine("Before addition(pass by value)= " + a);
            add(a);
            Console.WriteLine("After addition(pass by value)= " + a);
            Console.WriteLine("Before multification(pass by reffernce)= " + a);
            mul( ref a);
            Console.WriteLine("After multification(pass by reffernce)= " + a);
          
            int three;
            
            Out(out three);
            Console.Write("Params= ");
            para(2, 0, 4, 2, 7, 1, 3, 1);
            Console.WriteLine();
            Named(lastName: "SHOJIB", firstName: "MEHADI");

            char[][] charArr = new char[2][];
            charArr[0] = new char[] { 'A', 'B', 'c' };
            charArr[1] = new char[] { 'D', 'E' };
            charArr[0][2]= 'F';
            charArr[1][1] = 'G';
            Console.WriteLine("Replaced Character in char[0] at charArr[0][2]= " + charArr[0][2]);
            Console.WriteLine("Replaced Character in char[1] at charArr[1][1]= " + charArr[1][1]);
            for (int i = 0; i < charArr.Length; i++)
            
            {
                for (int j = 0; j < charArr[i].Length; j++)
                {
                    Console.WriteLine("arr1[" + i + "] [" + j + "]: " + charArr[i][j]);
                }
            }

            Console.ReadKey();

        }
    }
}
