// using System;
// using System.Collections.Generic;

//dailychale1

// class Daily_Challenge
// {
//     static void Main()
//     {
//         Console.WriteLine("Please enter a word:");
//         string word = Console.ReadLine();

//         Dictionary<char, List<int>> letterPositions = new Dictionary<char, List<int>>();

//         for (int i = 0; i < word.Length; i++)
//         {
//             char letter = word[i];

//             if (!letterPositions.ContainsKey(letter))
//             {
//                 letterPositions[letter] = new List<int>();
//             }

//             letterPositions[letter].Add(i);
//         }

//         Console.WriteLine("\nResult:");
//         foreach (var entry in letterPositions)
//         {
//             Console.Write($"'{entry.Key}': [");
//             for (int j = 0; j < entry.Value.Count; j++)
//             {
//                 Console.Write(entry.Value[j]);
//                 if (j < entry.Value.Count - 1) Console.Write(", ");
//             }
//             Console.WriteLine("]");
//         }
//     }
// }