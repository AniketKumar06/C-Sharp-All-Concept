using System;

namespace TypesOfVariables
{
    public class Program
    {
        public static void Main(string[] args)
        {

            //  Local Variable
            name();
            Console.WriteLine("Value of c is " + c);   // Error beacuse c is define as local variable

        }
            
        public static void name(){
            int c = 23;
            Console.WriteLine("Value of c is " + c);
        }
    }

  
}
