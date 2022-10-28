//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
int a = 5;
int b = 7;
int max = a;

if (a > max) max = a;
if (b > max) max = b;


Console.Write("max = ");
Console.WriteLine($"{max}");
*/


/*
Console.Write("input a first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int b = Convert.ToInt32(Console.ReadLine());
int max = a;

if (a > b) 
{
Console.WriteLine($"{a}"); 
}
else 
{
Console.WriteLine($"{b}"); 
}
*/

//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.Write("input a first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("input a third number: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;

if (a > b)
if (a > c)
{
    Console.WriteLine($"{a}"); 
}
if (b > a)
if (b > c) 
{
    Console.WriteLine($"{b}");
}
else 
{
    Console.WriteLine($"{c}"); 
}
*/

//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.Write("input a number: ");
int a = Convert.ToInt32(Console.ReadLine());

int div = a % 2;

if (a % 2 == 1)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
*/


//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
Console.Write("input a positive integer number: ");
int N = Convert.ToInt32(Console.ReadLine());

int b = 2;

while(b <= N)
{
    Console.Write(b + " ");
    b += 2;
}
*/




