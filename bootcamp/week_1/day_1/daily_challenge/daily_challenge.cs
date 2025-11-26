//challange 1:
using System;
using System.Text;

    Console.Write("Enter a number: ");
    string input = Console.ReadLine();
    int number = int.Parse(input);

    Console.Write("Enter a length: ");
    string input2 = Console.ReadLine();
    int length = int.Parse(input2);

    List<int> results1 = new List<int>();

    for (int i = 1; i <= length; i++)
    {
        int result = i*number;
        results1.Add(result);
    }
    {
        Console.WriteLine(string.Join(results1));
    }

//challange 2:

Console.Write("Enter a string: ");
string inputStr= Console.ReadLine();
StringBuilder resultBuilder = new StringBuilder();

char lastChar = '\0'; 

for (int i = 0; i < inputString.Length; i++)
{
    char currentChar = inputStr[i];

    if (currentChar != lastChar)
    {
        resultBuilder.Append(currentChar);

        lastChar = currentChar;
    }
}

Console.WriteLine($"Original: {inputStr}");
Console.WriteLine($"Result: {resultBuilder.ToString()}");


