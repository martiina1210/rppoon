using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rppoon_dz1
{
    class User : IBankAccount
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public void SetMoney(decimal amount)
        {
            Console.WriteLine("Set some amount of money on card");
        }

        public void SetName(string name)
        {
            Console.WriteLine("Set some name on the card");
        }
    }
}
