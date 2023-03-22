using System;

namespace Hero
{
    public class Program
    {
        //   var num = 20;   Error : 'var' may only appear within a local variable declaration
        public static void Main(string[] args)
        {
            // Console.WriteLine("the value of num = " + num); //Error : 'var' may only appear within a local variable declaration
            var i = 20;
            Console.WriteLine("The value of i =" + i);
            varType();

        }

        public static void varType(){
            var a = 10;
            var b = 153.21;
            var c = "Aniket";
            var d = true;

            Console.WriteLine($"The value of a is {a} and type is {a.GetType()}");
            Console.WriteLine($"The value of b is {b} and type is {b.GetType()}");
            Console.WriteLine($"The value of d is {c} and type is {c.GetType()}");
            Console.WriteLine($"The value of d is {d} and type is {d.GetType()}");
        }
    }
}
