// ## Почувствуй себя интерном*
//  0. Вывести квадрат числа
// int numberA = new Random().Next(1, 10); // 1 2 3 4 ... 9
// Console.WriteLine(numberA);
// int result = numberA*numberA;
// Console.WriteLine(result);

//  1. По двум заданным числам проверять является ли первое квадратом второго
// Console.Clear();
// string s;
// Console.Write("Введите 1ое число и нажмите клавишу Enter: ");
// s = Console.ReadLine();
// int number1 = Convert.ToInt32(s);
// Console.Write("Введите 2ое число и нажмите клавишу Enter: ");
// s = Console.ReadLine();
// int number2 = Convert.ToInt32(s);

// if (number1 == number2*number2){
//     Console.WriteLine("Первое число является квадратом второго");
// } else {
//     Console.WriteLine("Первое число НЕявляется квадратом второго");
// }

//  2. Даны два числа. Показать большее и меньшее число
// int numberA = new Random().Next(1, 10); // 1 2 3 4 ... 9
// Console.WriteLine(numberA);

// int numberB = new Random().Next(1, 10);
// Console.WriteLine(numberB);

// if (numberA > numberB){
//     Console.WriteLine("Первое число большее, а второе - меньшее");
// } else if (numberA == numberB){
//     Console.WriteLine("Числа равны");
// } else {
//     Console.WriteLine("Второе число большее, а первое - меньшее");
// }

//  3. По заданному номеру дня недели вывести его название

// string[] weekDays = { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };

// Console.Write("Введите номер дня недели = ");
// int n = Convert.ToInt32(Console.ReadLine());
// n--;

// Console.Write("Название дня недели - ");
// Console.WriteLine(weekDays[n]);

//  4. Найти максимальное из трех чисел
// int a = 1;
// int b = 3;
// int c = 3;

// int max = a;
// if(b> max) max=b;
// if(c>max) max=c;

// Console.Write("max = ");
// Console.WriteLine(max);
// 4.1. найти максимальное число через метод-функцию нахождения максимального числа из множества
// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }
// //               0    1   2   3   4   5   6   7   8
// int[] array = { 11, 211, 31, 41, 15, 61, 17, 18, 19 };

// int result = Max(
//     Max(array[0], array[1], array[2]),
//     Max(array[3], array[4], array[5]),
//     Max(array[6], array[7], array[8])
// );
// Console.WriteLine(result);

//  5. Написать программу вычисления значения функции y = f(a)
//  6. Выяснить является ли число чётным

// int numberA = new Random().Next(1, 10); // 1 2 3 4 ... 9
// Console.Write(numberA);
// if (numberA %2 ==0) 
// {
//   Console.WriteLine(" - число четное - even in English");  
// } else Console.WriteLine(" - число нечетное - odd in English");

//6.1. написать метод, определяющий четное или нечетное число было введено с клавиатуры и выводящий ответ
bool OddOrEven (int numberA)       //пытаюсь написать метод, определяющий четное или нечетное число, введенное с клавиатуры
{
    if (numberA %2 ==0) return true; else return false;
}

OddOrEven(6);                     // запускаю метод, определяющий четное или нечетное число было введено с клавиатуры и выводящий ответ
if ( OddOrEven(6)==true) Console.WriteLine(" - число четное - even in English");  
else Console.WriteLine(" - число нечетное - odd in English");


//  7. Показать числа от -N до N
// void FromMinusNtoPlusN(int[] collection)   // метод, наполняющий массив целыми числами от -N до N и выводящий его
// {
//     int length = collection.Length*2;
//     int index = 0;

//     while (index <= length)
//     {
//         collection[index] = -N;
//         index++;
//         N++;    
//     }
// }

// void PrintFromMinusNtoPlusN(int[] col)         // метод, выводящий массив наполненный случайными целыми числами
// {
//     int count = col.Length*2;
//     int position = 0;
//     while (position < count)
//     {
//         Console.WriteLine(col[position]);
//         position++;
//         N++;  
//     }
// }

// Console.Clear();
// string s;
// Console.Write("Введите целое неотрицательное число N: ");
// s = Console.ReadLine();
// int N = Convert.ToInt32(s)*(-1);
// Console.WriteLine("Вы ввели число N: " + (-N));
// int N1 =-N*2+1;
// Console.WriteLine("длинна массива от -N до N, включая 0 =  " + N1 + " элементам");

// int[] array = new int[N1]; // создай новый массив, в котором будет N элементов, заполнен по умолчанию нулями
// FromMinusNtoPlusN(array);

// void FromMinusNtoPlusN(int[] collection)   // метод, наполняющий массив целыми числами от -N до N и выводящий его
// {
//     int length = collection.Length;
//     int index = 0;

