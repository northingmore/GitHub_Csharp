// Задача 39: Напишите программу, которая перевернёт одномерный массив
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]


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
    Console.WriteLine("Нажмите Enter, если хотите получить рандомный массив или если хотите инициализировать массив сами нажмите любую другую кнопку");
    ConsoleKeyInfo key = Console.ReadKey();
    if (key.Key == ConsoleKey.Escape)
    {
        int i = 0;
        double numbIElement=0;
        while (i < masive.Length)
        {
        Console.WriteLine($"\nВведите число {i+1}-того эллемента массива: ");
        numbIElement = double.Parse(Console.ReadLine()!);
        masive[i] = numbIElement;
        i++;
        }
        Console.WriteLine($"--------------------------------------------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine($"\nМассив -> [{string.Join(", ", masive)}]");
        return masive;   
    }
    else if(key.Key == ConsoleKey.Enter)
    {
        for (int i = 0; i < masive.Length; i++)
        {
            masive[i] = Random.Shared.Next(0, 100);
        }
        Console.WriteLine($"--------------------------------------------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine(string.Join(", ", masive));
        return masive;
    }
    else
    {
        Console.WriteLine($"\n--------------------------------------------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine($"Вы нажали на кнопку, которая ни за что не отвечает. \nПрограмма начата с начала");
        return InitializationArray(CreatingArray());
    }
}

void ReverseMass(double[] mas)
{
    for(int i=0; i<mas.Length/2;i++)
    {
        double tmp = mas[i];
        mas[i] = mas[mas.Length-i-1];
        mas[mas.Length-i-1] = tmp;
    }
}
double[] initializationArray = InitializationArray(CreatingArray());
ReverseMass(initializationArray);
Console.WriteLine(string.Join(", ", initializationArray));