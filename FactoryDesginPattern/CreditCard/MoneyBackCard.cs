﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCard
{
    public class MoneyBackCard : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 10000;
        }

        public string GetCardType()
        {
            return "Money Back"; 
        }

        public int GetCreditLimit()
        {
            return 100;
        }
    }
}
