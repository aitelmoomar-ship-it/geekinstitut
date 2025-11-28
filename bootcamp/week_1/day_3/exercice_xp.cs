//exercicees 1 :
List<string> keys = new List<string> { "Ten", "Twenty", "Thirty" };
List<int> values = new List<int> { 10, 20, 30 };
// 1. Create the empty Dictionary
Dictionary<string, int> myDict = new Dictionary<string, int>();

// 2. Loop through the lists and add items
for (int i = 0; i < keys.Count; i++)
{
    myDict.Add(keys[i], values[i]);
}