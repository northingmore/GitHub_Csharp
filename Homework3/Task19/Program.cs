// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число");
int numb = Convert.ToInt32(Console.ReadLine()!);
int numbResult = 0;
int numbTest=numb;
while (numb > 0) {
                numbResult *= 10;
                numbResult += numb % 10;
                numb /= 10;
            }
Console.WriteLine(numbResult);
numb=numbTest;
if (numb == numbResult)
    Console.WriteLine("палиндром");
else
    Console.WriteLine("Нет, не палиндром");

