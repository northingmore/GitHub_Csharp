// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, 
// второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] GetRandomArray()
{
    int[] array = new int[5];

    for(int i = 0; i<array.Length;i++)
    {
        array[i] = Random.Shared.Next(0, 10);
    }
    return array;
}

int[] arr = GetRandomArray();
int[] arr2 = new int[(GetRandomArray().Length+1)/2];

for(int i =0; i<arr2.Length;i++)
{
    arr2[i]=arr[i]*arr[arr.Length-1-i];
}
if(arr.Length%2!=0)
    arr2[arr2.Length-1] = arr[arr.Length/2];

Console.WriteLine(string.Join(", ", arr));
Console.WriteLine(string.Join(", ", arr2));