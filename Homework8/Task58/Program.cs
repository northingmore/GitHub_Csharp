// Задача 58: Задайте две матрицы. 
// Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 6 16
// 9 6
 
 
int ROWS = ReadInt("Введите количество строк: ");
int COLUMN = ReadInt("Введите количество столбцов: ");
int[,] array = new int[ROWS, COLUMN];
int[,] secondArray = new int[ROWS, COLUMN];
int[,] resultArray = new int[ROWS, COLUMN];

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
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

MasivePrint(InitionalisationMasive(array));
MasivePrint(InitionalisationMasive(secondArray));
if (array.GetLength(0) != secondArray.GetLength(1))
{
    Console.WriteLine(" Нельзя перемножить ");
    return;
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < secondArray.GetLength(1); j++)
    {
        resultArray[i, j] = 0;
        for (int k = 0; k < array.GetLength(1); k++)
        {
            resultArray[i, j] += array[i, k] * secondArray[k, j];
        }
    }
}

MasivePrint(resultArray);


