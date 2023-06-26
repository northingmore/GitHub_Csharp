// Задача 27: Напишите программу, 
// которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int readNumb()
{
    Console.WriteLine("Введите число");
    return Convert.ToInt32(Console.ReadLine()!);
}

int outNumb(int numb)
{
    int result = 0;
    while(numb>0)
    {
        result+=numb%10;
        numb= numb/10;
    }
    return result;
}

int numb = readNumb();
Console.WriteLine(outNumb(numb));