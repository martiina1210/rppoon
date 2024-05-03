using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rppoon_dz1
{
    interface ITransaction
    {
        public void TransferMoney(decimal amount);
        public void WithdrawalOfMoney(decimal amount);
        public abstract void PerformTransaction();
    }
}
