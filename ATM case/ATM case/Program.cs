Console.WriteLine("Enter UserName!");
string UserName = Console.ReadLine();
int Balance = 1000;
if (UserName == "Seymur")
{
    Console.WriteLine("Enter Password");
}
else
{
    Console.WriteLine("Incorrect Username. Please, enter available Username!");
}
string Password = Console.ReadLine();
if (Password == "seymur123")
{
    Console.WriteLine("Welcome!");
}
else
{
    Console.WriteLine("Invalid Password. Please, enter correct Password!");
}
Console.WriteLine("1. Balance");
Console.WriteLine("2. Cash in");
Console.WriteLine("3. Cash out");
Console.WriteLine("4. Quit");
string Option = Console.ReadLine();
if (Option == "1")
{
    Console.WriteLine("Current Balance:" + Balance);
    Console.ReadLine();

}
else if (Option == "2")
{
    Console.WriteLine("Please, enter the amount you want to put into your balance" + ("--Current Balance:" + Balance));
    int amount = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Current Balance:" + (Balance + amount));
    Console.ReadLine();
}
else if (Option == "3")
{
    Console.WriteLine("Please, enter the amount you want to take out from your balance" + ("--Current Balance" + Balance));
    int amount = Convert.ToInt32(Console.ReadLine());
    if (amount <= Balance)
    {
        Console.WriteLine("Current Balance:" + (Balance - amount));
        Console.ReadLine();
    }
    else
    {
        Console.WriteLine("You can not take higher amount than your balance!");
    }
}
else if (Option == "4")
{
    Console.WriteLine("Thanks for using our service.");
    Console.WriteLine("Have a nice day!");
    Console.ReadLine();
}
else
{
    Console.WriteLine("Please, choose one of available options!");
    Console.ReadLine();
}


///asdasdasdasd