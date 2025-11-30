// exerice 1:
// class exericexp
// {
//     static void Main()
//     {
//         List<string> keys = new List<string> { "Ten", "Twenty", "Thirty" };
//         List<int> values = new List<int> { 10, 20, 30 };
//         Dictionary<string, int> myDict = new Dictionary<string, int>();

//         for (int i = 0; i < keys.Count; i++)
//         {
//             myDict[keys[i]] = values[i];
//         }

//         foreach (var kvp in myDict) // 
//         {
//             Console.WriteLine(kvp.Key + ": " + kvp.Value);
//         }
//     }
// }
// //exerice 2:
// // class exericexp2
// // {
// //     static void Main()
// //     {
// //         Dictionary<string, int> family = new Dictionary<string, int>
// //         {
// //             {"rick", 43}, {"beth", 13}, {"morty", 5}, {"summer", 8}
// //         };

// //         int totalCost = 0;

// //             foreach (var member in family)
// //         {
// //             int age = member.Value;
// //             int price = 0;

// //             if (age < 3) 
// //             {
// //                 price = 0;
// //             }
// //             else if (age >= 3 && age <= 12)
// //             {
// //                 price = 10;
// //             }
// //             else if (age > 12)
// //             {
// //                 price = 15;
// //             }

// //             Console.WriteLine($"{member.Key} has to pay: ${price}");
// //             totalCost += price;
// //         }

// //         Console.WriteLine($"Total cost for the family: ${totalCost}");
// //     }
// // }

// //exericexp 3:

// // class exericexp3
// // {
// //     static void Main()
// //     {
// //         var brand = new Dictionary<string, object>
// //         {
// //             {"name", "Zara"},
// //             {"creation_date", 1975},
// //             {"creator_name", "Amancio Ortega Gaona"},
// //             {"type_of_clothes", new List<string>{"men", "women", "children", "home"}},
// //             {"international_competitors", new List<string>{"Gap", "H&M", "Benetton"}},
// //             {"number_stores", 7000},
// //             {"major_color", new Dictionary<string, List<string>>
// //                 {
// //                     {"France", new List<string>{"blue"}},
// //                     {"Spain", new List<string>{"red"}},
// //                     {"US", new List<string>{"pink", "green"}}
// //                 }
// //             }
// //         };

// //         brand["number_stores"] = 2;

// //         List<string> clothes = (List<string>)brand["type_of_clothes"];
// //         Console.WriteLine("Zara clients are men, women, children and home lovers.");

// //         brand["country_creation"] = "Spain";

// //         if (brand.ContainsKey("international_competitors"))
// //         {
// //             List<string> competitors = (List<string>)brand["international_competitors"];
// //             competitors.Add("Desigual");
// //         }

// //         brand.Remove("creation_date");

// //         List<string> comps = (List<string>)brand["international_competitors"];
// //         Console.WriteLine(comps[comps.Count - 1]);

// //         Dictionary<string, List<string>> colors = (Dictionary<string, List<string>>)brand["major_color"];
// //         foreach(var color in colors["US"])
// //         {
// //             Console.WriteLine(color);
// //         }

// //         Console.WriteLine(brand.Count);

// //         foreach (var key in brand.Keys)
// //         {
// //             Console.WriteLine(key);
// //         }

// //         var more_on_zara = new Dictionary<string, object>
// //         {
// //             {"creation_date", 1975},
// //             {"number_stores", 10000}
// //         };

// //         foreach (var kvp in more_on_zara)
// //         {
// //             brand[kvp.Key] = kvp.Value;
// //         }

// //         Console.WriteLine(brand["number_stores"]);     
// //         }
// // }

// //exericexp 4:

// // class exericexp4
// // {
// //     static void Main()
// //     {
// //        void DescribeCity(string city, string country = "Iceland")
// //         {
// //             Console.WriteLine($"{city} is in {country}.");
// //         }
// //         {
// //             DescribeCity("akureyri");
// //             DescribeCity("Paris", "France"); 
// //         }
// //     }
// // }

// //exericexp 5:
// // class exericexp5
// // {
// //     static void Main()
// //     {
// //        static void GuessNumber(int userNumber)
// //         {
// //             Random rnd = new Random();
// //             int generatedNumber = rnd.Next(1, 101);

// //             if (userNumber == generatedNumber)
// //             {
// //                 Console.WriteLine("Success! The numbers match.");
// //             }
// //             else
// //             {
// //                 Console.WriteLine($"Fail. Your number: {userNumber}, Generated: {generatedNumber}");
// //             }
// //         }

// //         GuessNumber(42);
// //         GuessNumber(50);

// //     }
// // }

// //exericexp 6:

// // class exericexp6
// // {
// //     static void Main()
// //     {
// //         static void MakeShirt(string size = "Large", string text = "I love C#")
// //         {
// //             Console.WriteLine($"The size of the shirt is {size} and the text is \"{text}\"");
// //         }

