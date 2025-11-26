//challange 1:

Console.Write("Enter a number: ");
    string input = Console.ReadLine();
    int number = int.Parse(input);

    Console.Write("Enter a length: ");
    string input2 = Console.ReadLine();
    int length = int.Parse(input2);

    list<int> results1 = new list<int>();

    for (int i = 1; i <= length; i++)
    {
        int result = i*number;
        results1.Add(result);
    }
    {
        Console.WriteLine(string.join(", ", results1));
    }
//challange 2:

Console.WriteLine("enter a string:");
string nom= Console.ReadLine();
Console.WriteLine(nom);
for (int i=0; i<nom.Length; i++)
{
    int j=i+1;
    if (i == j)
    {
        Console.WriteLine(nom[i]);
    }

}