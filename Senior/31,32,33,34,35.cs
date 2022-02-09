// ## Почувствуй себя сеньором*
// 31. Задать массив из 8 элементов и вывести их на экран 
System.Console.WriteLine("31. Задать массив из 8 элементов и вывести их на экран:");
int[] nums = new int[8];
int[] nums5 = { 1, 2, 3, 4 };
System.Console.WriteLine("[{0}]", string.Join(", ", nums));
System.Console.WriteLine(string.Join("\n", nums5));
Array.ForEach(nums, Console.Write);
System.Console.WriteLine();
System.Console.WriteLine("32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран:");


// 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран 
void FillArray(int[] array)   // метод, наполняющий массив случайными целыми числами
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(0, 2);
        index++;
    }
}

int[] array = new int[8];
FillArray(array);
System.Console.WriteLine("[{0}]", string.Join(", ", array));
System.Console.WriteLine();
System.Console.WriteLine("33. Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива:");

// 33. Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
int[] array1 = new int[12];
void FillArray1(int[] array)
{
    int length = array.Length;
    int index = 0; 
    while (index < length)
    {
        array[index] = new Random().Next(0, 10);
        index++;
    }
}
FillArray1 (array1);
System.Console.Write("[{0}]", string.Join(", ", array1)); 
int sumOfPositive = 0;
for (int i = 0; i < array1.Length; i++)
{
    if (array1[i]>0)
    { 
        sumOfPositive = sumOfPositive + array1[i];
    }
}
System.Console.WriteLine(", a сумма его положительных элементов (>0)= " + sumOfPositive);
System.Console.WriteLine();
System.Console.WriteLine("34. Написать программу замену элементов массива на противоположные:");

// 34. Написать программу замену элементов массива на противоположные

System.Console.WriteLine();
System.Console.WriteLine("35. Определить, присутствует ли в заданном массиве, некоторое число:");


// 35. Определить, присутствует ли в заданном массиве, некоторое число 
int v = new Random().Next(1, 10);
int[] array2 = new int[10];
FillArray1(array2);

bool FindInArray(int[] collection, int findNumber) // метод, отвечающий, есть ли искомое число среди массива целых случайных чисел или нет
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection[index] == findNumber)
        {
            position = index;
            return true;
            break;
        }
        index++;
    }
    return false;
}

System.Console.WriteLine("[{0}]", string.Join(",", array2));
if (FindInArray(array2, v) == true) Console.WriteLine("Число " + v + " найдено в массиве");
else Console.WriteLine("Число " + v + " не найдено в массиве");
System.Console.WriteLine();
System.Console.WriteLine("36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных или четных чисел:");

// 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции

// 39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
