// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет
// 1, 2 -> 2


double[,] MassInitionalisation()
{
    Console.WriteLine("Введите число строки массива");
    int ROWS = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите число колонки массива");
    int COLUMN = int.Parse(Console.ReadLine()!);
    double[,] matrix = new double[ROWS,COLUMN];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = Random.Shared.NextDouble()*Random.Shared.Next(0,1000);
        } 
    }
    return matrix;
}

double[,] MasPrint(double[,] mas)
{
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            Console.Write($"{mas[i, j]:f2}\t");
        }
        Console.WriteLine();
    }
    return mas;
}

void SearchMasEl(double[,] mas)
{
    Console.WriteLine("Номер строки число которого хотите получить");
    int numberElementMassI = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Номер колонки которой хотите получить");
    int numberElementMassJ = int.Parse(Console.ReadLine()!);
    int count = 0;
     for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            if(numberElementMassI<=i+1&&numberElementMassJ<=j+1)
                count++;
        }
    }
    if (numberElementMassI<1 || numberElementMassJ<1)
        Console.Write("Позиции строк не могут быть отрицательными");
    else if (count>0)
        Console.Write($"Значение элемента равно {mas[numberElementMassI-1,numberElementMassJ-1]:F2} ");
    else 
        Console.Write("Такого элемента нет в массиве");

}



SearchMasEl(MasPrint(MassInitionalisation()));



