using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер счета:");
            int accountnumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите номер счета (прописью):");
            string accountstring = Console.ReadLine();
            Console.Write("Введите баланс счета:");
            double accountbalance = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите полное имя:");
            string fio = Console.ReadLine();
            Account<int> account1 = new Account<int>(accountnumber, accountbalance, fio);            
            account1.Input();
            Account<string> account2 = new Account<string>(accountstring, accountbalance, fio);
            account2.Input();
            Console.ReadKey();
        }
    }
    class Account<T>
    {
        private T AccountNumber;
        private double AccountBalance;
        private string AccountName;
        public Account(T accountnumber, double accountbalance, string accountname)
        {
            AccountNumber = accountnumber;
            AccountBalance = accountbalance;
            AccountName = accountname;
        }
        public void Input()
        {
            Console.WriteLine($"Номер счета: {AccountNumber} ");
            Console.WriteLine($"Баланс счета:{AccountBalance} ");
            Console.WriteLine($"ФИО:{AccountName} ");
        }
    }
}

