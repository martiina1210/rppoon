using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rppoon_dz1
{
    class Payment : Transaction
    {
        public decimal AmountOfMoney { get; set; }
        public decimal BalanceOfMoney { get; private set; }

        public Payment(DateTime dateOfTransaction, string transactionId,decimal amountOfMoney, decimal balanceOfMoney)
            :base(dateOfTransaction,transactionId)
        {
            AmountOfMoney = amountOfMoney;
            BalanceOfMoney = balanceOfMoney;
        }

        public override void Perform()
        {
            Console.WriteLine("Give or take some money");
        }


    }
}
