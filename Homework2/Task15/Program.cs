// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Напишите номер дня недели");
int numberDay = Convert.ToInt32(Console.ReadLine()!);

if (numberDay >= 1&&numberDay<6){
    Console.WriteLine("Эх, рабочий день");
}
else if(numberDay >= 6&&numberDay<8)
    Console.WriteLine("Выходной, ура");

else{
    Console.WriteLine("Под таким номером нету дня недели");
}