using System;


namespace DelegateDemo
{
    public class Bank
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }

        public delegate void BalanceEventHendler(object source, object B);
        public event BalanceEventHendler ZeroBalanced;

        protected virtual void OnZeroBalanced()
        {
            if (ZeroBalanced != null)
            {
                ZeroBalanced(this, this.Balance);
            }

        }

        public Bank(int ID, String Name, double Sal)
        {
            this.Id = ID;
            this.Name = Name;
            this.Balance = Sal;
        }


        public double Credit(double value)
        {
            Balance += value;
            return Balance;
        }

        public double Debit(double val)
        {
            Balance -= val;
            return Balance;
        }


        public bool UnderBalance()
        {
            if (Balance < 2000)
            {
                OnZeroBalanced();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool BalanceZero()
        {
            if (Balance == 0)
            {
                OnZeroBalanced();
                return true;
            }
            else
            {
                return false;
            }
        }
    }



    public class Message
    {
        public void OnZeroBalanced(object source, object B)
        {
            Console.WriteLine("Your Account Balance is below minimum balance");
                Console.WriteLine("\nYour Current Balance is : {B}");
        }
    }


    public class MainClass
    {
        public static void Main(string[] args)
        {
            Bank a1 = new Bank(100, "Sreehari", 2000);
            var message = new Message();

            a1.ZeroBalanced += message.OnZeroBalanced;
            a1.UnderBalance();
        }
    }
}