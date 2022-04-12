using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStack
{
    class CustomException
    {
    public static void Main()
        {
            try
            {
                
                Console.Write("Enter the number of elemnts in stack :");
                Stack stack = new Stack();
                int n = Convert.ToInt32(Console.ReadLine());
                if (n == 0)
                {
                    throw new StackException();
                }
                else if(n >5)
                    {
                    throw new FullStackException();
                }

                Console.WriteLine("Enter the Elements :");
                for (int i = 0; i < n; i++)
                {
                    stack.Push(Console.ReadLine());
                }
                Console.WriteLine("The elements in the stack are :");
                foreach (var item in stack)
                {
                    Console.WriteLine(item);
                }

                stack.Pop();
                Console.WriteLine("Elements remaining after pop :");
                foreach (var item in stack)
                    Console.WriteLine(item);

                
            }
            catch (StackException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FullStackException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public class StackException : Exception
        {
            public StackException() : base("The Stack is empty")
            {

            }
        }
            public class FullStackException : Exception
            {
                public FullStackException() : base("The Stack is Full")
                {

                }
            }
            

        

    }
}
