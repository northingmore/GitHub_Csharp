// Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого.

// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.WriteLine("Введите первое чило:");
int numberInt = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine("Введите второе число:");
int numberInt2 = Convert.ToInt32(Console.ReadLine()!);
if(numberInt*numberInt==numberInt2 || numberInt2*numberInt2==numberInt){
    Console.WriteLine("Является ли первое число квадратом второго?" + "\nДа");
}
else{
    Console.WriteLine("Является ли первое число квадратом второго?" + "\nНет");
}