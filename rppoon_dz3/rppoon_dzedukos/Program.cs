namespace rppoon_dzedukos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //u Mail primjeru riječ je o builderu, a u WebElementu o metodi tvornice
            SMTP smtp = new SMTP(new MailConstructor());
            smtp.SendNoReplyMail();
            /*
            LoginPageFactory factory = new LoginPageFactory();
            LoginPage loginPage = factory.CreatePage();
            loginPage.loginButton().Click(); */
        }
    }
}