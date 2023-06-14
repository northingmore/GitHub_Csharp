// Напишите программу, которая принимает два числа и проверяет, является ли первое число квадратом второго

Console.WriteLine("Введите первое чило:");
int numberInt = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine("Введите второе число:");
int numberInt2 = Convert.ToInt32(Console.ReadLine()!);
if(numberInt*numberInt==numberInt2){
    Console.WriteLine("Является ли первое число квадратом второго?" + "\nДа");
}
else{
    Console.WriteLine("Является ли первое число квадратом второго?" + "\nНет");
}