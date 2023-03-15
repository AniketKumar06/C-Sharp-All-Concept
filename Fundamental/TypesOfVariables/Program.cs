using System;

namespace TypesOfVariables
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*
            
            Types of Variables
                01. Local variables
                02. Instance variables or Non – Static Variables
                03. Static Variables or Class Variables
                04. Constant Variables
                05. Readonly Variables
 
            
             */


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
