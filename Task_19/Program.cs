/*
Задача 19
Напишите программу, которая принимает на вход пятизначное 
число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.WriteLine("Введите пятизначное число -> ");
// string num = Console.ReadLine()??"";
string num = "13321";
void Polidrom(string num)
{
    int lenght = num.Length;
    int lenghtEnd = lenght - 1;
    int lenPol = lenght / 2;
    int count = 0;

    for (int i = 0; i < lenPol; i++)
    {
        if (num[i] == num[lenghtEnd])
        {
            count++;
            lenghtEnd--;
            
        } 
    }
    // Console.WriteLine(count);
    if (count == lenPol) Console.WriteLine($"Число {num} являеться полидромом");
    else Console.WriteLine($"Число {num} не являеться полидромом");
}

Polidrom(num);