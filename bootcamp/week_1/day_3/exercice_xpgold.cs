//exercicexpgold1
// using System;
// using System.Collections.Generic;
// class Exercice1_xpgold
// {

//     class Program
//     {
//         static void Main()
//         {
//             Dictionary<string, string> birthdays = new Dictionary<string, string>
//             {
//                 {"Alice", "1995/05/12"},
//                 {"Bob", "1990/08/23"},
//                 {"Charlie", "1988/12/01"},
//                 {"David", "2000/01/15"},
//                 {"Eve", "1992/06/30"}
//             };

//             Console.WriteLine("Welcome! You can look up birthdays here.");

//             Console.WriteLine("Enter a person's name:");
//             string name = Console.ReadLine();
//             if (birthdays.ContainsKey(name))
//             {
//                 Console.WriteLine(birthdays[name]);
//             }
//         }
//     }
// }

// //exercicexpgold2

// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
//         Dictionary<string, string> birthdays = new Dictionary<string, string>
//         {
//             {"Alice", "1995/05/12"},
//             {"Bob", "1990/08/23"},
//             {"Charlie", "1988/12/01"},
//             {"David", "2000/01/15"},
//             {"Eve", "1992/06/30"}
//         };

//         Console.WriteLine("Welcome! Here are the people we know:");
        
//         foreach (var personName in birthdays.Keys)
//         {
//             Console.WriteLine(personName);
//         }

//         Console.WriteLine("\nEnter a name to get their birthday:");
//         string name = Console.ReadLine();

//         if (birthdays.ContainsKey(name))
//         {
//             Console.WriteLine($"The birthday of {name} is: {birthdays[name]}");
//         }
//         else
//         {
//             Console.WriteLine($"Sorry, we don't have the birthday information for {name}");
//         }
//     }
// }

// //exercicexpgold3

// using System;

// class Program
// {
//     static void Main()
//     {
//     }

//     static int SumSequence(int x)
//     {
//         string s1 = x.ToString();           // "3"
//         string s2 = s1 + s1;                // "33"
//         string s3 = s1 + s1 + s1;           // "333"
//         string s4 = s1 + s1 + s1 + s1;      // "3333"

//         int sum = int.Parse(s1) + int.Parse(s2) + int.Parse(s3) + int.Parse(s4);

//         return sum;
//     }
// }

// //exercicexpgold4

// using System;
// using System.Collections.Generic;

// class Program
// {
//     static Random rnd = new Random();

//     static int ThrowDice()
//     {
//         return rnd.Next(1, 7);
//     }

//     static int ThrowUntilDoubles()
//     {
//         int count = 0;
//         int die1, die2;

//         do
//         {
//             die1 = ThrowDice();
//             die2 = ThrowDice();
//             count++;

//         return count;
//     }

//     static void MainSimulation()
//     {
//         List<int> results = new List<int>();

//         for (int i = 0; i < 100; i++)
//         {
//             results.Add(ThrowUntilDoubles());
//         }

//         int totalThrows = 0;
//         foreach (int r in results) totalThrows += r;

//         double average = (double)totalThrows / results.Count;

//         Console.WriteLine($"Total throws: {totalThrows}");
//         Console.WriteLine($"Average throws to reach doubles: {average:F2}");
//     }

//     static void Main()
//     {
//         MainSimulation();
//     }
// }