﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LabTask4
{
    class Account
    {
        private int account_id;
        private double amount;
        private string accType;

        public Account(int account_id, double amount, string accType)
        {
            this.account_id = account_id;
            this.amount = amount;
            this.accType = accType;
        }
        public void displayAccDetails()
        {
            Console.WriteLine("Account ID= " + account_id);
            Console.WriteLine("Amount= " + amount);
            Console.WriteLine("Account Type= " +accType);
        }
    }
}
