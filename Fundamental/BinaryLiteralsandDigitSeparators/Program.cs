using System;

namespace BinaryLiteralsandDigitSeparators{
    public class Program{
        public static void Main(string[] args)
        {
            BinaryLiterals();
            Program obj = new Program();
            obj.DigitSeparators();

        }
        public static void BinaryLiterals(){

            var num = 0b1010101;
            var num2 = 0b00101010;
            Console.WriteLine($"the value of num is {num}");
            Console.WriteLine($"the value of num2 is {num2}");
        }
        public void DigitSeparators(){
            
        // Without Using digit separators
        long x = 100000022200000202;
        long z = 10000000020;
  
        Console.WriteLine("X: {0}", x);
        Console.WriteLine("Z: {0}", z);
  
        // Using digit separators
        long num1 = 1_00_10_00_00_00;
        var num2 = 0b_010_000_000_000_000_000_000_000_000;
        long num3 = 1_00_00_00_00_00_00;
        var num4 = 0b_1_1000_0000_1000_0000_0011_0000_0000_1000_0001;
  
        Console.WriteLine("Num1: {0}", num1);
        Console.WriteLine("Num2: {0}", num2);
        Console.WriteLine("Num3: {0}", num3);
        Console.WriteLine("Num4: {0}", num4);
        }
    }
}