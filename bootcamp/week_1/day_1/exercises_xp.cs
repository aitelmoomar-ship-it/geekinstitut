                    //Exercise 1: Goal: Understand basic output syntax.

Console.WriteLine("Exercise 1: Goal: Understand basic output syntax.");
Console.WriteLine("Welcome to C# Programming!");

                    //Exercise 2: Goal: Understand variables and string concatenation.
string name="Omar"; int age = 22;
Console.WriteLine("my name is "+name+" and I am "+age+" years old");

                    //Exercise 3:  Goal: Basic arithmetic operators.
int num1=25;
int num2=20;
int sum = num1+num2;
Console.WriteLine("the result is"+sum);

                     //Exercise 4: Goal: Conditional logic. 

int userAge = 25;
if (userAge >= 18)
{
    Console.WriteLine("Access Granted");
}
else
{
    Console.WriteLine("Access Denied");
}

                    //Exercise 5 :  Goal: Understanding loop iteration and decrementing.
int i=10;
while (i>0)
{
Console.WriteLine(i);
i--;
}
Console.WriteLine("lift off!");

                    //Exercise 6:  Goal: Defining and calling methods with parameters. 
void SayHello(string name) 
{
Console.WriteLine("Hello " + name);
}
SayHello("Omar");
SayHello("");
SayHello("Bob");

                    //Exercise 7: Goal: Combining loops and if/else logic.
for (int i=1;i<=10;i++)
if (i%2==0)
{
        Console.WriteLine("number "[i]+": is even");
}
else
    {
        Console.WriteLine("number "[i]+": is odd");
    }

                    //exercice8: Goal: User input + math
Console.Write("Please enter a temperature in Celsius: ");
string input=Console.ReadLine();
int number=int.Parse(input);
double F=(number*9/5+32);
{
Console.WriteLine("this Fahrenheit is : " +F);
}

                    //Exercise 9: Goal: Variable manipulation.
int a=10;
int b=6;
a=a+=5;
b=b-=2;
{
    Console.WriteLine("a:"+a);
    Console.WriteLine("b:"+b);
}

int a=10;
int b=6;
int swap;
{
    Console.WriteLine("Before swapping: a="+a+" and "+"b="+b);
}
swap=a;
a=b;
b=swap;
{
    Console.WriteLine("After swapping: a="+a+" and "+"b="+b);
}

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