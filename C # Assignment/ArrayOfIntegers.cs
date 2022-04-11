using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class ArrayOfIntegers
    {
        static void ArraySum()
        {
            int i, n;
            int[] a = new int[100];
            int sum = 0;
            Console.Write("Input the number of elements to store in the array :");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input elements in the array :\n", a);
            for (i = 0; i < n; i++)
            {
                
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            
            for (i = 0; i < n; i++)
            {
                sum = sum + a[i];
            }
            Console.WriteLine("Sum of the array is : " + sum);
        }

        static void Main(String[] args)
        {
            ArraySum();
        }
    }
}
