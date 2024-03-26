using Bank_Project.classe;
using Bank_Project.Interfaces;


Person client = new Person("Gaëtan", "Massart", new DateTime(1982, 9, 9));
//client.FirstName = "Gaëtan";
//client.LastName = "Massart";
//client.BirthDate = new DateTime(1982, 9, 9);

Current account1 = new Current(client, "BE68 5689 2634 4568", 500);
//account1.Number = "BE68 5689 2634 4568";
//account1.CreditLine = 500;
//account1.Owner = client;

Current account2 = new Current(client, "BE95 1679 3154 6428", 500, 750);
//account2.Number = "BE95 1679 3154 6428";
//account2.CreditLine = 500;
//account2.Owner = client;
//account2.Deposit(750);

Saving saving1 = new Saving("BE98 6847 4578 7998", client, 500_000);
//saving1.Number = "BE98 6847 4578 7998";
//saving1.Owner = client;
//saving1.Deposit(500_000);

bool again = true;

do
{
    Console.Clear();
    Console.WriteLine($"Bonjour {client.FirstName} {client.LastName}.");
    Console.WriteLine("");

    Console.WriteLine($"Voici votre solde : {account1.Balance}");
    Console.WriteLine("Que souhaitez-vous faire ?");
    Console.WriteLine("1) Retirer");
    Console.WriteLine("2) Déposer");
    Console.WriteLine("3) Quitter");

    switch (Console.ReadLine())
    {
        case "1":
            Console.WriteLine("Veuillez entrer le montant à retirer sur votre compte.");

            if (double.TryParse(Console.ReadLine(), out double withdrawAmount))
            {
                account1.Withdraw(withdrawAmount);
            }
            break;
        case "2":
            Console.WriteLine("Veuillez entrer le montant à déposer sur votre compte.");

            if (double.TryParse(Console.ReadLine(), out double depositAmount))
            {
                account1.Deposit(depositAmount);
            }
            break;
        case "3":
            again = false;
            break;
        default:
            Console.WriteLine("Commande inconnue");
            break;
    }
}while (again);

Bank bank = new Bank();
bank.Name = "MaBanque";

bank.Add(account1);
Console.WriteLine($"La banque {bank.Name} a un compte appartenant à : {bank[account1.Number].Owner.FullName}");

Console.WriteLine("");
bank.Add(account1);

bank.Add(account2);

bank.Add(saving1);

saving1.ApplyBenefit();

Console.WriteLine($"L'avoir des compte de {client.FullName} est de {bank.AccountsAssets(client)}");

IBanker banker = account2;
ICustomer customer = account2;

customer.Deposit(7);
Console.WriteLine($"{customer.Balance}");

account2.ApplyBenefit();
Console.WriteLine($"{banker.Balance} {banker.Owner.FullName}");
