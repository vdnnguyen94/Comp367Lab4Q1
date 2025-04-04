// See https://aka.ms/new-console-template for more information
using StringUtilities;


Console.WriteLine("Enter a string:");
string? input = Console.ReadLine();


bool isUpper = input.StartsWithUpper();

Console.WriteLine(isUpper
    ? "YES Starts with an uppercase letter!"
    : "NO  Does not start with an uppercase letter.");
