// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]


int[] GetRandomArray()
{
    int[] array = new int[12];

    for(int i = 0; i<array.Length;i++)
    {
        array[i] = Random.Shared.Next(-9, 10);
        Console.Write(array[i] +", ");
            array[i]=-array[i];
    }
    Console.WriteLine("\n");
    return array;
}



int[] arr = GetRandomArray();


Console.WriteLine(string.Join(", ", arr));