using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCard
{
    public class TitaniumCard : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 30000;
        }

        public string GetCardType()
        {
            return "Titanium";
        }

        public int GetCreditLimit()
        {
            return 300;
        }
    }
}