// //         static void Main()
// //         {
// //             MakeShirt(); 

// //             MakeShirt("Medium");

// //             MakeShirt("Small", "Hello World");

// //             MakeShirt(text: "Coding is fun", size: "Extra Large");
// //         }
// //         MakeShirt(size: "Medium", text: "Hello C#");
// //         MakeShirt(size: "Small", text: "I love programming");
// //         MakeShirt(text: "Coding is fun", size: "Extra Large");
// //     }
// // }

// //exericexp 7:

// // class exericexp7
// // {
// //         static double GetRandomTemp(string season)
// //         {
// //                 Random rnd = new Random();
// //                 double min = -10, max = 40;

// //                 if (season == "winter") { min = -10; max = 16; }
// //                 else if (season == "spring") { min = 0; max = 23; }
// //                 else if (season == "summer") { min = 16; max = 40; }
// //                 else if (season == "autumn") { min = 0; max = 23; }

// //                 return rnd.Next((int)min, (int)max + 1) + rnd.NextDouble();
// //         }
// //         static string DetermineSeason(int month)
// //         {
// //             if (month >= 12 || month <= 2)
// //                 return "winter";
// //             else if (month >= 3 && month <= 5)
// //                 return "spring";
// //             else if (month >= 6 && month <= 8)
// //                 return "summer";
// //             else if (month >= 9 && month <= 11)
// //                 return "autumn";
// //             else
// //                 return "unknown";
// //         }
// //             static void Main()
// //             {
// //                 Console.WriteLine("Enter a month number (1-12):");
// //                 int month = int.Parse(Console.ReadLine());
// //                 string season = DetermineSeason(month);
// //                 double temp = GetRandomTemp(season);
// //                 Console.WriteLine($"The temperature is: {temp:F2}°C");

// //                 if (temp < 0)
// //                     Console.WriteLine("Brrr, that's freezing! Wear some extra layers.");
// //                 else if (temp >= 0 && temp <= 16)
// //                     Console.WriteLine("Quite chilly! Don't forget your coat.");
// //                 else if (temp > 16 && temp <= 23)
// //                     Console.WriteLine("It's a nice day, maybe a light jacket.");
// //                 else if (temp > 23 && temp < 32)
// //                     Console.WriteLine("It's warm! Enjoy the weather.");
// //                 else
// //                     Console.WriteLine("It's boiling hot! Stay hydrated.");
                
// //             }
// // }

// //exericexp 8:
// // class exericexp8
// // {
// //     static void Main()
// //     {
// //         var data = new List<Dictionary<string, string>>
// //         {
// //             new Dictionary<string, string> { {"question", "What is Baby Yoda's real name?"}, {"answer", "Grogu"} },
// //             new Dictionary<string, string> { {"question", "Where did Obi-Wan take Luke after his birth?"}, {"answer", "Tatooine"} },
// //             new Dictionary<string, string> { {"question", "What year did the first Star Wars movie come out?"}, {"answer", "1977"} },
// //             new Dictionary<string, string> { {"question", "Who built C-3PO?"}, {"answer", "Anakin Skywalker"} },
// //             new Dictionary<string, string> { {"question", "Anakin Skywalker grew up to be who?"}, {"answer", "Darth Vader"} },
// //             new Dictionary<string, string> { {"question", "What species is Chewbacca?"}, {"answer", "Wookiee"} }
// //         };

// //         int correctCount = 0;
// //         int wrongCount = 0;
// //         List<string> wrongQuestions = new List<string>();

// //         foreach (var item in data)
// //         {
// //             Console.WriteLine(item["question"]);
// //             string userAnswer = Console.ReadLine();

// //             if (userAnswer.ToLower() == item["answer"].ToLower())
// //             {
// //                 Console.WriteLine("Correct!");
// //                 correctCount++;
// //             }
// //             else
// //             {
// //                 Console.WriteLine("Wrong.");
// //                 wrongCount++;
// //                 wrongQuestions.Add(item["question"]);
// //             }
// //         }

// //         Console.WriteLine($"\nResults: Correct: {correctCount}, Wrong: {wrongCount}");
// //     }
// // }

// //exericexp 9:
// class exercicexp9
// {
//     static void Main()
//     {
//         List<Cat> cats = new List<Cat>();

//         Console.WriteLine("Enter details for 3 cats:");

//         for (int i = 0; i < 3; i++)
//         {
//             Console.Write($"Enter name of cat {i + 1}: ");
//             string name = Console.ReadLine();

//             Console.Write($"Enter age of cat {i + 1}: ");
//             int age = int.Parse(Console.ReadLine());

//             cats.Add(new Cat(name, age));
//         }

//         Cat oldestCat = FindOldestCat(cats);

