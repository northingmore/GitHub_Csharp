// Задача 13: Напишите программу, 
// которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

// Решение 1
/*Console.WriteLine("Введите трехзначное число");
string numbString = Console.ReadLine()!;
int z=0;

for(int i = 0; i < numbString.Length; i++){
    z++;}

if(z>=3){
    int digetIndex = 2;
    int digit = numbString[digetIndex]-'0';
    int numb = Convert.ToInt32(digit);
    Console.WriteLine(numb);}
else
     Console.WriteLine("третьей цифры нет");*/


// Решение 2
Console.WriteLine("Введите трехзначное число");
int numb = Convert.ToInt32(Console.ReadLine()!);
while (numb>999)
{
    numb /= 10;
}
Console.WriteLine( numb<100?// проверяем является ли число меньше 100
"третьей цифры нет":numb%10);//если да, то пишем "третьей цифры нет", если нет, то находим 3 элемент



    
