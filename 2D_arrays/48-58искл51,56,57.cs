// ## Двумерные массивы
// 48. Показать двумерный массив размером m×n заполненный целыми числами
System.Console.WriteLine();
System.Console.WriteLine("48. Показать двумерный массив размером m×n заполненный целыми числами");

int m = 5; int n = 10;
int[,] arr = new int [m,n];

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);// [1; 10)
        }
    }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

FillArray(arr);
PrintArray(arr);

// // 49. Показать двумерный массив размером m×n заполненный вещественными числами
System.Console.WriteLine();
System.Console.WriteLine("49. Показать двумерный массив размером m×n заполненный вещественными числами");

// int m1 = 5; int n1 = 10;
// double[,] ArrOfDouble = new double [m1,n1];

// void FillDoubleArray(double[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             double NextDouble(Random rand, double minValue, double maxValue, int decimalPlaces)
//             {
//                 double randNumber = rand.NextDouble() * (maxValue - minValue) + minValue;
//                 return Convert.ToDouble(randNumber.ToString("f" + decimalPlaces));
//             }
//             Random rand = new Random();
//             double randNumber = NextDouble(rand, 7.25, 8.76, 2);
//             matr[i,j] = randNumber;
//         }
//     }
// }

// void PrintDoublArray(double[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// FillDoubleArray(ArrOfDouble);
// PrintDoublArray(ArrOfDouble);

double[,] a = new double[5, 10];

Random random = new Random();
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 10; j++)
    {
        a[i, j] = random.NextDouble() * 100; // NextDouble() дает случайное вещественное число в диапазоне от 0 до 100
        Console.Write("{0,6:F1}", a[i, j]);
    }
    Console.WriteLine();
}

// 50. В двумерном массиве n×k заменить четные элементы на противоположные
System.Console.WriteLine("50. В двумерном массиве n×k заменить четные элементы на противоположные");

int v = 3; int b = 4;
int[,] arr50 = new int [v,b];

void FillArray50(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);// [1; 10)
        }
    }
}

void PrintArray50(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void ChangeArray50(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (j%2==0) matr[i, j] = -matr[i, j];
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
FillArray50(arr50);
PrintArray50(arr50);
System.Console.WriteLine();
ChangeArray50(arr50);

// // 51. Задать двумерный массив следующим правилом: Aₘₙ = m+n
// System.Console.WriteLine();
// System.Console.WriteLine("51. Задать двумерный массив следующим правилом: Aₘₙ = m+n");

// 52. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
System.Console.WriteLine();
System.Console.WriteLine("52. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты");

int[,] arr52 = new int [4,4];

void FillArray52(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);// [1; 10)
        }
    }
}

void PrintArray52(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void ChangeArray52(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i%2==0 & j%2==0) matr[i, j] = matr[i, j]*matr[i, j];
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
FillArray52(arr52);
PrintArray52(arr52);
System.Console.WriteLine();
ChangeArray52(arr52);

// 53. В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет
System.Console.WriteLine();
System.Console.WriteLine("53. В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет");

int[,] arr53 = new int [4,4];

void FillArray53(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);// [1; 10)
        }
    }
}

void PrintArray53(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FindInArray53(int[,] matr)
{
    System.Console.Write("Type any whole number in range 0 to 10: ");
    int find = int.Parse(Console.ReadLine());
    int notFind = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] == find) 
            Console.WriteLine("Position of finding number is: i = " + i + ", j = " + j);
            else notFind = 0;
        }
    } 
    if (notFind == 0) System.Console.WriteLine("There is no such an element in array");
}

FillArray53(arr53);
PrintArray53(arr53);
System.Console.WriteLine();
FindInArray53(arr53);

// 54. В матрице чисел найти сумму элементов главной диагонали
System.Console.WriteLine();
System.Console.WriteLine("54. В матрице чисел найти сумму элементов главной диагонали");

int[,] arr54 = new int [4,5];

void FillArray54(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);// [1; 10)
        }
    }
}

void PrintArray54(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void SumOfMainDiagonalArray54(int[,] matr)
{
    int sum = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i == j) sum = sum + matr[i, j];
        }
    }
    Console.WriteLine("SumOfMainDiagonalInArray is equal to " + sum);
}
FillArray54(arr54);
PrintArray54(arr54);
System.Console.WriteLine();
SumOfMainDiagonalArray54(arr54);

// 55. Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
System.Console.WriteLine();
System.Console.WriteLine("55. Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.");

int[,] Arr = new int [4,5];

void FillArr(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0, 5);// [1; 5)
        }
    }
}

void PrintArr(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}     ");
        }
        Console.WriteLine();
    }
}

void SimpleAverageOfColumnsOfArr(int[,] matr)
{
    int SumOfRowsBytheColumn = 0;
    double[] SA = new double[matr.GetLength(1)];

    for (int j = 0; j < matr.GetLength(1); j++)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            SumOfRowsBytheColumn = SumOfRowsBytheColumn + matr[i, j];   //нашли сумму по столбцу
        } 
        
        for (int c = 0; c < SA.Length; c++)      // формируем массив сумм и среднего арифметического
        {
            if (c == j)
            SA[j] = SumOfRowsBytheColumn;
            if (j == matr.GetLength(1)-1 & SA[j] !=0) 
            {
                System.Console.WriteLine("Below you can see the SumOfRowsBytheColumn:");
                Console.WriteLine(string.Join(",    ", SA)); ; 
            }               
        }
        SumOfRowsBytheColumn = 0;
    }
    for (int z = 0; z < SA.Length; z++)
    {
        SA[z] = SA[z]/matr.GetLength(0);
    }
    System.Console.WriteLine("Below you can see the SimpleAverageOfRowsBytheColumn:");
    Console.WriteLine(string.Join(", ", SA));
}

