using System;


namespace DelegateDemo
{

    
    
    public class Program
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public delegate void AddDelegate();

        public void employee1()
        {
            Console.WriteLine(Name = "John");
            
        }
        public void employee2()
        {
            Console.WriteLine(Name = "Mark");
            
        }

        public void employee3()
        {
            Console.WriteLine(Name = "Jack");
            
        }


        static void Main(string[] args)
        {
            Program details = new Program();
            Program.AddDelegate emp1 = new Program.AddDelegate(details.employee1);
            Program.AddDelegate emp2 = new Program.AddDelegate(details.employee2);
            Program.AddDelegate emp3 = new Program.AddDelegate(details.employee3);


            emp1();
            emp2();
            emp3();
            Console.ReadKey();
        }

        
    }

    
}
