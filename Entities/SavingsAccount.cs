namespace Principal.Entities {
    class SavingsAccount : Account {
        public double InterestRate { get; set; }

        public SavingsAccount () {

        }

        public SavingsAccount (int number, string holder, double balance, double interestRate) : base (number, holder, balance) {
            InterestRate = interestRate;
        }

        public void updateBalance() {
            Balance *= Balance * InterestRate;
        }

        public override void Withdraw (double amount) {
            if (amount < Balance && amount > 0) 
            {
                Balance -= amount;
            }
        }
    }
}