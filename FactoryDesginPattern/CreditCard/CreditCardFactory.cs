using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCard
{
    public class CreditCardFactory
    {
        public static ICreditCard GetCreditCard(string creditTpye)
        {
            return creditTpye == "MoneyBack" ? new MoneyBackCard() : 
                creditTpye == "Titanium" ? new TitaniumCard() :
                creditTpye == "Platinium" ? new PlatiniumCard() : null;
        }
    }
}
