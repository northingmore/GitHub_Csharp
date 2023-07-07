// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)



double[] CreatingArray()
{
    double[] array = new double[4];
    return array;
}

double[] InitializationArray(double[] masive)
{
    int i = 0;
    double numbIElement=0;
    while (i < masive.Length)
    {
        Console.WriteLine($"Введите число {i+1}-того эллемента массива: ");
        numbIElement = double.Parse(Console.ReadLine()!);
        masive[i] = numbIElement;
        i++;
    }
    Console.WriteLine($"\nМассив -> [{string.Join(", ", masive)}]");
    return masive;
}

double[] Validation(double[] masive)
{
    int i = 0;
    while (i < masive.Length)
    {
        double b1 = 0;
        double k1 = 0;
        double b2 = 0;
        double k2 = 0;
        if(i==1)
            b1 = masive[i];
        else if(i==2)
            k1 = masive[i];
        else if(i==3)
            b2 = masive[i];
        else if(i==4)
            k2=masive[i];
        i++;
    }
    return masive;
}

void PointOfIntersection(double[] masive)
{
        double x = (masive[2] - masive[0]) / (masive[1] - masive[3]);
        double y= masive[1] * x + masive[0];
        Console.WriteLine("x = " + x + "y = " + y);
}

double[] initializationArray = Validation(InitializationArray(CreatingArray()));
PointOfIntersection(initializationArray);