using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rppoon_dz1
{
    abstract class Transaction
    {
        public DateTime DateOfTransaction { get; set; }
        public string TransactionId { get; set; }

        public Transaction(DateTime dateOfTransaction, string transactionId)
        {
            DateOfTransaction = dateOfTransaction;
            TransactionId = transactionId;
        }

        public abstract void Perform();
        

        
    }
}
