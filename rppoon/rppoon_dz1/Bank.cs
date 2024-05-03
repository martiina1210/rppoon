using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rppoon_dz1
{
    class Bank
    {
        public string UserName { get; private set; }
        public string BankId { get; private set; }
        public string BankName { get; set;}

        public Bank(string userName, string bankId, string bankName)
        {
            UserName = userName;
            BankId = bankId;
            BankName = bankName;
        }

        public void SetBankName(string bankName)
        {
            BankName = bankName;
        }

        public void SetUserName(string  userName)
        {
            UserName = userName;
        }
    }
    
}
