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
    }
}
