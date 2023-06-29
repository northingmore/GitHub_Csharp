// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

int NumberElementMass()
{
    Console.WriteLine("Введите число элементов массива");
    int numberElementMass = int.Parse(Console.ReadLine()!);
    return numberElementMass;
}

double[] CreatingArray()
{
    double[] array = new double[NumberElementMass()];
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

double MaxElementMass(double[] mas)
{
    double maxElMass = 0;
    for(int i=1;i<mas.Length;i++)
    {
        if(mas[i-1]>mas[i])
            maxElMass=mas[i-1];
        else
            maxElMass=mas[i];
    }
    Console.WriteLine($"\nМаксимальный элемент массива: {maxElMass}");
    return maxElMass;
}

double MinElementMass(double[] mas)
{
    double minElMass = mas[0];
    for(int i=1;i<mas.Length;i++)
    {
        if(mas[i] < minElMass)
            minElMass = mas[i];
    }
    Console.WriteLine($"\nМинимальный элемент массива: {minElMass}");
    return minElMass;
}

double DifferenceBetweenElements(double maxElMass, double minElMass)
{
    double diffBetweenElements = maxElMass - minElMass;
    return diffBetweenElements;
}

double[] initializationArray = InitializationArray(CreatingArray());
double differenceBetweenElements = DifferenceBetweenElements(MaxElementMass(initializationArray), MinElementMass(initializationArray));

Console.WriteLine($"\nРазницу между максимальным и минимальным элементов массива: {differenceBetweenElements}");