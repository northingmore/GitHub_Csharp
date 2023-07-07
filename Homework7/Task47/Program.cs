// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

int NumberElementMass()
{
    Console.WriteLine("Введите число элементов массива");
    int numberElementMass = int.Parse(Console.ReadLine()!);
    return numberElementMass;
}

double[,] MassInitionalisation()
{
    int ROWS = NumberElementMass();
    int COLUMN = NumberElementMass();
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

void MasPrint(double[,] mas)
{
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            Console.Write($"{mas[i, j]:f2}\t");
        }
        Console.WriteLine();
    }
}

MasPrint(MassInitionalisation());
