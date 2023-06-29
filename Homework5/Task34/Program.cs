// Задача 34: Задайте массив 
// заполненный случайными положительными трёхзначными числами. 
// Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int NumberElementMass()
{
    Console.WriteLine("Введите число элементов массива");
    int numberElementMass = int.Parse(Console.ReadLine()!);
    return numberElementMass;
}

int[] GetRandomArray()
{
    int[] array = new int[NumberElementMass()];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(100, 1000);
    }
    Console.WriteLine(string.Join(", ", array));
    return array;
}

int EvenNumbersIntoAnArray(int[] masive)
{
    int count = 0;
    for (int i = 0; i < masive.Length; i++)
    {
        if (masive[i] % 2 == 0)
            count++;
    }
    return count;
}

int[] arr = GetRandomArray();
int evenNumbersIntoAnArray = EvenNumbersIntoAnArray(arr);

Console.WriteLine($"Количество чётных чисел в массиве: {EvenNumbersIntoAnArray(arr)}");

