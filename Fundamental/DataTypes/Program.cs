using System;

namespace DataTypes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*
                    Data Types in C# is mainly divided in three categories
                
                    1. Value Data Types
                    2. Reference Data Types
                    3. Pointer Data Types

             */

            // Value Data Types
            Console.WriteLine("*****************************************************************");
            Console.WriteLine(
                "sbyte DataType having size is {0} , Minvalue is {1} and Maxvalue is  {2}",
                sizeof(sbyte),
                sbyte.MinValue,
                sbyte.MaxValue
            );
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine(
                "short DataType having size is {0} , Minvalue is {1} and Maxvalue is  {2}",
                sizeof(short),
                short.MinValue,
                short.MaxValue
            );
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine(
                "int DataType having size is {0} , Minvalue is {1} and Maxvalue is  {2}",
                sizeof(int),
                int.MinValue,
                int.MaxValue
            );
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine(
                "long DataType having size is {0} , Minvalue is {1} and Maxvalue is  {2}",
                sizeof(long),
                long.MinValue,
                long.MaxValue
            );
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine(
                "byte DataType having size is {0} , Minvalue is {1} and Maxvalue is  {2}",
                sizeof(byte),
                byte.MinValue,
                byte.MaxValue
            );
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine(
                "ushort DataType having size is {0} , Minvalue is {1} and Maxvalue is  {2}",
                sizeof(ushort),
                ushort.MinValue,
                ushort.MaxValue
            );
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine(
                "uint DataType having size is {0} , Minvalue is {1} and Maxvalue is  {2}",
                sizeof(uint),
                uint.MinValue,
                uint.MaxValue
            );
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine(
                "ulong DataType having size is {0} , Minvalue is {1} and Maxvalue is  {2}",
                sizeof(ulong),
                ulong.MinValue,
                ulong.MaxValue
            );
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine(
                "float DataType having size is {0} , Minvalue is {1} and Maxvalue is  {2}",
                sizeof(float),
                float.MinValue,
                float.MaxValue
            );
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine(
                "double DataType having size is {0} , Minvalue is {1} and Maxvalue is  {2}",
                sizeof(double),
                double.MinValue,
                double.MaxValue
            );
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine(
                "decimal DataType having size is {0} , Minvalue is {1} and Maxvalue is  {2}",
                sizeof(decimal),
                decimal.MinValue,
                decimal.MaxValue
            );
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("char DataType having size is {0} ", sizeof(char));
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("bool DataType having size is {0} ", sizeof(bool));
            Console.WriteLine("*****************************************************************");

            // Reference Data Types

            /*
            Reference Data Types : The Reference Data Types will contain a memory address of variable   value because the reference types won’t store the variable value directly in memory. The built-in reference types are string, object.
            there are only two refernce data type are
            01. string
            02. Object
             */



            /*
            Pointer Data Type : The Pointer Data Types will contain a memory address of the variable value.To get the pointer details we have a two symbols ampersand (&) and asterisk (*).
ampersand (&): It is Known as Address Operator. It is used to determine the address of a variable.
asterisk (*): It also known as Indirection Operator. It is used to access the value of an address.
             */



            //Program all data types are :-

            // Value data types

            char ch = 'G';
            int i = 89;
            short s = 56;
            long l = 4546;
            uint ui = 95;
            ushort us = 76;
            ulong ul = 36524156;
            double d = 7.1546154d;
            float f = 4698.164f;
            bool b = true;
            decimal dec = 3258.96m;

            Console.WriteLine($"Character value is {ch}");
            Console.WriteLine($"Integer value is {i}");
            Console.WriteLine($"Short value is {s}");
            Console.WriteLine($"Long value is {l}");
            Console.WriteLine($"Unsigned Integer value is {ui}");
            Console.WriteLine($"Unsigned Short value is {us}");
            Console.WriteLine($"Unsigned Long value is {ul}");
            Console.WriteLine($"Double value is {d}");
            Console.WriteLine($"Float vcalue is {f}");
            Console.WriteLine($"Boolean value is {b} ");
            Console.WriteLine($"Decimal value is {dec}");

            // Reference Data Types

            string str = "Hello  Welcome to C# Programming language";

            Console.WriteLine($"String value is {str}");

            Object obj;
            obj = 20;
            Console.WriteLine($"Object value is {obj}");
            Console.WriteLine($"Getting type of object is {obj.GetType()}");


            // Pointer DataTypes

            int num = 10;
            // int* p = &num;


            Console.WriteLine($"Value of num is {num}");
            // Console.WriteLine($"Address gof num is {(int)p}");

        }
    }
}
