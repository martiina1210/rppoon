using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rppoon_dz1
{
    internal class TransactionA : ITransaction
    {
        public string TransactionName { get; set; }

        public TransactionA(string transactionName)
        {
            TransactionName = transactionName;
        }
        public void PerformTransaction()
        {
            Console.WriteLine("Perform this transaction");
        }

        public void TransferMoney(decimal amount)
        {
            Console.WriteLine("Transfer money");
        }

        public void WithdrawalOfMoney(decimal amount)
        {
            Console.WriteLine("This is a WithdrawalOfMoney");
        }
    }
}
