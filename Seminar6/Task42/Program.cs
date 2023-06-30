// Задача 42: Напишите программу, 
// которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.WriteLine("Введите число в 10 системе");
int numb = int.Parse(Console.ReadLine()!);
int i = 0;
string a="";
while(numb!=0)
{
    i=numb%2;
    numb/=2;
    a = i + a;
}
Console.WriteLine(a);