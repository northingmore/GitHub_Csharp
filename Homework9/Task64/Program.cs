 //Задача 64: Задайте значения N. Напишите программу, 
 //которая выведет все натуральные числа в промежутке от N до 1.
 //N = 5. -> "5, 4, 3, 2, 1"
 //N = 8. -> "8, 7, 6, 5, 4, 3, 2, 1"
 
 
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int count = 1;
NaturalNumber(number, count);


void NaturalNumber(int n, int count)
{
    if (count > n)
        return;
    else
    {
        NaturalNumber(n, count + 1);
        Console.Write(count + " ");
    }
}

 
