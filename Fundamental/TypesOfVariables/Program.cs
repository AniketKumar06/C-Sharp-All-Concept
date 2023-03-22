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

            // Instance Variables or Non – Static Variables

            Program marks01 = new Program();
            marks01.EnglishMarks = 56;
            marks01.HindiMarks = 86;
            marks01.MathsMarks = 58;
            Console.WriteLine("Marks obtained by Student  1 is ");
            Console.WriteLine(
                $"English = {marks01.EnglishMarks} \n Hindi = {marks01.HindiMarks} \n Mathematics = {marks01.MathsMarks} "
            );

            Program marks02 = new Program();
             marks02.EnglishMarks = 58;
            marks02.HindiMarks = 76;
            marks02.MathsMarks = 85;
            Console.WriteLine("Marks obtained by Student  2 is ");
            Console.WriteLine(
                $"English = {marks02.EnglishMarks} \n Hindi = {marks02.HindiMarks} \n Mathematics = {marks02.MathsMarks} "
            );


            // Static Variables or Class Variables

            Program.value = 20;
            Console.WriteLine(value);


// All variables types
            Program all = new Program();
            Console.WriteLine(all.age);
            Console.WriteLine(max);
            Console.WriteLine(gh);
       
            Console.WriteLine(all.k);
        }

        public static void name()
        {
            int c = 23;
            Console.WriteLine("Value of c is " + c);
        }

        public void Student()
        {
            int age = 23;
            age = age + 10;
            Console.WriteLine("Your age is " + age);

        }

        // Instance Variables or Non – Static Variables

        int EnglishMarks;
        int HindiMarks;
        int MathsMarks;


        // Static Variables or Class Variables

        static int value;


        // All Types of variable 

        int age = 20;
        static string gh = "Aniket";

        const float max = 25.3f;

        readonly int k=85;
        // Create Constructor to change value of K   
        public Program(){
            this.k = 58;
        }



    }
}
