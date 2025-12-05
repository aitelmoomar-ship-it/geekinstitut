// // Exercice1 FizzBuzz 

// Console.Write("Entrez un nombre entre 1 et 100 : ");
// string input = Console.ReadLine();
// if (int.TryParse(input, out int number))
// {
   
//     if (number % 5== 0 && number % 3 == 0)
//     {
//         Console.WriteLine("FizzBuzz");
//     }
//     else if (number % 3 == 0)
//     {
//         Console.WriteLine("Fizz");
//     }
//     else if (number % 5 == 0)
//     {
//         Console.WriteLine("Buzz");
//     }
//     else
//     {
//         Console.WriteLine(number);
//     }
// }

// // Exercice2 FizzBuzz

// int height = 5;

// for (int i = 1; i <= height; i++)
// {
//     for (int j = 0; j < i; j++)
//     {
//         Console.Write("*");
//     }
//         Console.WriteLine();
// }
// Exercice3 FizzBuzz

// Console.Write("Enter a word to reverse: ");
// string original = Console.ReadLine();
// string reversed = "";

// for (int i = original.Length -1; i >= 0; i--)
// {
//     reversed = reversed + original[i];
// }

// Console.WriteLine($"Original: {original}");
// Console.WriteLine($"Reversed: {reversed}");