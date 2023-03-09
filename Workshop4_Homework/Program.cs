// Урок 4. Функции

// Задача 2: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// Формула an = a * a .. a / n

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// Console.WriteLine("Введите число A: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число B: ");
// int b = Convert.ToInt32(Console.ReadLine());
// int n = 1; 
// if (b < 1)
// Console.Write($"Число B натуральная степень?");
// else
// {
//   while (b!=0)
//   {
//     n = n * a;
//     b = b -1;
//   }
// }

// Console.Write($"Число A в натуральной степени В равно {n}: ");





// Задача 27: Напишите программу, которая принимает на вход
// число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12
// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int len = Length(a);
// Console.Write($"Сумма цифр в числе {a} равно: {Sum(a,len)}");
// int Length(int a)  //счет символов
// {
// int index = 0;
// while (a > 0)
// {
// a /= 10;
// index++;
// }
// return index;
// }

// int Sum(int a, int len)
// {
// int sum = 0;
// for (int i = 1; i <= len; i++)
// {
// sum += a % 10;
// a /= 10;
// }
// return sum;
// }


// Задача 29: Напишите программу, которая задаёт массив 
// из 8 элементов и выводит их на экран/.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]




//задаем массив из 8 элементов

// {
// int[] myArray;
// myArray = new int [8];   
// int a = myArray[0];

// Console.WriteLine(myArray.Length);

// Console.ReadLine();
// }
// Инициализация массива другой способ

Console.Write("Введите количество элементов массива:\t"); 
//запрос (\t) отступ в виде табуляции
int elementsCount = int.Parse(Console.ReadLine());

int[] myArray = new int[elementsCount]; // int[] myArray = new int[8];

for (int i = 0; i < myArray.Length; i++)
{
Console.Write($"Введите  № элемент массива  {i}:\t"); 
myArray[i] = int.Parse(Console.ReadLine());
}  
Console.WriteLine("\nВывод массива:");

for (int i = 0; i < myArray.Length; i++)
{
 Console.WriteLine(myArray[i]);
}
Console.ReadLine();

