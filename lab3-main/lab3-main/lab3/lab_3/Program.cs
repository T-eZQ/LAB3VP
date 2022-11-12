using lab_1.lab_2;
using System;

namespace lab_3
{
    class Program
    {
        private static void lab_2()
        {
            ushort t1 = ((ushort)456);
            RomanNumber b1 = new RomanNumber(t1);
            ushort t2 = ((ushort)321);
            RomanNumber b2 = new RomanNumber(t2);
            Console.WriteLine("456 = " + b1.ToString());
            Console.WriteLine("321 = " + b2.ToString());
            Console.WriteLine("456 + 321 = 777 || " + b1.ToString() + " + " + b2.ToString() + " = " + (b1 + b2));
            Console.WriteLine("456 - 321 = 777 || " + b1.ToString() + " - " + b2.ToString() + " = " + (b1 - b2));
            ushort t3 = ((ushort)12);
            ushort t4 = ((ushort)6);
            RomanNumber b3 = new RomanNumber(t3);
            RomanNumber b4 = new RomanNumber(t4);
            Console.WriteLine("12 * 6 = 72 || " + b3.ToString() + " * " + b4.ToString() + " = " + (b3*b4));
            Console.WriteLine("12 / 6 = 2 || " + b3.ToString() + " / " + b4.ToString() + " = " + (b3/b4));
            short[] Values = new short[]
            { 1000, 777, 601, 444, 112, 72, 55, 41, 16, 9, 7, 3, 1 };
            RomanNumber[] b5 = new RomanNumber[Values.Length];
            Console.WriteLine("Array:");
            for (int i = 0; i < Values.Length; ++i)
            {
                b5[i] = new RomanNumber(((ushort)Values[i]));
                Console.Write(Values[i] + "(" + b5[i].ToString() + ")" + " ");
            }
            Console.WriteLine("\nSorted Array:");
            Array.Sort(b5);
            foreach (object el in b5)
            {
                Console.Write(el.ToString() + " ");
            }
        }
        static void Main(string[] args)
        {
            lab_2();
        }
    }
}