//         Console.WriteLine($"The oldest cat is {oldestCat.Name}, and is {oldestCat.Age} years old.");
//     }
//     class Cat
//     {
//         public string Name;
//         public int Age;
//         public Cat(string catName, int catAge)
//         {
//             this.Name = catName;
//             this.Age = catAge;
//         }
//     }
//         static Cat FindOldestCat(List<Cat> cats)
//         {
//             Cat oldest = cats[0];
//             foreach (var cat in cats)
//             {
//                 if (cat.Age > oldest.Age)
//                 {
//                     oldest = cat;
//                 }
//             }
//             return oldest;
//         }

//         static void Main()
//         {
//             Cat cat1 = new Cat("Tom", 5);
//             Cat cat2 = new Cat("Garfield", 8);
//             Cat cat3 = new Cat("Luna", 3);

//             List<Cat> allCats = new List<Cat> { cat1, cat2, cat3 };

//             Cat oldest = FindOldestCat(allCats);

//             Console.WriteLine($"The oldest cat is {oldest.Name}, and is {oldest.Age} years old.");
//         }
// }

// //exericexp 10:
// class Dog
// {
//         public string Name;
//         public int Height;

//         public Dog(string name, int height)
//         {
//             this.Name = name;
//             this.Height = height;
//         }

//         public void Bark()
//         {
//             Console.WriteLine($"{this.Name} goes woof!");
//         }

//         public void Jump()
//         {
//             int jumpHeight = this.Height * 2;
//             Console.WriteLine($"{this.Name} jumps {jumpHeight} cm high!");
//         }
// }

// class Program
// {
//     static void Main()
//     {
//         Dog davidsDog = new Dog("Rex", 50);
//         Console.WriteLine($"Dog: {davidsDog.Name},Height: {davidsDog.Height}");
//         davidsDog.Bark();
//         davidsDog.Jump();

//         Dog sarahsDog = new Dog("Teacup", 20);
//         Console.WriteLine($"Dog: {sarahsDog.Name}, Height: {sarahsDog.Height}");
//         sarahsDog.Bark();
//         sarahsDog.Jump();

//         if (davidsDog.Height > sarahsDog.Height)
//         {
//             Console.WriteLine($"{davidsDog.Name} is taller.");
//         }
//         else
//         {
//             Console.WriteLine($"{sarahsDog.Name} is taller.");
//         }
//     }
// }

// //exericexp 11:

// using System.Collections.Generic;
// class Exercice11_xp
// {

//     class Song
//     {
//         public List<string> Lyrics;

//         public Song(List<string> lyrics)
//         {
//             this.Lyrics = lyrics;
//         }

//         public void SingMeASong()
//         {
//             foreach (string line in this.Lyrics)
//             {
//                 Console.WriteLine(line);
//             }
//         }
//     }

//     class Program
//     {
//         static void Main()
//         {
//             var stairway = new Song(new List<string>{
//                 "There's a lady who's sure",
//                 "all that glitters is gold",
//                 "and she's buying a stairway to heaven"
//             });

//             stairway.SingMeASong();
//         }
//     }
// }
// //exericexp 12:

using System;
using System.Collections.Generic;
class Zoo
{
    public List<string> animals;
    public string name;

    public Zoo(string zooName)
    {
        this.name = zooName;
    }

    public void AddAnimal(string newAnimal)
    {
        if (!animals.Contains(newAnimal))
        {
            animals.Add(newAnimal);
            Console.WriteLine($"{newAnimal} added.");
        }
    }

    public void GetAnimals()
    {
        Console.WriteLine("Animals in zoo:");
        foreach (var animal in animals)
        {
            Console.Write(animal + " ");
        }
        Console.WriteLine();
    }

    public void SellAnimal(string animalSold)
    {
        if (animals.Contains(animalSold))
        {
            animals.Remove(animalSold);
        }
    }

    public void SortAnimals()
    {

        Console.WriteLine("Animals sorted and grouped.");
    }

    public void GetGroups()
    {
        Dictionary<char, List<string>> groups = new Dictionary<char, List<string>>();

        foreach (var animal in animals)
        {
            char firstLetter = animal[0];

            [cite_start]if (!groups.ContainsKey(firstLetter)) // (Page 4) Check if Key Exists [cite: 1004]
            {
                groups[firstLetter] = new List<string>();
            }
            groups[firstLetter].Add(animal);
        }

        foreach (var group in groups)
        {
            Console.Write($"{group.Key}: ");

            foreach(var a in group.Value)
            {
                Console.Write(a + ", ");
            }
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main()
    {
        Zoo newYorkZoo = new Zoo("New York Zoo");
        
        newYorkZoo.AddAnimal("Giraffe");
        newYorkZoo.AddAnimal("Bear");
        newYorkZoo.AddAnimal("Ape");
        newYorkZoo.AddAnimal("Cat");
        newYorkZoo.AddAnimal("Baboon");

        newYorkZoo.GetAnimals();

        newYorkZoo.SortAnimals();
        
        Console.WriteLine("--- Groups ---");
        newYorkZoo.GetGroups();
        
        newYorkZoo.SellAnimal("Bear");
        newYorkZoo.GetAnimals();
    }
}