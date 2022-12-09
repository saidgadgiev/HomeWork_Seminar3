/*
Задача 21
Напишите программу, которая принимает на вход координаты 
двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53

Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)+Math.Pow((z2-z1),2))
*/

int CorrectNumber(string messege)
{
    bool isCorrect = false;
    int num = 0;
    while(!isCorrect)
    {
        Console.Write(messege);
        if (int.TryParse(Console.ReadLine(), out num))
        {
            isCorrect = true;
        }
        else 
        {
            Console.WriteLine("Введите корректное число");
        }
    }
    return num;
}

int x1 = CorrectNumber("Введите координат X для точки А -> ");
int y1 = CorrectNumber("Введите координат Y для точки А -> ");
int z1 = CorrectNumber("Введите координат Z для точки А -> ");
int x2 = CorrectNumber("Введите координат X для точки В -> ");
int y2 = CorrectNumber("Введите координат Y для точки В -> ");
int z2 = CorrectNumber("Введите координат Z для точки В -> ");

double result = Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)+Math.Pow((z2-z1),2));
Console.Write($"Растояние между чочками A ({x1},{y1},{z1}) и B ({x2},{y2},{z2}) равна -> ");
Console.WriteLine("{0: 0.00}", result);