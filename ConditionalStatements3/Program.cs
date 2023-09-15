// See https://aka.ms/new-console-template for more information
Console.WriteLine("#2");
Console.WriteLine("Choose a number?");

int n = Convert.ToInt32(Console.ReadLine());

if (n % 2 ==0 || n==0)
{
    Console.WriteLine(n + " is and even integer");
}
else
{
    Console.WriteLine(n + " is an odd integer");
}