using System;

namespace GETBAL
{
    class Program
    {
        static void Main(string[] args)
        {
            BankA a = new BankA();
            a.Getbalance();
            BankB b = new BankB();
            b.Getbalance();
            BankC c = new BankC();
            c.Getbalance();
        }
    }
    public abstract class Bank
    {
        public abstract void Getbalance();
    }
    public class BankA : Bank
    {
        public override void Getbalance()
        {
            Console.WriteLine("The balance in bank A is $100");
        }
    }
    public class BankB : Bank
    {
        public override void Getbalance()
        {
            Console.WriteLine("The balance in bank B is $150");
        }
    }
    public class BankC : Bank
    {
        public override void Getbalance()
        {
            Console.WriteLine("The balance in bank C is $200");
        }

    }
    
}
