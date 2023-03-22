using System;

namespace TypesOfVariables
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //  Local Variable
            name();
            //  Console.WriteLine("Value of c is " + c);   // Error beacuse c is define as local variable
            // Student();   // Provide error because it not call from static class 
            Program s = new Program();
            s.Student();


        }

        public static void name(){
            int c = 23;
            Console.WriteLine("Value of c is " + c);
        }
        public void Student(){
        int age = 23;
        age = age + 10;
        Console.WriteLine("Your age is " + age);
    }
  

    }



  
}
