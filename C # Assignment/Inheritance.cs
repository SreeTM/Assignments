using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
}  class Employee // Parent class
    {
        public int NetSalary;
        public int GrossSalary;
    private int PA;
    private int FA;
    private int OA;

    private int KT;
    private int TA;
    private int TeleAllow = 1000;

    public virtual void CalculateSalary()
        {
        
        }

   

    class Manager : Employee // Child 1 class
    {
        

        public override void CalculateSalary() // Using 1st override 
        {
            base.PA = (NetSalary / (8 * 100));
            base.FA = (NetSalary / (13 * 100));
            base.OA = (NetSalary / (3 * 100));
            base.GrossSalary = base.PA + base.FA + base.OA + base.NetSalary;

        }

    }

    class MarketingExecutive : Employee // Child 2 class
    {
       

        
        public override void CalculateSalary() // Using 2nd override
        {
            
            base.TA = (KT * 5);
            base.GrossSalary = base.TA + base.TeleAllow + base.NetSalary;
        }

    }



        static void Main(string[] args)
        {
        Manager man = new Manager();
        Console.WriteLine("Enter the salary of Manager :");
        man.NetSalary = int.Parse(Console.ReadLine());
        man.CalculateSalary();
        

        MarketingExecutive markex = new MarketingExecutive();
        Console.WriteLine("Enter the salary of Marketing Executive :");
        markex.NetSalary = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the Kilometer traveled :");
        markex.KT = int.Parse(Console.ReadLine());
        markex.CalculateSalary();
        

        Console.WriteLine("\n The Gross salary of Manager is :" + man.GrossSalary);
        Console.WriteLine("\n The Gross salary Marketing Executive is :" + markex.GrossSalary);


        }

}
