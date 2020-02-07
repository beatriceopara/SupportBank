using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;
using Supportbank;

namespace DefaultNamespace
{
    public class Bank
    {
        //Need Account class to get list of accounts, loop through list of account and return individual account names
        public List<Account> ListOfAccounts;

        public void AddAccountsToList(List<Transaction> transactionList)
        {
            foreach (var transaction in transactionList)
            {
                var transactionName = transaction.To;
                var account = new Account();

                account.AccountHolder = transactionName;
            }
        }
        
    }
};

   


/* How to Define Variables in C#
* private int myInteger;
* public Account MyAccount;
* public Bank myBank;
* private List<Bank> ListOfBanks;
* private List<string> myStringList;
 */