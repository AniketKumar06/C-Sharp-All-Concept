using System;

namespace Variables
{
    public class Program
    {
        int c;
        public static void Main(string[] args)
        {
            
            /*
            Two Ways for Initialization:
            
            01. Compile time initialization
            02. Run time initialization
            
            */

            // compile time initialization

            int d = 12;
            int e;
            Program p = new Program();
            Console.WriteLine($"The Value of d is {d} ");
            Console.WriteLine($"The value of c is {p.c}");
            // Console.WriteLine($"The value of e is {e}");    Error
        }
    }
}
