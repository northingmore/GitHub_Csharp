// Задача 62. Напишите программу, 
// которая заполнит спирально массив 4 на 4.
//  Например, на выходе получается вот такой массив:
//  01 02 03 04
//  12 13 14 05
//  11 16 15 06
//  10 09 08 07


int[,] CreationMasive()
{
    int ROWS = 4;
    int COLUMN = 4;
    int[,] two_DimensionalArray = new int[ROWS, COLUMN];
    return two_DimensionalArray;
}

int[,] InitionalisationMasive(int[,] masive)
{
    int n = 4;
    int i = 0, j = 0;
    int value = 1;
    for (int e = 0; e < n * n; e++)
    {
        int k = 0;
        do { masive[i, j++] = value++; } while (++k < n - 1);
        for (k = 0; k < n - 1; k++) 
            masive[i++, j] = value++;
        for (k = 0; k < n - 1; k++) 
            masive[i, j--] = value++;
        for (k = 0; k < n - 1; k++) 
            masive[i--, j] = value++;
        ++i; ++j;
        n = n < 2 ? 0 : n - 2;
    }
    
    return masive;
}

void MasivePrint(int[,] mas)
{
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            if (mas[i, j] < 10)
            {
                Console.Write("0" + mas[i, j]);
                Console.Write(" ");
            }
            else Console.Write(mas[i, j] + " ");
        }
        Console.WriteLine();
    }
}

MasivePrint(InitionalisationMasive(CreationMasive()));