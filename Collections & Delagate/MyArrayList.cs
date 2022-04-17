using System;
using System.Collections;


namespace Collection
{
    class MyArrayList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Sal { get; set; }

        static void Main(string[] args)
        {

            ArrayList arrlst = new ArrayList()
            {
            new MyArrayList { Id = 1, Name = "John", Sal = 10000 },
            new MyArrayList { Id = 2, Name = "Mark", Sal = 15000 },
            new MyArrayList { Id = 3, Name = "Jack", Sal = 20000 },

            };
            Console.WriteLine("The Employee detais in Arraylist are :");
            foreach (MyArrayList arr in arrlst)
            {
                Console.WriteLine(arr.Id + "," + arr.Name +"," + arr.Sal);
            }
            Console.ReadLine();
        }
    }
}
