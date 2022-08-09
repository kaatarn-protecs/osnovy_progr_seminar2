// Задача 10: Напишите программу, 
// которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число ");
int num = Convert.ToInt32(Console.ReadLine());

int SecondDigit(int num)
{
    if (num >= 100 && num < 1000 || num <= -100 && num > -1000)
    {
        num = num / 10; // Отсекаем третью цифру делением
        return num % 10; // Оставляем вторую цифру, через остаток от деления
    }
    else return -1; // Если цифра вне диапазона
}

int result = SecondDigit(num);
string res = result == -1 ? "Вы ввели некорректное число!" : result.ToString();
Console.WriteLine($"Вторая цифра числа {num} -> {res}");