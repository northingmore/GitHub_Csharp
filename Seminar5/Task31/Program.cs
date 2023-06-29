// Задача 31: Задайте массив из 12 элементов, 
// заполненный случайными числами из промежутака [-9,9]. 
// Найдите сумму отрицательных и положительных элементов массива.




int[] GetRandomArray()
{
    int[] array = new int[12];

    for(int i = 0; i<array.Length;i++)
    {
        array[i] = Random.Shared.Next(-9, 10);
    }
    return array;
}

int SumOfPositiveArrayElements(int[] massive)
{
    int sumOfPositiveArrayElements = 0;
    for(int i=0;i<massive.Length;i++)
    {
        if(massive[i]>0)
            sumOfPositiveArrayElements+=massive[i];
    }
    return sumOfPositiveArrayElements;
}

int SumOfNegativeArrayElements(int[] massive)
{
    int sumOfNegativeArrayElements = 0;
    for(int i=0;i<massive.Length;i++)
    {
        if(massive[i]<0)
            sumOfNegativeArrayElements+=massive[i];
    }
    return sumOfNegativeArrayElements;
}

int[] arr = GetRandomArray();
int sumOfPositive = SumOfPositiveArrayElements(arr);
int sumOfNegative = SumOfNegativeArrayElements(arr);

Console.WriteLine(string.Join(", ", arr));
Console.WriteLine($"Сумма положительных элементов равна {sumOfPositive}");
Console.WriteLine($"Сумма отрицательных элементов равна {sumOfNegative}");