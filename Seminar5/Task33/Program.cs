// Задача 33: Задайте массив. Напишите программу, 
// которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> нет


int[] GetRandomArray()
{
    int[] array = new int[5];

    for(int i = 0; i<array.Length;i++)
    {
        array[i] = Random.Shared.Next(-9, 10);
    }
    return array;
}



int[] arr = GetRandomArray();
Console.WriteLine("Введи число");
int numberFind = int.Parse(Console.ReadLine()!);
int count = 0;


  for(int i=0; i<arr.Length;i++)
    {
    int n = arr[i];
        if(n==numberFind)
        {
            count++;
            break;
        }
    }

if(count==1)
    Console.WriteLine("Да");
else
{
    Console.WriteLine("Нет");
}
