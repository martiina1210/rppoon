namespace rppoon_dz1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello user! ");
            Bank bank = new Bank("Butterfly", "123", "Banka1");
            Payment payment = new Payment(DateTime.Now, "222", 12333333, 444444444);
            PersonA person = new PersonA("Bee","Bellamy", 213, 20);
            TransactionA transaction = new TransactionA("FirstTransation");

            bank.BankName = "ovaBanka";
            Console.WriteLine($"the name of bank is {bank.BankName}");
            bank.SetBankName("glavnaBanka");
            Console.WriteLine($"the name of bank is {bank.BankName}");
            payment.Perform();
            person.Greet();
            transaction.PerformTransaction();
            transaction.TransferMoney(400);

        }
    }
}