using ExSobreposicaoVirtualOverride.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExClasseSelada.Entities
{
    internal class SavingAccountPlus: SavingsAccount
    {
        public override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 3.0;
        }
    }
}
