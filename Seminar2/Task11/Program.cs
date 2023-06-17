// Напишите программу, которая выводит случайное трехзначное число
// и удаляет вторую цифру этого числа
int numberRandom = Random.Shared.Next(100, 1000);
Console.WriteLine(numberRandom);
int firstDigit = numberRandom / 100;
int lastDigit = numberRandom % 10;
Console.WriteLine(firstDigit*10 + lastDigit);
