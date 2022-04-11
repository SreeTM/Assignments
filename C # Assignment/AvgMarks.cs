using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class AvgMarks
    {
        public static void Main (string[] args)
    
        {
            int[] student1 = new int[5];
            Console.WriteLine("Enter 5 marks of student1 :");
            for (int i = 0; i < 5; i++)
            {
                student1[i] = Convert.ToInt32(Console.ReadLine());
            }

            int[] student2 = new int[5];
            Console.WriteLine("Enter 5 marks of student2 :");
            for (int j = 0; j < 5; j++)
            {
                student2[j] = Convert.ToInt32(Console.ReadLine());
            }

            int[] student3 = new int[5];
            Console.WriteLine("Enter 5 marks of student3 :");
            for (int k = 0; k < 5; k++)
            {
                student3[k] = Convert.ToInt32(Console.ReadLine());
            }

            int[] student4 = new int[5];
            Console.WriteLine("Enter 5 marks of student4 :");
            for (int l = 0; l < 5; l++)
            {
                student4[l] = Convert.ToInt32(Console.ReadLine());
            }

            int[] student5 = new int[5];
            Console.WriteLine("Enter 5 marks of student5 :");
            for (int m = 0; m < 5; m++)
            {
                student5[m] = Convert.ToInt32(Console.ReadLine());
            }

            int sum1 = student1.Sum(x => x);
            int sum2 = student2.Sum(x => x);
            int sum3 = student3.Sum(x => x);
            int sum4 = student4.Sum(x => x);
            int sum5 = student5.Sum(x => x);
            Console.WriteLine("The Sum of Student1 is :" + sum1);
            Console.WriteLine("The Sum of Student2 is :" + sum2);
            Console.WriteLine("The Sum of Student3 is :" + sum3);
            Console.WriteLine("The Sum of Student4 is :" + sum4);
            Console.WriteLine("The Sum of Student5 is :" + sum5);

            int avg1 = sum1 / 5;
            int avg2 = sum2 / 5;
            int avg3 = sum3 / 5;
            int avg4 = sum4 / 5;
            int avg5 = sum5 / 5;

            Console.WriteLine("The average marks of Student1 is :" + avg1);
            Console.WriteLine("The average marks of Student2 is :" + avg2);
            Console.WriteLine("The average marks of Student3 is :" + avg3);
            Console.WriteLine("The average marks of Student4 is :" + avg4);
            Console.WriteLine("The average marks of Student5 is :" + avg5);

            int[] largest = { avg1, avg2, avg3, avg4, avg5 };
           Console.WriteLine("The highest average mark obtained is :" + largest.Max());


        }
    }
}
