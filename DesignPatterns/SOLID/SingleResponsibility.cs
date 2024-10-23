namespace DesignPatterns.SOLID
{
    public class SingleResponsibility
    {
    }


    //only responsible for account related things
    public class Account
    {
        public int Id { get; set; }
        public decimal Balance { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string PhoneNumber { get; set; }
        = string.Empty;
        public Account() { }
        public void setName(string name) { }
        public void setEmail(string email) { }
        public void setPhone(string phone) { }
        public void setPhoneNumber(string phone) { }

    }
    public class AccountOperation
    {
        Dictionary<int, Account> accounts = new Dictionary<int, Account>();
        public Account GetAccount(Account account)
        {
            return accounts[account.Id];
        }
        public void AddAccount(Account account)
        {
            accounts[account.Id] = account;
        }
        public void RemoveAccount(Account account)
        {
            accounts.Remove(account.Id);
        }

        //update balance is not the part of AccountOperation 
        // this mean violating single responsible principle 
        //by creating the new class that handle the amount transation obey the priciple
        public Boolean deposit(int amount, int accountId)
        {
            if (accounts.ContainsKey(accountId))
            {
                accounts[accountId].Balance += amount;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    public class Transations
    {
        Dictionary<int, Account> accounts = new Dictionary<int, Account>();
        public bool deposit(int amount, int accountId)
        {
            if (accounts.ContainsKey(accountId))
            {
                accounts[accountId].Balance += amount;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool withdrawal(int amount, int accountId)
        {
            if (accounts.ContainsKey(accountId))
            {
                if (accounts[accountId].Balance > amount)
                {
                    accounts[accountId].Balance -= amount;
                    return true;
                }

            }
            return false;
        }
    }
}
