using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Calculator
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number :");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number :");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Type p for Addition");
            Console.WriteLine("Type q for Subatraction");
            Console.WriteLine("Type r for Multiplication");
            Console.WriteLine("Type s for Division");
            String t = Console.ReadLine();


            int p = a + b;
            int q = a - b;
            int r = a * b;
            int s = a / b;
            switch (t)
            {
                case "p":
                    Console.WriteLine("The answer is : " + p);
                    break;
                case "q":
                    Console.WriteLine("The answer is : " + q);
                    break;
                case "r":
                    Console.WriteLine("The answer is : " + r);
                    break;
                case "s":
                    Console.WriteLine("The answer is : " + s);
                    break;
                    
                    
            }


           
        }
    }
}
