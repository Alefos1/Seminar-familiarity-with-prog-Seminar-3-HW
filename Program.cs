
/*//Напишите программу, которая принимает на вход пятизначное число и 
//проверяет, является ли оно палиндромом.

void CheckPalindromicNumber(int number)
{
    if(number >= 10000)
    {
        int division1 = number / 10000;
        int remainder1 = number % 10;
 
            if(division1 == remainder1)
            {
                number = number / 10;
                int division2 = (number / 100) % 10;
                int remainder2 = number % 10;
                if(division2 == remainder2)
                    Console.WriteLine("является палиндромом");
            }
            else 
            Console.WriteLine("Не является палиндромом");
            
    }
    else
    Console.WriteLine("Некорректное число!");
}
 
Console.WriteLine("Введите пятизначное число:");
int number = int.Parse(Console.ReadLine()!);
CheckPalindromicNumber(number);
*/

/*//Напишите программу, которая принимает на вход координаты двух точек
//и находит расстояние между ними в 3D пространстве.


int x1 = ReadInt("Введите координату X первой точки: ");
int y1 = ReadInt("Введите координату Y первой точки: ");
int z1 = ReadInt("Введите координату Z первой точки: ");
int x2 = ReadInt("Введите координату X второй точки: ");
int y2 = ReadInt("Введите координату Y второй точки: ");
int z2 = ReadInt("Введите координату Z второй точки: ");

int A = x2 - x1;
int B = y2 - y1;
int C = z1 - z2;

double length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine($"Длинна отрезка {length}");


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
*/

/*//Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.

int number = ReadInt("Введите число N: ");

for (int i = 1; i <= number; i++)
{ 
    Console.Write($"{i*i*i} ");
}


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
*/