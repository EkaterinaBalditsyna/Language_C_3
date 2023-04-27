// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Введите число: ");
// string number = Console.ReadLine();
// int len = number.Length;

// if (len == 5)
// {
//     if (number[0] == number[4] && number[1] == number[3])
//     {
//         Console.WriteLine($"{number} - Да");
//     }
//     else
//     {
//         Console.WriteLine($"{number} - Нет");
//     }
// }
// else
// {
//     Console.WriteLine($"{number} - не является пятизначным");
// }

// bool IsPalin(int num, int dupNum)
// {
//         if (oneDigit(num))
//         return (num == (dupNum) % 10);
 
//         if (IsPalin(num / 10, dupNum))
//         return false;
 
//     dupNum /= 10;
//     return (num % 10 == (dupNum) % 10);
// } // не работает 

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// int ReadN (string message)

// {   int x1 = ReadN("Введите координату X первой точки: ");
//     int y1 = ReadN("Введите координату Y первой точки: ");
//     int z1 = ReadN("Введите координату Z первой точки: ");
//     int x2 = ReadN("Введите координату X второй точки: ");
//     int y2 = ReadN("Введите координату Y второй точки: ");
//     int z2 = ReadN("Введите координату Z второй точки: ");
// }

// double delta (int A, int B, int C)
// {
//     int A = x2 - x1;
//     int B = y2 - y1;
//     int C = z1 - z2;
//     int length = Math.Sqrt(A * A + B * B + C * C);
// }

// return length;
// Console.WriteLine($"Длина отрезка {length}");

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int number = ReadInt("Введите число N: ");

for (int i = 1; i <= number; i++)
{ 
    Console.WriteLine($"{i*i*i} ");
}



