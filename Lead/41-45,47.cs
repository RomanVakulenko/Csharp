// // ## Почувствуй себя лидом*
// // 41. Выяснить являются ли три числа сторонами треугольника 
// // Любая сторона треугольника меньше суммы двух других её сторон и больше их разности:

// int x1 = 1; int y1 = 1;
// int x3 = 5; int y3 = 4;
// int x2 = 5; int y2 = 1;
// int[] side1 = { x1, y1, x3, y3 };     //кажется, что не пригодились из-за тепличных вводных, но будет работать, если элементы назвать иначе.
// int[] side2 = { x3, y3, x2, y2 };
// int[] side3 = { x2, y2, x1, y1 };
// int lengthSection2 = y3 - y2;
// int lengthSection3 = x2 - x1;
// double lengthSection1 = Math.Sqrt(lengthSection2 * lengthSection2 + lengthSection3 * lengthSection3);

// System.Console.WriteLine(lengthSection1 + " - the lenght of side1 (hypothenuse)");
// System.Console.WriteLine(lengthSection2 + " - the lenght of side2 (shorter cathetus)");
// System.Console.WriteLine(lengthSection3 + " - the lenght of side3 (longer cathetus)");
// System.Console.WriteLine();
// if (lengthSection1 < lengthSection2 + lengthSection3 & lengthSection2 > lengthSection1 - lengthSection3)
//     System.Console.WriteLine("Lenghts of the sides says the it could be a triangle, let's check for the binding of the sections. ");
// if (side1[0] == side3[2] & side1[1] == side3[3] &
//     side1[2] == side2[0] & side1[3] == side2[1] &
//     side3[0] == side2[2] & side3[1] == side2[3])
//     System.Console.WriteLine("The sides are bound, so the are set up a triangle.");
// System.Console.WriteLine();
// System.Console.WriteLine("42. Определить сколько чисел больше 0 введено с клавиатуры");

// // 42. Определить сколько чисел больше 0 введено с клавиатуры

// int N = 5;
// System.Console.WriteLine("Кол-во чисел = " + N);
// int[] howManyPositive = new int[N];

// void FillArray(int[] array)   // метод, наполняющий массив случайными целыми числами
// {
//     int length = array.Length;
//     int index = 0;
//     while (index < length)
//     {
//         string str = String.Empty;
//         Console.Write("Введите любое целое число: ");
//         str = Console.ReadLine(); //считать введенное число
//         int number = Convert.ToInt32(str);
//         array[index] = number;
//         index++;
//     }
// }
// FillArray(howManyPositive);
// System.Console.WriteLine("[{0}]", string.Join(",", howManyPositive));
// int PositiveNumber = 0;
// for (int i = 0; i < howManyPositive.Length; i++)
// {
//     if (howManyPositive[i] > 0) PositiveNumber++;
// }
// System.Console.WriteLine("There are " + PositiveNumber + " numbers amoung the entered more then 0");
// System.Console.WriteLine();
// System.Console.WriteLine("43. Написать программу преобразования десятичного числа в двоичное");


// // 43. Написать программу преобразования десятичного числа в двоичное

// Console.Clear();

// System.Console.Write("Enter the decimal number: ");
// int digitToConvert = int.Parse(Console.ReadLine());

// List<string> listOfBinaryNumbers = new List<string>();
// for (int i = 0; digitToConvert != 0; i++)
// {
//     int remainder = digitToConvert % 2;
//     if (remainder == 1)
//     {
//         listOfBinaryNumbers.Add("1");
//     }
//     if (remainder == 0)
//     {
//         listOfBinaryNumbers.Add("0");
//     }
//     digitToConvert = digitToConvert / 2;
// }
// listOfBinaryNumbers.Reverse();

// foreach (string result in listOfBinaryNumbers)
// {
//     Console.Write(result);
// }
// System.Console.WriteLine();


// List<int> x = new List<int>();    //Создали пустую коллекцию для хранения целых чисел
// x.Add(5);                         //добавили в коллекцию типа int  число 5
// foreach (int some in x)           //дляКаждого чего-то(some) в коллекции x 
// {
// 	Console.WriteLine(some);         //выведи эти что-то 
// }

// List<int> x = new List<int>() { 5, 27, -6, 14, 70, 14, 178 };
// x.Reverse();          //Получить обратный порядок элементов, т.е. 178, 14, 70, 14, -6, 27, 51

// 44. Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

int k1 = 2; int b1=3;
int k2 = 4; int b2 = 5;
int y1, y2; 

bool flag = false;
int[] xr = new int [1000000]; 
for (int i = 1; i < xr.Length; i++)
{
    int x;
    xr[i] = -500000+i;
    x = xr[i];
    y1 = Math.Abs(k1 * x + b1);
    y2 = Math.Abs(k2 * x + b2);
    if (y1-y2 == 0) 
    {
        flag = true;
        System.Console.WriteLine("Crossing at x = " + x);
    }
}
if (flag ==true) System.Console.WriteLine("Есть пересечение");
else System.Console.WriteLine("Нет пересечения");

// 45. Показать числа Фибоначчи
// int [] fibo = new int [25];

// void FillArrayFibo(int[] array)   // метод, наполняющий массив случайными целыми числами и копирующий его
// {
//     for (int index = 0; index < array.Length; index++)
//     {
//         if (index==0) array[index]=0;
//         else if (index==1) array[index]=1;
//             else
//             {
//                 array[index] = array[index-1]+array[index-2];    
//             }
//         System.Console.Write($"{array[index]} ");
//     } 
// }

// FillArrayFibo(fibo);
// System.Console.WriteLine("- fibo sequence");
// 46. Написать программу масштабирования фигуры
// ```
// Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
// например: "(0,0) (2,0) (2,2) (0,2)"
// коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
// В результате показать координаты, которые получатся.
// при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"
// ```
System.Console.WriteLine();
System.Console.WriteLine("47. Написать программу копирования массива");
// 47. Написать программу копирования массива
// Console.Clear();
// int [] arr1 = new int [5];

// void FillArrayX(int[] array)   // метод, наполняющий массив случайными целыми числами и копирующий его
// {
//     for (int index = 0; index < array.Length; index++)
//     {
//         array[index] = new Random().Next(0, 11);    
//         System.Console.Write($"{arr1[index]} ");
//     } 
//     System.Console.WriteLine("- array for copy");
// }

// FillArrayX(arr1);
// int[] copyOfArr = arr1;

// System.Console.WriteLine();
// System.Console.Write("[{0}]", string.Join("  ", copyOfArr));
// System.Console.Write(" - we've just copied the array 'arr1' by assigning it to another array");

