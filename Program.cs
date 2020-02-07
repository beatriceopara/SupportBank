using System;

namespace Supportbank
{
    class Program
    {
        static void Main(string[] args)
        {
            var transactionList = Readfile.ReadDataFile();
            Console.WriteLine(transactionList);
            /*
            Need Readfile class to read the CSV file and create list of transactions
            Need Transaction class to store data inputted 
            Need Bank class to create list of accounts 
            Need Account class to get list of accounts, loop through list of account and return individual account names 
            Need Account class to get list of transactions, loop through transactions and return total balance
            Need Account class to have method that changes the balance when balance is owed or balance is deducted
            Need Printer class to display all accounts name, total they owe or are owed
            Need Printer class to display account and get/display every transaction with date and narrative
            */
        }
    }
}