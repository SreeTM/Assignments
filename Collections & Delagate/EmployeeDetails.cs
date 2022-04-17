using System;

namespace DelegateDemo
{
    public delegate void Delagate();

    internal class EmployeeDetails
    {

        private int EmpNo;
        private string EmpName;
        private double Salary;
        private double HRA;
        private double TA;
        private double DA;
        private double PF;
        private double TDS;
        private double NetSalary;
        private double GrossSalary;
       
        public EmployeeDetails(int Empno, string Empname, double Sal)
        {
            EmpNo = Empno;
            EmpName = Empname;
            Salary = Sal;
            
            if (Salary < 5000)
            {
                HRA = Salary * 10 / 100;
                TA = Salary * 5 / 100;
                DA = Salary * 15 / 100;
                GrossSalary = Salary + HRA + TA + DA;
            }
            else if (Salary < 10000)
            {
                HRA = Salary * 15 / 100;
                TA = Salary * 10 / 100;
                DA = Salary * 20 / 100;
                GrossSalary = Salary + HRA + TA + DA;
            }
            else if (Salary < 15000)
            {
                HRA = Salary * 20 / 100;
                TA = Salary * 15 / 100;
                DA = Salary * 25 / 100;
                GrossSalary = Salary + HRA + TA + DA;
            }
            else if (Salary < 20000)
            {
                HRA = Salary * 25 / 100;
                TA = Salary * 20 / 100;
                DA = Salary * 30 / 100;
                GrossSalary = Salary + HRA + TA + DA;
            }
            else
            {
                HRA = Salary * 30 / 100;
                TA = Salary * 25 / 100;
                DA = Salary * 35 / 100;
                GrossSalary = Salary + HRA + TA + DA;
            }
        }
        public virtual void CalculateSalary()
        {
            PF = GrossSalary * 10 / 100;
            TDS = GrossSalary * 18 / 100;
            NetSalary = GrossSalary - (PF + TDS);
        }
        public virtual void Grosssal()
        {
            Console.WriteLine(GrossSalary);
        }


        class Manager : EmployeeDetails  
        {

            private double PA;
            private double FA;
            private double OA;
            public Manager(int Empno, string Empname, double Sal) : base(Empno, Empname, Sal)
            {
                PA = Salary * 8 / 100;
                FA = Salary * 13 / 100;
                OA = Salary * 3 / 100;

            }


           
            public override void Grosssal()
            {
                Console.WriteLine("Manager GrossSalary");
                GrossSalary = GrossSalary + PA + FA + OA;
                Console.WriteLine(GrossSalary);

            }
            public override void CalculateSalary()
            {
                Console.WriteLine("Manager Net Salary");
                PF = GrossSalary * 10 / 100;
                TDS = GrossSalary * 18 / 100;
                NetSalary = GrossSalary - (PF + TDS);
                Console.WriteLine(NetSalary);
            }
        }
        class MarketingExecutive : EmployeeDetails   
        {


            private double KT;
            private double TA;
            

            private double TeleAllow = 1000;

            public MarketingExecutive(int Empno, string Empname, double Sal) : base(Empno, Empname, Sal)
            {

                KT = 15;
                TA = 5 * KT;
                TeleAllow = 1000;
            }


            public override void Grosssal()
            {
                Console.WriteLine("MarketingExecutive Grosssalary");
                GrossSalary = GrossSalary + TA + TeleAllow;
                Console.WriteLine(GrossSalary);

            }

            public override void CalculateSalary()
            {
                Console.WriteLine("MaarketingExecutive NetSalary");
                PF = GrossSalary * 10 / 100;
                TDS = GrossSalary * 18 / 100;
                NetSalary = GrossSalary - (PF + TDS);
                Console.WriteLine(NetSalary);


            }
        }
        public static void Main(string[] args)
        {

            Manager M1 = new Manager(1, "Sree", 25000);
            Delagate MD = new Delagate(M1.Grosssal);
            MD += new Delagate(M1.CalculateSalary);
            MD();

            MarketingExecutive M2 = new MarketingExecutive(1, "Hari", 12000);
            Delagate MED = new Delagate(M2.Grosssal);
            MED += new Delagate(M2.CalculateSalary);
            MED();

            Console.ReadLine();

        }
    }

}

