using System;

namespace DynamicType
{
    public class Program{
        dynamic value = 20;
        public static void Main(string[] args)
        {
            Program obj = new Program();
            Console.WriteLine("The value is " + obj.value);

            dynamic a = 123;
            dynamic b = 123.56;
            dynamic c = "Aniket";
            dynamic d = true;
            Console.WriteLine($"the value of a is {a} and there type is {a.GetType().ToString()}");
            Console.WriteLine($"the value of b is {b} and there type is {b.GetType().ToString()}");
            Console.WriteLine($"the value of c is {c} and there type is {c.GetType().ToString()}");

            Console.WriteLine($"the value of d is {d} and there type is {d.GetType().ToString()}");



        }
    }
}