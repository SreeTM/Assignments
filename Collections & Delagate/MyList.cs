using System;
using System.Collections.Generic;


namespace Collection
{
    internal class MyList
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        
        public MyList (int id, string name, int sal)
        {
            this.Id = id;
            this.Name = name;
            this.Salary = sal;
            
        }

        public static void Main()
        {
            List<MyList> details = new List<MyList>();
            MyList emp1 = new MyList(1, "John", 10000);
            MyList emp2 = new MyList(2, "Mark", 15000);
            MyList emp3 = new MyList(3, "Jack", 20000);
            
            details.Add(emp1);
            details.Add(emp2);
            details.Add(emp3);

            Console.WriteLine("The Employee detais are :");
            foreach (MyList list in details)
            {                
                Console.WriteLine(list.Id + ","+ list.Name +","+ list.Salary);
            }

            Console.WriteLine("\nTotal number of employees are : " + details.Count);
            Console.ReadKey();

        }
    }
}

