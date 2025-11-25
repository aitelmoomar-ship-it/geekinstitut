                    //Exercise 10:Goal: Loops + user input.
Console.Write("Enter a number to multiply: ");
string input = Console.ReadLine();
int number = int.Parse(input);
Console.WriteLine("Here is the table for " + number + ":");

for (int i = 1; i <= 10; i++)
{
    int result = number * i;

    Console.WriteLine(number + " x " + i + " = " + result);
}