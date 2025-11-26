// --- Exercice1 FizzBuzz ---

Console.Write("Entrez un nombre entre 1 et 100 : ");
string input = Console.ReadLine();
if (int.TryParse(input, out int number))
{
   
    if (number % 5== 0 && number % 3 == 0)
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
