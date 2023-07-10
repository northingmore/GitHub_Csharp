// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int SizeMasive()
{
    Console.WriteLine("Введи размер масива(строка и столбец): ");
    return int.Parse(Console.ReadLine()!);
}

int[,] CreationMasive()
{
    int ROWS = SizeMasive();
    int COLUMN = SizeMasive();
    int[,] two_DimensionalArray = new int[ROWS, COLUMN];
    return two_DimensionalArray;
}

int[,] InitionalisationMasive(int[,] masive)
{
    
    Console.WriteLine("Нажмите ENTER, если хотите получить рандомный массив или если хотите инициализировать массив сами, нажмите ESC");
    ConsoleKeyInfo key = Console.ReadKey();
    if (key.Key == ConsoleKey.Escape)
    {
        for (int i = 0; i < masive.GetLength(0); i++)
        {
            for (int j = 0; j < masive.GetLength(1); j++)
            {
                int numbI_JElement = 0;
                Console.WriteLine($"Введите число {i + 1}-того эллемента массива: ");
                numbI_JElement = int.Parse(Console.ReadLine()!);
                masive[i, j] = numbI_JElement;
            }
        }
    }
    else
    {
        for (int i = 0; i < masive.GetLength(0); i++)
        {
            for (int j = 0; j < masive.GetLength(1); j++)
            {
                masive[i,j] = Random.Shared.Next(0,10);
            }
        }
    }
    return masive;
}

void MasivePrint(int[,] mas)
{
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            Console.Write($"{mas[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] ArrayElementsInDescendingRow()
{
    int[,] masive = InitionalisationMasive(CreationMasive());
    MasivePrint(masive);
    Console.WriteLine("--------------------------------------------------------------------------------");
    for (int i = 0; i < masive.GetLength(0); i++)
    {
        for (int j = 0; j < masive.GetLength(1); j++)
        {
            for (int k = 0; k < masive.GetLength(1) - 1; k++)
            {
                if (masive[i, k] < masive[i, k + 1])
                {
                    int tmp = masive[i, k + 1];
                    masive[i, k + 1] = masive[i, k];
                    masive[i, k] = tmp;
                }
            }
        }
    }
    return masive;
}

MasivePrint(ArrayElementsInDescendingRow());