//     while (index < length)                  // 1. н=-2, инд=0   2. инд=1
//     {
//         if (N < 0)                          // 1. -2<0          2. н=-1
//         {
//             collection[index] = N;           // 1. 0ой = -2      2. 1ый = -1
//             index++;                         // 1. инд = 1       2. инд = 2
//             N = N + 1;                   // 1. н= -2+1 = -1  2. н=-1+2 - т.е. надо не индекс плюсовать, а единицу плюсовать.
//         }
//         else if (N == 0)
//         {
//             collection[index] = N;
//             index++;
//             N = N + 1;
//         }
//         else
//         {
//             collection[index] = N;
//             index++;
//             N = N + 1;
//         }
//     }
// }
// Console.WriteLine(); // записывает на новую строку пустоту - т.е. делаем пустую строку!
// Console.WriteLine(string.Join(",", array));


//  8. Показать четные числа от 1 до N
// Console.Clear();
// string s;
// Console.Write("Введите целое неотрицательное число N: ");
// s = Console.ReadLine();
// int N = Convert.ToInt32(s);
// Console.WriteLine("длинна массива от 1 до N =  " + N + " элементам");

// int[] array = new int[N]; // создай новый массив, в котором будет N элементов, заполнен по умолчанию нулями
// FromOnetoN(array);

// void FromOnetoN(int[] collection)
// {
//     int length = collection.Length;
//     int index = 0;
//     for (index = 0; index != length; index++)
//     {
//         if (index % 2 == 0)
//         {
//             collection[index] = index;
//         }
        
//     }                       // после выполнения кода выше имеем массив 0,0,2,0,4,0,6,0,8,0
//     int count = 0;

//     for (count =0, index =2; index!= length; count++)               //                  2. count=1, index=4   3. count=2, index=6  
//     {
//         if (collection[index]> 0)                                      // 1. если 2>0   2. 4>0        
//         {
//             collection[count] = collection[index];                     // 1. ,то 0ый=2  2. ,то 1ый=4
//             if (index <N) index = index+2;                             // 1. index =4   2. index =6
            
//         } 
//     }
// }
// int n1 = N/2-1;
// //     int[] arrayEven = new int[n1];
// //     int i = 0;
// //     for (i=0, count=0; i<n1; i++, count++)
// //     {
// //         arrayEven[i] = collection[count];
// //     }
// //             int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
// //             int[] b = { 11, 12, 13, 14, 15, 16, 17, 18, 19 };
 
// //             for (int i = 0; i < a.Length; i +=2)
// //                 b[i] = a[i];
// //             Console.WriteLine(string.Join(" ",b));
// //             Console.ReadKey();
       
// Console.WriteLine(); // записывает на новую строку пустоту - т.е. делаем пустую строку!
// Console.WriteLine(string.Join(",", array));
// Console.WriteLine();
// int i=0;
// for (; i<n1; i++)
// {
//     Console.Write(array[i] + ",");  
// }
// int[] numbers = { 1, 2, 3, 5};
 
// Console.WriteLine(numbers[^1]);  // 5 - последний элемент с конца
// Console.WriteLine(numbers[^2]);  // 3 - предпоследний элемент с конца
// Console.WriteLine(numbers[^3]);  // 2 - третий элемент с конца

//  9. Показать последнюю цифру трёхзначного числа
// 10. Показать вторую цифру трёхзначного числа
// // 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
// void FillArray(int[] collection)   // метод, наполняющий массив случайными целыми числами
// {
//     int length = collection.Length;
//     int index = 0;
//     while (index < length)
//     {
//         collection[index] = new Random().Next(1, 100);
//         //index = index + 1;
//         index++;
//     }
// }

// // void PrintArray(int[] col)         // метод, выводящий массив наполненный случайными целыми числами
// // {
// //     int count = col.Length;
// //     int position = 0;
// //     while (position < count)
// //     {
// //         Console.WriteLine(col[position]);
// //         position++;
// //     }
// // }

// // int IndexOf(int[] collection, int findNumber) // метод, выводящий искомое число среди массива целых случайных чисел
// // {
// //     int count = collection.Length;
// //     int index = 0;
// //     int position = -1;
// //     while (index < count)
// //     {
// //         if (collection[index] == findNumber)
// //         {
// //             position = index;
// //             break;
// //         }
// //         index++;
// //     }
// //     return position;
// // }

// // int Max (int[] collection) // метод, ищущий максимальное число из массива случайных целых чисел
// // {
// //     int length = collection.Length;
// //     int index = 0;
// //     int max = collection[0];
// //     for (index = 1; index < length; index++)
// //     {
// //         if (collection[index] > max) max = collection[index];
// //     }
// //     return max;
// // }

// int[] array = new int[10]; // создай новый массив, в котором будет 10 элементов, заполнен по умолчанию нулям

// FillArray(array);   // метод-функция формирует массив из случайных чисел от 10 до 99 включительно
// // PrintArray(array);  // метод-функция выводит сформированный массив из случайных чисел от 10 до 99 включительно
// Console.WriteLine(); // записывает на новую строку пустоту - т.е. делаем пустую строку
// Console.WriteLine(string.Join("," , array));
// // Console.WriteLine(Max(array));

// 12. Удалить вторую цифру трёхзначного числа
// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.
// 14. Найти третью цифру числа или сообщить, что её нет

