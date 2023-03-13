/ Задача 34:
// Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.


// [345, 897, 568, 234] -> 2


// int[] GenerateRandomArray(int size, int start, int end)
// {
//     //объявляем массив размера size( количество элементов = size)
//     // это выделена область памяти для переменных типа int (количество переменных = size)
//     int[] RandomArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         //Генерируем число из диапазона [start;end] и записываем его в i-йэлемент массива
//         RandomArray[i] = new Random().Next(start, end + 1);
//     }
//     //так как "int[] Gen" то вернуть должны что-то типа int[]. А это массив СОЗДАННЫЙ
//     return RandomArray;
// }


// //Метод для вывода элементов массива в консоль для вывода на экрана
// //передаём "()" в метод ShowArray массив "int[] "
// void ShowArray(int[] Array1)
// {
//     for (int i = 0; i < Array1.Length; i++)
//     {
//         Console. Write($"Случайное число: " );
//         Console.WriteLine( Convert.ToString(Array1[i]));
//     }
// }


// // Проверка количества чётных чисел (элементов) массива
// int numEven(int[] myArray2)
// //передаём "()" в метод ShowArray массив "int[] ", возвращаем число "int Co..."
// {
//     //Счётчик, куда сохраняем сколько раз попались чётные числа (при каждом новом нахождении +1)
//     int Count = 0;
//     for (int i = 0; i < myArray2.Length; i++)
//         if (myArray2[i] % 2 == 0)
//         {
//             Count = Count + 1;
//         }
//     return Count;
// }


// // ВЫЗОВ РАНЕЕ ОБЪЯВЛЕННЫХ МЕТОДОВ
// int[] myArray = new int[5];
// myArray = GenerateRandomArray(3, 100, 999);
// ShowArray(myArray);
// Console.WriteLine("Количество четных чисел в случайном массиве =  " + numEven(myArray));


// Задача 36:
// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.


// [3, 7, 23, 12] -> 19


// [-4, -6, 89, 6] -> 0


// int[] RandomArray(int size, int start, int end)
// {
//     int[] randomArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         randomArray[i] = new Random().Next(start, end);
//     }
//     return randomArray;
// }


// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }


// int SumElementPosition(int[] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i % 2 != 0)
//         {
//             sum += array[i];
//         }
//     }
//     return sum;
// }


// int[] array = RandomArray(4, 0, 99);
// ShowArray(array);


// int sum = SumElementPosition(array);
// Console.WriteLine($"Сумма элементов массива, стоящих на нечётных позициях = {sum}");


// Задача 38: Задайте массив вещественных чисел(тип double).
// Найдите разницу между максимальным и минимальным элементов массива.


// [3,1; 7,2; 22,3; 2,4; 78,5] -> 76,1


// int[] RandomArray(int size, int start, int end)
// {
//     int[] randomArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         randomArray[i] = new Random().Next(start, end);
//     }
//     return randomArray;
// }


// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }


// int MaxNumber(int[] array)
// {
//     int max = array[0];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > max)
//         {
//             max = array[i];
//         }
//     }
//     return max;
// }


// int MinNumber(int[] array)
// {
//     int min = array[0];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < min)
//         {
//             min = array[i];
//         }
//     }
//     return min;
// }


// int[] array = RandomArray(6, 0, 100);
// ShowArray(array);


// int max = MaxNumber(array);
// int min = MinNumber(array);
// int difference = max - min;


// Console.WriteLine($"Разница между {max} и {min} равна {difference}");


