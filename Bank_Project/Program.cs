using Bank_Project.classe;


Person client = new Person();
client.FirstName = "Gaëtan";
client.LastName = "Massart";
client.BirthDate = new DateTime(1982, 9, 9);

Current account1 = new Current();
account1.Number = "BE68 5689 2634 4568";
account1.CreditLine = 500;
account1.Owner = client;

Current account2 = new Current();
account2.Number = "BE95 1679 3154 6428";
account2.CreditLine = 500;
account2.Owner = client;
account2.Deposit(1000);

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

Console.WriteLine("");
Console.WriteLine($"L'avoir des compte de {client.FullName} est de {bank.AccountsAssets(client)}");
