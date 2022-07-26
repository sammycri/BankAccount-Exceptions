using System;
using System.Globalization;
using Exercicio155.Entities;
using Exercicio155.Entities.Exceptions;

namespace Exercicio155
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter the account number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Account Owner name: ");
                string ownerName = Console.ReadLine();
                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine());
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine());

                Account contaUm = new Account(number, ownerName, balance, withdrawLimit);
                Console.WriteLine(contaUm.ToString());

                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                contaUm.Withdraw(double.Parse(Console.ReadLine()));

                Console.WriteLine("New balance: " + contaUm.Balance);
            }
            catch (DomainException e)
            {
                Console.WriteLine(e.Message);
            }



        }
    }
}
