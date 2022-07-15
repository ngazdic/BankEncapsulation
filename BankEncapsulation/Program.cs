using BankEncapsulation;




Console.WriteLine("Enter an ammount to deposit:");
var c = new BankAccount();

//var userInput = double.Parse(Console.ReadLine());

//c.Deposit(userInput);

c.Deposit(Convert.ToDouble(Console.ReadLine()));

Console.WriteLine("Your balance is:");
Console.WriteLine(c.GetBalance());


Console.WriteLine("Enter an ammount to withdraw:");

c.Withdraw(Convert.ToDouble(Console.ReadLine()));

Console.WriteLine("Your balance is:");
Console.WriteLine(c.GetBalance());
