// Напишите функцию, которая принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B. НЕ ИСПОЛЬЗОВАТЬ MATH.POW()
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int readNumb()
{
    Console.WriteLine("Введите число: ");
    return Convert.ToInt32(Console.ReadLine()!);
}

int Pow(int numbA, int numbB)
{
    int i = 1;
    int numb = 1;
    while(i<=numbB)
    {
        numb*=numbA;
        i++;
    }
    return numb;
}

int numbA=readNumb();
int numbB=readNumb();
int mth= Pow(numbA,numbB);
Console.WriteLine(mth);
