using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LitwareLib
{
    internal class Employee
    {

        private int EmpNo;
        private String EmpName;
        private double Salary;
        private double HRA;
        private double TA;
        private double DA;
        private double PF;
        private double TDS;
        private double NetSalary;
        private double GrossSalary;

        public Employee(int id, String Name, double Sal)
        {
            EmpNo = id;
            EmpName = Name;
            Salary = Sal;

            if (Sal < 5000)
            {
                HRA = Salary * 10 / 100;
                TA = Salary * 5 / 100;
                DA = Salary * 15 / 100;
                GrossSalary = Salary + HRA + TA + DA;
            }

            else if (Sal < 10000)
            {
                HRA = Salary * 15 / 100;
                TA = Salary * 10 / 100;
                DA = Salary * 20 / 100;
                GrossSalary = Salary + HRA + TA + DA;
            }

            else if (Sal < 15000)
            {
                HRA = Salary * 20 / 100;
                TA = Salary * 15 / 100;
                DA = Salary * 25 / 100;
                GrossSalary = Salary + HRA + TA + DA;
            }

            else if (Sal < 20000)
            {
                HRA = Salary * 25 / 100;
                TA = Salary * 20 / 100;
                DA = Salary * 30 / 100;
                GrossSalary = Salary + HRA + TA + DA;
            }

            else if (Sal >= 20000)
            {
                HRA = Salary * 30 / 100;
                TA = Salary * 25 / 100;
                DA = Salary * 35 / 100;
                GrossSalary = Salary + HRA + TA + DA;
            }
        }

        public void CalculateSalary()
        {
            PF = GrossSalary * 10 / 100;
            TDS = GrossSalary * 18 / 100;
            NetSalary = GrossSalary - (PF + TDS);
        }

        public double GrossSal
        {
            get { return GrossSalary; }
        }



        static void Main(string[] args)
        {
            Employee Emp  = new Employee(1,"Sreehari",5000);
            Emp.CalculateSalary();
             Console.WriteLine("The Gross salary of is :" + Emp.GrossSalary);
             Console.WriteLine("The Net salary is :" + Emp.NetSalary);

        }


    }
}
