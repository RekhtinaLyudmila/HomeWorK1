// Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.


Console.WriteLine("Enter namber 1 : ");
int EnterNumber1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter namber 2 : ");
int EnterNumber2 = Convert.ToInt32(Console.ReadLine());

if(EnterNumber1 > EnterNumber2)
{
Console.WriteLine(EnterNumber1);
}
else 
{
Console.WriteLine(EnterNumber2);
}
