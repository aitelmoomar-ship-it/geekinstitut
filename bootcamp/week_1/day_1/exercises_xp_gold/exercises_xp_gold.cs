// --- Exercice1 FizzBuzz ---

Console.Write("Entrez un nombre entre 1 et 100 : ");
string input = Console.ReadLine();
if (int.TryParse(input, out int number))
{
   
    if (number % 15 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (number % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (number % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.WriteLine(number);
    }
}

// --- Exercice2 FizzBuzz ---

int height = 5;

for (int table = 1; table<= height; table++)
{
    string stars = "";
    for (int star = 1; star <= table; star++)
    {
        stars += "*";
    }
    Console.WriteLine(stars);
}