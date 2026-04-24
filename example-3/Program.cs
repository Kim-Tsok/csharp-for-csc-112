// Object: A specific instance created from the blueprint.
BankAccount acc1 = new BankAccount("Chiamaka", 5000);
BankAccount acc2 = new BankAccount("Joshua", 12000);

// Method calls operate on independent instances.
acc1.Deposit(2000);
acc1.CheckBalance();
acc2.CheckBalance();

// Class: A blueprint describing an object's attributes and methods.
class BankAccount
{
    // Attributes: Information the object holds.
    public string OwnerName;
    public double Balance;

    // Constructor: Initializes the object upon creation.
    public BankAccount(string name, double openingBalance)
    {
        OwnerName = name;
        Balance = openingBalance;
    }

    // Method: An action the object can perform.
    public void Deposit(double amount)
    {
        Balance += amount;
        Console.WriteLine(OwnerName + " deposited ₦" + amount);
    }

    public void CheckBalance()
    {
        Console.WriteLine(OwnerName + "'s balance: ₦" + Balance);
    }
}