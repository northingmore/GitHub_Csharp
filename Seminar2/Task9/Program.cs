// Напишите программу,
// которая выводит случайное число из отрезка[10, 99]
// и показывает наибольшую цифру числа.

// 78->8
// 12->2
// 85->8

int numbersRandom = Random.Shared.Next(10, 100);
Console.Write(numbersRandom);
int lastDigit = numbersRandom % 10;
int firstDigit = numbersRandom / 10;
int digitMax = lastDigit > firstDigit ? lastDigit : firstDigit;
Console.WriteLine("\nНаибольшая цифра числа: " + numbersRandom + " равна " + digitMax);
