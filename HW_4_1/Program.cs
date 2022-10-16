 // Используя определение степени числа, напишите цикл, который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.

Console.WriteLine("Ввдеите число A ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввдеите число B ");
int b = Convert.ToInt32(Console.ReadLine());
int result = a;
for (int i = 1; i < b; i++)
    {
        result = result * a;
    } 

Console.WriteLine($"Число {a} в степени {b} равно {result}");