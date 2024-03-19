
namespace Bank_Project.classe
{
    internal class Bank
    {
        public string Name { get; set; }
        private Dictionary<string, Current> _listAccount = new Dictionary<string, Current>();

        public Current this[string number]
        {
            get
            {
                Current account;
                _listAccount.TryGetValue(number, out account);
                return account;
            }
            set
            {
                _listAccount[number] = value;
            }
        }

        public void Add(Current account)
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
            }

            _listAccount.Remove(number);
            Console.WriteLine($"Account {number} deleted.");
        }

        public double AccountsAssets(Person person)
        {
            double total = 0;

            foreach (Current account in _listAccount.Values)
            {
                if (person.Equals(account.Owner)) 
                {
                    total += account;
                }
            }
            return total;
        }
    }
}


