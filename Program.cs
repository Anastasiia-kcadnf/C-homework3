// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
/*
bool IsPalyndrome (int number)
{
    int firstNumber = number;
    int reversedNumber = 0;
    while (firstNumber > 0)
    {
        reversedNumber = reversedNumber * 10 + firstNumber % 10;
        firstNumber /= 10;
    }

    bool result = false;
    if(reversedNumber == number)
    {
        result = true;
    }
    return result;
}

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

bool result = IsPalyndrome (number);

Console.WriteLine($"Number {number} is palyndrome - " + result);
*/

// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
/*
double LineLength(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double line1Length = x2 - x1;
    double line2Length = y2 - y1;
    double line3Length = z2 - z1;
    double result = Math.Sqrt(Math.Pow(line1Length, 2) + Math.Pow(line2Length, 2) + Math.Pow(line3Length, 2));
    
    return result;
}

Console.Write("Input coordinate X of first point: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input coordinate Y of first point: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input coordinate Z of first point: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input coordinate X of second point: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input coordinate Y of second point: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input coordinate Z of second point: ");
double z2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Line length between first point and second point: " + Math.Round(LineLength(x1, y1, z1, x2, y2, z2), 2));
*/


// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу 
// кубов чисел от 1 до N.
/*
void PrintCube(int N)
{
    int i = 1;
    while(i <= N)
    {
        Console.Write(Math.Pow(i, 3) + " ");
        i++;
    }
}

Console.Write("Input a number: ");
int N = Convert.ToInt32(Console.ReadLine());
PrintCube(N);
*/