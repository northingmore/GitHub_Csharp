// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если число 2 не кратно числу 1, 
// то программа выводит остаток от деления.

Console.WriteLine("Введите первое число");
int numberOne =  Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine("Введите второе число");
int numberTwo =  Convert.ToInt32(Console.ReadLine()!);
// string number = numberOne % numberTwo == 0 ? "Yes" :  "No, остаток от деления: " + numberOne % numberTwo;
Console.WriteLine(
    "является ли второе число кратным первому? " 
    + (numberOne % numberTwo == 0 ? "Yes" :  "No, остаток от деления: " + numberOne % numberTwo)
    );

