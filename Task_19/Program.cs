/*
Задача 19
Напишите программу, которая принимает на вход пятизначное 
число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

// 
// string num = Console.ReadLine()??"";
// string num = "13321";
string correctNumber(string messege) // проверка правильности написание согласно условию
{
    bool isCorrect = false;
    int num = 0;
    while(!isCorrect)
    {
        Console.WriteLine(messege);
        string numStr = Console.ReadLine()??"";
        if(int.TryParse(numStr, out num) && num > 9999 && num < 100000)
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Ввели не корректное число");
        }
    }
    return num.ToString();
}

void Polidrom(string num) // решение задачи
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


string num = correctNumber("Введите пятизначное число -> ");

Polidrom(num);