﻿using Boolean.CSharp.Main.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main.Concretes
{
    public class Customer : ICustomer
    {
        private List<IAccount> _accounts = new();
        public void AddAccount(IAccount account)
        {

            _accounts.Add(account);
        }

        public List<IAccount> GetAccounts()
        {
            return _accounts;
        }
    }
}
