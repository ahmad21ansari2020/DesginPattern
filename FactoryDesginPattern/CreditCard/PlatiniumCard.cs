using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCard
{
    public class PlatiniumCard : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 20000;
        }

        public string GetCardType()
        {
            return "Platinium";
        }

        public int GetCreditLimit()
        {

            return 200;
        }
    }
}
