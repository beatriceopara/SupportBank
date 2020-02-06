using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

namespace Supportbank
{
    public class Readfile
    {
        public static List<IndividualTransactions> ReadDataFile()
        {
            // string myString = "hello";
            //
            // string: The type of variable we are creating.
            // myString: The name of the variable we are creating.
            // "hello": The value our variable has right now.
            
            
            var allLines = File.ReadAllLines("Transactions.csv").Skip(1);
            List<IndividualTransactions> myTransactionList = new List<IndividualTransactions>();
            
            foreach (var line in allLines)
            {
                var newTransaction = CreateTransaction(line);
                myTransactionList.Add(newTransaction);
                Console.WriteLine(line);
            }
            
            return myTransactionList;
        }

        private static IndividualTransactions CreateTransaction(string lineOfTheCsvFile)
        {
            var elementsOfLine = lineOfTheCsvFile.Split(",");
            IndividualTransactions myTransaction = new IndividualTransactions();

            myTransaction.Date = elementsOfLine[0];
            myTransaction.From = elementsOfLine[1];
            myTransaction.To = elementsOfLine[2];
            myTransaction.Narrative = elementsOfLine[3];
            myTransaction.Amount = decimal.Parse(elementsOfLine[4]);
            return myTransaction;
        }
    }

    public class IndividualTransactions
    {
       public string Date { get; set; }
       public string From { get; set; }
       public string To { get; set; }
       public string Narrative { get; set; }
       public decimal Amount { get; set; }
    }
}