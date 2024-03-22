
namespace Bank_Project.classe
{
    internal class Bank
    {
        public string Name { get; set; }
        private Dictionary<string, Account> _listAccount = new Dictionary<string, Account>();

        public Account this[string number]
        {
            get
            {
                Account account;
                _listAccount.TryGetValue(number, out account);
                return account;
            }
            set
            {
                _listAccount[number] = value;
            }
        }

        public void Add(Account account)
        {
            if (_listAccount.ContainsKey(account.Number))
            {
                Console.WriteLine("Error : this account already exists");
                return;
            }

            _listAccount.Add(account.Number, account);
        }

        public void delete(string number)
        {
            if (!_listAccount.ContainsKey(number))
            {
                Console.WriteLine("Error : This account does not exist");
                return;
                // TODO exception
            }

            _listAccount.Remove(number);
            Console.WriteLine($"Account {number} deleted.");
        }

        public double AccountsAssets(Person person)
        {
            double assets = 0;

            foreach (Account account in _listAccount.Values)
            {
                if (person.Equals(account.Owner)) 
                {
                    assets += account;
                }
            }
            return assets;
        }
    }
}


