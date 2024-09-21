namespace BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //runUppgift1();
            runUppgift2();
        }

        static void runUppgift1()
        {
            //Instansiera bankAccount klassen och testa den
            Employee salary = new Employee("Edrisa", "Jallow");
            salary.Salary = 3000;

            Console.WriteLine($"Annual Salary: {salary.GetAnnualSalary()}");

            salary.GiveRaise(10);
            Console.WriteLine($"New Monthly Salary: {salary.Salary}");
            Console.WriteLine($"New Annual Salary: {salary.GetAnnualSalary()}");
        }

        static void runUppgift2()
        {
            BankAccount account = new BankAccount("123456789", "Håkan Kråkan", 1000);

            account.Deposit(500);
            account.Withdraw(200);
            account.DisplayBalance();
        }
    }
}
