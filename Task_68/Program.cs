/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
*/


Console.WriteLine("Введите начальное число M:");
int numberM = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите начальное число N:");
int numberN = int.Parse(Console.ReadLine()!);

int AckFun (int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    if (numberM != 0 && numberN == 0) return AckFun(numberM - 1, 1);
    if (numberM > 0 && numberN > 0) return AckFun(numberM - 1, AckFun(numberM, numberN - 1));
return AckFun(numberM, numberN);
}

Console.WriteLine($"Функция Аккермана для чисел A({numberM},{numberN}) = {AckFun(numberM, numberN)}");