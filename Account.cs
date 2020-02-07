using System;
using System.Collections.Generic;

namespace DefaultNamespace
{
    public class Account
    {
        public decimal Balance { get; }
        //account gets the balance and sets the balance 
        public string AccountHolder { get; set; }
        //account gets the name of the account holder 
        
        public void ChangeBalance(decimal amount)
        {
            
        }
    }
}