// Задача 29: Напишите программу, 
// которая задаёт массив из 8 элементов и выводит их на экран.


int readNumb()
{
    Console.WriteLine("Задайте кол-во элементов массива");
    int result = Convert.ToInt32(Console.ReadLine()!);
    return result;
}

int[] arr = new int[readNumb()];
Random random = new Random();
for (int i = 0; i<arr.Length;i++)
{
    arr[i] = random.Next(1,1000);
}


Console.Write("[");
for(int j=0; j<arr.Length-1;j++)
Console.Write($"{arr[j]}, ");
Console.Write(arr[arr.Length-1]);
Console.WriteLine("]");

