using Principal.Entities;

namespace Principal {
    class Program {
        static void Main(string[] args) {

            Account conta = new Account(1001, "Jonh", 0.0);
            BusinessAccount businessAcount = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            //UpCasting

            Account conta1 = businessAcount;
            Account conta2 = new BusinessAccount(1003, "Gustavo", 0.0, 500.0);
            Account conta3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

            //DownCasting

            BusinessAccount conta4 = (BusinessAccount)conta2;
            conta4.Loan(100.0);
            //conta2.Loan(100.0);
            //BusinessAccount conta5 = (BusinessAccount) conta3;

            //Se conta3 for uma instância de BusinessAccount:
            if(conta3 is BusinessAccount) {
                //BusinessAccount conta5 = (BusinessAccount)conta3;
                //Outra forma de Casting:
                BusinessAccount conta5 = conta3 as BusinessAccount;
            }

            //Se conta3 for uma instância de SavingsAccount:
            if(conta3 is SavingsAccount) {
                //SavingsAccount conta5 = (SavingsAccount)conta3;
                SavingsAccount conta5 = conta3 as SavingsAccount;
                conta5.updateBalance();
                Console.WriteLine("Update");
            }

        }
    }
}