FillArr(Arr);
PrintArr(Arr);
SimpleAverageOfColumnsOfArr(Arr);
// // 56. Написать программу, которая обменивает элементы первой строки и последней строки
// System.Console.WriteLine();
// System.Console.WriteLine("56. Написать программу, которая обменивает элементы первой строки и последней строки");

// int e = 4; int r = 5;
// int[,] arr56 = new int [e,r];

// void FillArray56(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = new Random().Next(0, 5);// [1; 5)
//         }
//     }
// }

// void PrintArray56(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// // void ChangeArray56(int[,] matr)
// // {
// //     int[] forSave = new int[];
// //     for (int j = 0; j < matr.GetLength(1); j++)
// //     {
// //         for (int i = 0; i < matr.GetLength(0); i++)
// //         {
// //             Console.Write($"{matr[i, j]} ");
// //         }
// //         int d = 0;
// //         if (d==0) 
// //         {
// //             forSave = matr[d, j]; 
// //             matr[d, j] = matr[e-1, j];
// //             matr[e-1, j] = forSave;
// //         }
// //         Console.WriteLine();
// //     }   
// // }
// FillArray56(arr56);
// PrintArray56(arr56);
// System.Console.WriteLine();
// ChangeArray56(arr56);

// 57. Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.
// 58. Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно (в случае, если матрица не квадратная).
System.Console.WriteLine();
System.Console.WriteLine("58. Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно (в случае, если матрица не квадратная).");
int q = 4; int w = 4;
int[,] arr58 = new int [q,w];

void FillArray58(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0, 5);// [1; 5)
        }
    }
}

void PrintArray58(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void ChangeArray58(int[,] matr)
{
    if (q==w)
    {
        System.Console.WriteLine("The amount of rows is equal to the amount of columns, that is why we can change rows to columns & vice versa");
        int forSave = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                Console.Write($"{matr[i, j]} ");
            }
            int t = 0;
            if (t==0) 
            {
                forSave = matr[t, j]; 
                matr[t, j] = matr[q-1, j];
                matr[q-1, j] = forSave;
            }
            Console.WriteLine();
        } 
    }
    else System.Console.WriteLine("Can't change rows to columns because the matrix is not square");  
}
FillArray58(arr58);
PrintArray58(arr58);
System.Console.WriteLine();
ChangeArray58(arr58);

// 59. В прямоугольной матрице найти строку с наименьшей суммой элементов.
// 60. Составить частотный словарь элементов двумерного массива

// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

// Пример: 
// Есть набор данных 

// ```
// { 1, 9, 9, 0, 2, 8, 0, 9 }
// ```
// частотный массив может быть представлен так:
// ```
// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза
// ```
// Если набор данных - таблица
// ```
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// ```
// на выходе ожидаем получить
// ```
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза
// ```
// Пример частотного массива для текстовых данных:
// Входные данные:

// _Частотный анализ – это один из методов криптоанализа, основывающийся на предположении о существовании нетривиального статистического распределения отдельных символов и их последовательностей как в открытом тексте, так и шифрованном тексте, которое с точностью до замены символов будет сохраняться в процессе шифрования и дешифрования._

// Частотный анализ может выглядеть так
// ```
// Символ пробел/space встречается 41 раз. Частота 12.28%
// Символ о встречается 38 раз.  Частота 11.38%
// Символ и встречается 26 раз.  Частота 7.78%
// Символ т встречается 25 раз.  Частота 7.49%
// Символ е встречается 23 раза. Частота 6.89%
// Символ с встречается 21 раз.  Частота 6.29%
// Символ н встречается 20 раз.  Частота 5.99%
// Символ а встречается 20 раз.  Частота 5.99%
// Символ в встречается 16 раз.  Частота 4.79%
// Символ р встречается 12 раз.  Частота 3.59%
// Символ л встречается 10 раз.  Частота 2.99%
// Символ к встречается 9 раз.   Частота 2.69%
// Символ д встречается 9 раз.   Частота 2.69%
// Символ п встречается 6 раз.   Частота 1.80%
// Символ я встречается 6 раз.   Частота 1.80%
// Символ м встречается 6 раз.   Частота 1.80%
// Символ ь встречается 5 раз.   Частота 1.50%
// Символ ы встречается 5 раз.   Частота 1.50%
// Символ з встречается 4 раза.  Частота 1.20%
// Символ х встречается 3 раза.  Частота 0.90%
// Символ ш встречается 3 раза.  Частота 0.90%
// Символ ф встречается 3 раза.  Частота 0.90%
// Символ ч встречается 3 раза.  Частота 0.90%
// Символ й встречается 3 раза.  Частота 0.90%
// Символ , встречается 3 раза.  Частота 0.90%
// Символ щ встречается 2 раза.  Частота 0.60%
// Символ ю встречается 2 раза.  Частота 0.60%
// Символ у встречается 2 раза.  Частота 0.60%
// Символ г встречается 2 раза.  Частота 0.60%
// Символ ж встречается 1 раз.   Частота 0.30%
// Символ э встречается 1 раз.   Частота 0.30%
// Символ – встречается 1 раз.   Частота 0.30%
// Символ б встречается 1 раз.   Частота 0.30%
// Символ ц встречается 1 раз.   Частота 0.30%
// Символ . встречается 1 раз.   Частота 0.30%
// ```
// [url](https://abakbot.ru/online-5/97-freq-letter "источник")

// 61. Найти произведение двух матриц
// 62. В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.
// 63. Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента
// 64. Показать треугольник Паскаля
// *Сделать вывод в виде равнобедренного треугольника
// 65. Спирально заполнить двумерный массив:
// ```
//   1  2  3  4
//  12 13 14  5
//  11 16 15  6
//  10  9  8  7 
// ```