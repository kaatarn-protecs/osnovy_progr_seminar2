// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98


int number = new Random().Next(10, 1000); // Генератора псевдослучайных чисел
Console.WriteLine($"Случайное трехзначное число -> {number}");

int firstDigit = number / 100; // Получили первую цифру
int secondDigit = number % 10; // Получили последнюю цифру

int result = (firstDigit * 10) + secondDigit;
Console.WriteLine($"Преобразованное число -> {result}");