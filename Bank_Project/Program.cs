using Bank_Project.classe;

Person client = new Person();
client.FirstName = "Gaëtan";
client.LastName = "Massart";
client.BirthDate = new DateTime(1982, 9, 9);

Current account = new Current();
account.Number = "856954833157";

account.CreditLine = 500;
account.Owner = client;

Console.WriteLine($"Bonjour {client.FirstName} {client.LastName}.");
Console.WriteLine("");

Console.WriteLine($"Montant à découvert autorisé : -{account.CreditLine}");
Console.WriteLine($"Solde avant dépôt : {account.Balance}");
Console.WriteLine("");

Console.WriteLine("Veuillez entrer le montant à déposer sur votre compte");
account.Deposit(double.Parse(Console.ReadLine()));
Console.WriteLine($"Solde après dépôt : {account.Balance}");
Console.WriteLine("");

Console.WriteLine("Veuillez entrer le montant à retirer sur votre compte");
account.Withdraw(double.Parse(Console.ReadLine()));
Console.WriteLine($"Solde restant après retrait : {account.Balance}");
