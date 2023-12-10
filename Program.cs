#pragma warning disable

//Домашнее задание к уроку 2 - Жулдыз Манатова
// Задача 1: Напишите программу, которая принимает
// на вход число и проверяет, кратно ли оно
// одновременно 7 и 23
// a=50 => нет
// a=7 => нет
// a=322 => да

/*
Console.WriteLine("Введите число a");
int a = int.Parse(Console.ReadLine());

if (a %7 == 0 && a %23 == 0)
{
    Console.WriteLine($"a={a} => да");
}
else
{
    Console.WriteLine($"a={a} => нет");
};
*/

// Задача 2: Напишите программу, которая принимает
// на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 
// и выдаёт номер координатной четверти плоскости,
// в которой находится эта точка.
// 2, 3 => 1
// -5, 3 => 2
// -3, -2 => 3
// 4, -2 => 4

/*
Console.WriteLine("Введите координату X");
int X = int.Parse(Console.ReadLine());  

Console.WriteLine("Введите координату Y");
int Y = int.Parse(Console.ReadLine());

if(X != 0 && Y != 0)   
{   
    if(X > 0 && Y > 0)
    {
        Console.WriteLine($"{X}, {Y} => 1");
    }   
     else if(X < 0 && Y > 0)
    {
        Console.WriteLine($"{X}, {Y} => 2");
    } 
     else if(X < 0 && Y < 0)
    {
        Console.WriteLine($"{X}, {Y} => 3");
    } 
     else if(X > 0 && Y < 0)
    {
        Console.WriteLine($"{X}, {Y} => 4");
    } 
}
else
{
    Console.WriteLine("Точка находится на осях координат");
}
*/

// Задача 3: Напишите программу, которая принимает
// на вход целое число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 40 => 4
// 96 => 9
// 72 => 7

/*
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());   

if(num > 9 && num < 99)    
{   
    int num1 = num % 10;   
    int num2 = num / 10;   
    if(num1 > num2)
    {
        Console.WriteLine($"{num} => {num1}");
    }
    else
    {
        Console.WriteLine($"{num} => {num2}");
    }  
}
else
{
    Console.WriteLine("Число не подходит");
}
*/

// Задача 4: Напишите программу, которая на вход
// принимает натуральное число N, а на выходе
// показывает его цифры через запятую.
// 568 => 5,6,8
// 8 => 8
// 9542 => 9,5,4,2

/*
Console.WriteLine("Введите число N ");
int N = int.Parse(Console.ReadLine()); 

string A = "";
int k = N;
while (k > 0)
{
    int b = k % 10;
    A = ($"{b%10},") + A;
    k = k/10;
}

A = A.TrimEnd(',');
Console.WriteLine($"{N} => {A}");
*/