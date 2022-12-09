/*
Задача 23
Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
int CorrectNumber(string messege)
{
    bool isCorrect = false;
    int num = 0;
    while(!isCorrect)
    {
        Console.Write(messege);
        if(int.TryParse(Console.ReadLine(), out num))
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Введите корректное число.");
        }
    }
    return Math.Abs(num);
}
void Desition (int n)
{
    for (int i = 1; i < n+1; i++)
    {
        double result = Math.Pow(i,3);
        Console.Write($"{result} ");
    }
}

int num = CorrectNumber("Введите число -> ");
Desition(num);
