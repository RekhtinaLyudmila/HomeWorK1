// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Enter namber 1 : ");
int EnterNumber1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter namber 2 : ");
int EnterNumber2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter namber 3 : ");
int EnterNumber3 = Convert.ToInt32(Console.ReadLine());

int max = EnterNumber1;

if(EnterNumber2 > max)max = EnterNumber2;
{
if(EnterNumber3 > max)max = EnterNumber3;
}
Console.WriteLine(max);