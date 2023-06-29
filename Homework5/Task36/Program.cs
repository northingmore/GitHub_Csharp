// Задача 36: Задайте одномерный массив, 
// заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
        array[i] = Random.Shared.Next(-99, 100);
    }
    return array;
}

int SumOfElementsInOddPositions(int[] massive)
{
    int sumElementMass = 0;
    for (int i = 0; i < massive.Length; i++)
    {
        if(i%2==1)
            sumElementMass += massive[i];
    }
    return sumElementMass;
}

int[] arr = GetRandomArray();
int sumOfElementsInOddPositions = SumOfElementsInOddPositions(arr);
Console.WriteLine($"{string.Join(", ", arr)} -> {sumOfElementsInOddPositions}");

