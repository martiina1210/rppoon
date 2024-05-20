using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace rppoon_dzedukos
{

	public class ChromeLoginPageFactory : LoginPageFactory
	{
		public override LoginPage CreatePage()
		{
			return new ChromeLoginPage();
		}
	}

}