using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_17
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount<int> bankAccount1 = new BankAccount<int>();
            bankAccount1.NumberAccount = 123456;
            bankAccount1.Balance = 123.25;
            string[] fio1 = { "Сергеевич", "Сергей", "Сергеев"};
            bankAccount1.FIO = fio1;
            bankAccount1.Print();

            Console.WriteLine();

            BankAccount<string> bankAccount2 = new BankAccount<string>();
            bankAccount2.NumberAccount = "f1g2h5";
            bankAccount2.Balance = 1203.25;
            string[] fio2 = { "Иванов", "Иван", "Иванович" };
            bankAccount2.FIO = fio2;
            bankAccount2.Print();

            

            Console.ReadKey();
        }
    }
    public class BankAccount<T>
    {
        private T numberAccount;
        private double balance;
        private string[] fio;
        
        public T NumberAccount { get { return numberAccount; } set { numberAccount = value; } }
        public double Balance { get { return balance; } set { balance = value; } }
        public string[] FIO { get { return fio; } set { fio = value; } }        
        
        public void Print()
        {
            Console.WriteLine("Номер счета: {0}\nБаланс: {1}", numberAccount,balance);
            Console.Write("ФИО владельца счета: ");
            for (int i = 0; i < fio.Length; i++)
            {
                Console.Write("{0} ", fio[i]);
            }
            Console.WriteLine();
        }

    }
}
