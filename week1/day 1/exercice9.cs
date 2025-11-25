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