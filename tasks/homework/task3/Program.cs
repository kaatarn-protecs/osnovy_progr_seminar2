// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите номер дня недели ");
int day = Convert.ToInt32(Console.ReadLine());

int Weekend(int numday)
{
    if (numday >= 1 && numday <=7)
    {
        return numday > 5 ? 1 : 2;
    }
    else return -1;
}

int res = Weekend(day);
string result;
if (res > 0) 
{
    result = res == 1 ? "Да" : "Нет";
    Console.WriteLine($"{day} -> {result}");
}
else Console.WriteLine($"{day} -> Неверное число!");