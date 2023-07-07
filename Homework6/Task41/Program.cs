// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

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


double[] initializationArray = InitializationArray(CreatingArray());
//double theNumberOfNumbersGreaterThan_0_EnteredByTheUser = TheNumberOfNumb(initializationArray);
double count = 0;

    for(int i = 0; i < initializationArray.Length;i++)
    {
        if(0<initializationArray[i])
        {
            count++;
        }
    }
    Console.WriteLine(count);