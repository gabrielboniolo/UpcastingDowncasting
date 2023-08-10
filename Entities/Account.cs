namespace Principal.Entities {
    class Account {
        public int Number { get; set; }
        public string Holder { get; set; }

        public double Balance { get; protected set; }

        public Account() {
        }
        public Account(int number, string holder, double balance) {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void Withdraw (double amount) {
            if (amount < Balance && amount > 0) 
            {
                Balance -= amount - 5.0;
            }
        }

        public void Deposit (double amount) 
        {
            if(amount > 0) 
            {
                Balance += amount;
            }
        }
    }
}