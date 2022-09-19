/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/


Console.Write("Ведите трёхзначное число: ");
int x = Convert.ToInt32(Console.ReadLine());

if (x < 100 || x > 999){
    Console.WriteLine(x + " -> не трехзначние число");
} else {
    // можно и без (x % 10)
    int res_x = ( (x % 100) - (x % 10) ) / 10;

    Console.WriteLine(x + " -> " + res_x); 
}


/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6*/

Console.Write("Ведите число: ");
int x = Convert.ToInt32(Console.ReadLine());

if ( x < 100){
    Console.WriteLine(x + " -> третьей цифры нет");
} else {
    int res_x = x;
    while (res_x > 999){
        res_x = res_x / 10;
    }
    res_x = res_x % 10;

    Console.WriteLine(x + " -> " + res_x);
}


/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/

Console.Write("Введите цифру, обозначающую день недели: ");
int x = Convert.ToInt32(Console.ReadLine());

//int res_x = (x - (x % 100) ) / 10 + (x % 10);
if (x < 1 || x > 7){
    Console.WriteLine(x + " -> нет такого дня недели");
} else if (x < 6){
    Console.WriteLine(x + " -> Нет");
} else {
    Console.WriteLine(x + " -> Да");
}
