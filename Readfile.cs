using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace Supportbank
{
    public class Readfile
    {
        public static List<Transaction> ReadDataFile()
        {
            var allLines = File.ReadAllLines("Transactions.csv").Skip(1);
            List<Transaction> myTransactionList = new List<Transaction>();
            
            foreach (var line in allLines)
            {
                var newTransaction = CreateTransaction(line);
                myTransactionList.Add(newTransaction);
                Console.WriteLine(line);
            }
            
            return myTransactionList;
        }

        private static Transaction CreateTransaction(string lineOfTheCsvFile)
        {
            var elementsOfLine = lineOfTheCsvFile.Split(",");
            Transaction myTransaction = new Transaction();

            myTransaction.Date = elementsOfLine[0];
            myTransaction.From = elementsOfLine[1];
            myTransaction.To = elementsOfLine[2];
            myTransaction.Narrative = elementsOfLine[3];
            myTransaction.Amount = decimal.Parse(elementsOfLine[4]);
            return myTransaction;
        }
    }

    
}