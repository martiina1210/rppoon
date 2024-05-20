using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rppoon_dzedukos
{
    public class SMTP
    {
        IMailConstructor mailConstructor;
        public SMTP(IMailConstructor mailConstructor)
        {
            this.mailConstructor = mailConstructor;
        }

        public void SendNoReplyMail()
        {
            mailConstructor.AddSubject("No Reply").AddContent("Hello World").Construct();
            //Sending logic here

        }
    }
}
