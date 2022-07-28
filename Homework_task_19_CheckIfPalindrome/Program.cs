// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначноt число: ");
string userEnter = Console.ReadLine()!;

if(userEnter[0] == userEnter[4] && userEnter[1] == userEnter[3])
    Console.Write($"Число {userEnter} является палиндромом.");
else
    Console.Write($"К сожалению, число {userEnter} не является палиндромом.");