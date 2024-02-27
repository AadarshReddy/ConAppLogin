// See https://aka.ms/new-console-template for more information
using ConAppLogin;

Console.WriteLine("Bank Login");

try
{
    string userName, password;
    Console.WriteLine("Enter UserName");
    userName = Console.ReadLine();
    Console.WriteLine("Enter PAssword");
    password = Console.ReadLine();
    Authentication auth = new Authentication();
    Console.WriteLine(auth.Login(userName,password));
}
catch(Exception ex)
{ Console.WriteLine("Error!!!!"+ex.Message); }
