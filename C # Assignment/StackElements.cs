using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStack
{
    class StackElements
    {
     
        static void Main(string[] args)
        {
            Console.Write("Enter the number of elemnts in stack :");
            Stack st = new Stack();
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Elements :");
            for (int i = 0; i < n; i++)
            {
                st.Push(Console.ReadLine());
            }
            Console.WriteLine("\n The elements in the stack are:");
            foreach (var item in st)
            {
                Console.WriteLine(item);
            }
            if(st.Count > 0)
            Console.WriteLine("\n The pop elements are :" + st.Pop() +"," + st.Pop());

        
        
        }

    }
}
