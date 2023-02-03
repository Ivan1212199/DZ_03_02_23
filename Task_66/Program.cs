/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
*/


Console.WriteLine("Введите начальное число M:");
int numberM = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите начальное число N:");
int numberN = int.Parse(Console.ReadLine()!);

void GapNumSum (int numberM, int numberN, int sum)
{
    if (numberM > numberN) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (numberM++);
    GapNumSum(numberM, numberN, sum);
}

GapNumSum(numberM, numberN, 0);