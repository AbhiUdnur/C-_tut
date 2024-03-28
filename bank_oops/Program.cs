
bool IsSuccessful = true;

CheckingAcct checking = new CheckingAcct("John", "Doe", 2500.0m);
IsSuccessful &= (checking.Balance == 2500.0m);
IsSuccessful &= (checking.AccountOwner == "John Doe");


SavingsAcct saving = new SavingsAcct("Jane", "Doe", 0.03m, 1000.0m);
IsSuccessful &= (saving.Balance == 1000.0m);
IsSuccessful &= (saving.AccountOwner == "Jane Doe");

checking.Deposit(200.0m);
saving.Deposit(150.0m);
IsSuccessful &= (checking.Balance == 2700.0m);
IsSuccessful &= (saving.Balance == 1150.0m);


checking.Withdraw(50.0m);
saving.Withdraw(125.0m);
IsSuccessful &= (checking.Balance == 2650.0m);
IsSuccessful &= (saving.Balance == 1025.0m);

saving.ApplyInterest();
IsSuccessful &= (saving.Balance == 1055.75m);

saving.Withdraw(10.0m);
saving.Withdraw(20.0m);
saving.Withdraw(30.0m);
IsSuccessful &= (saving.Balance == 993.75m);

saving.Withdraw(2000.0m);

checking.Withdraw(3000.0m);
IsSuccessful &= (saving.Balance == 993.75m);
IsSuccessful &= (checking.Balance == -385.00m);