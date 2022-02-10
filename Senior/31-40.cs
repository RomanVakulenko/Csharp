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
FillArray1(array1);
System.Console.Write("[{0}]", string.Join(", ", array1));
int sumOfPositive = 0;
for (int i = 0; i < array1.Length; i++)
{
    if (array1[i] > 0)
    {
        sumOfPositive = sumOfPositive + array1[i];
    }
}
System.Console.WriteLine(", a сумма его положительных элементов (>0)= " + sumOfPositive);
System.Console.WriteLine();
System.Console.WriteLine("34. Написать программу замену элементов массива на противоположные:");

// 34. Написать программу замену элементов массива на противоположные
// Примем за противоположные значения элемента с противоположным знаком
int[] array34 = new int[5];
void FillArray34(int[] array)   // метод, наполняющий массив случайными целыми числами
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(-3, 3);
        index++;
    }
}
FillArray34(array34);
System.Console.WriteLine("[{0}]", string.Join(",", array34));

void oppositeArray(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * (-1);
    }
}
oppositeArray(array34);
System.Console.WriteLine("[{0}]", string.Join(",", array34));
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
int[] array36 = new int[3];
int oddCount = 0;
void FillArray36(int[] array)   // метод, наполняющий массив случайными целыми числами
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(100, 1000);
        if (array[index] % 2 != 0) oddCount++;
        index++;
    }
}
FillArray36(array36);
System.Console.WriteLine("[{0}]", string.Join(",", array36));
System.Console.WriteLine("Количество нечетных чисел = " + oddCount);
System.Console.WriteLine();
System.Console.WriteLine("37. В одномерном массиве из 12 чисел найти количество элементов из отрезка [5,9]");

// 37. В одномерном массиве из 12 чисел найти количество элементов из отрезка [5,9]
int[] rangeInArray = new int[12];
void randomArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 13);
    }
}
randomArray(rangeInArray);
System.Console.WriteLine("[{0}]", string.Join(",", rangeInArray));

int lowBoundaryOfRange = 4;   // [5,9]
int highBoundaryOfRange = 10; // [5,9]
int countElementsInRange = 0;
void findAmountInRange(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > lowBoundaryOfRange & array[i] < highBoundaryOfRange)
        {
            countElementsInRange++;
        }
    }
}
findAmountInRange(rangeInArray);
System.Console.WriteLine("The amount of elements from range [5,9] in array = " + countElementsInRange);
System.Console.WriteLine("38. Найти сумму чисел одномерного массива стоящих на нечетной позиции:");

// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции
int[] array38 = new int[5];
int digitAtoddIndex = 0;
void FillArray38(int[] array)   // метод, наполняющий массив случайными целыми числами, находящий сумму чисел массива стоящих на нечетной позиции
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(1, 10);
        if (index % 2 != 0)
        {
            digitAtoddIndex = digitAtoddIndex + array[index];
        }
        index++;
    }
}
FillArray38(array38);
System.Console.WriteLine("[{0}]", string.Join(",", array38));
System.Console.WriteLine("Сумма чисел массива, стоящих на нечетной позиции = " + digitAtoddIndex);
System.Console.WriteLine();
System.Console.WriteLine("39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.:");

// 39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
int[] arrayToFindTHeProductOfPairedElements = new int[5];

void randomArr(int[] array)                    // метод, наполняющий массив случайными целыми числами
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 13);
    }
}
randomArr(arrayToFindTHeProductOfPairedElements);
System.Console.WriteLine("[{0}]", string.Join(",", arrayToFindTHeProductOfPairedElements));

int product = 0;
int u = 0;
int AmountOfProducts = 1;
while (u < arrayToFindTHeProductOfPairedElements.Length / 2)
{
    if (u < arrayToFindTHeProductOfPairedElements.Length / 2)
    {
        product = arrayToFindTHeProductOfPairedElements[u] * arrayToFindTHeProductOfPairedElements[^(u + 1)];
        arrayToFindTHeProductOfPairedElements[u] = product;
        System.Console.WriteLine(AmountOfProducts + " multipcicationOfPairs = " + product);
    }
    u++;
    AmountOfProducts++;
}

System.Console.WriteLine();
System.Console.WriteLine("40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом");

// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
double[] arrForDifference = new double[5];

void randomArray40(double[] array)                     // метод, наполняющий массив случайными вещественными числами
{
    for (int i = 0; i < array.Length; i++)
    {
        double NextDouble(Random rand, double minValue, double maxValue, int decimalPlaces)
        {
            double randNumber = rand.NextDouble() * (maxValue - minValue) + minValue;
            return Convert.ToDouble(randNumber.ToString("f" + decimalPlaces));
        }
        Random rand = new Random();
        double randNumber = NextDouble(rand, 7.25, 8.76, 2);
        array[i] = randNumber;
    }
}
randomArray40(arrForDifference);
System.Console.WriteLine("[{0}]", string.Join("  ", arrForDifference));

double MaxFromArray(double[] array)      // метод, ищущий максимальное число из массива случайных вещественных чисел
{
    int length = array.Length;
    int index = 0;
    double max = array[0];
    for (index = 1; index < length; index++)
    {
        if (array[index] > max) max = array[index];
    }
    return max;
}
MaxFromArray(arrForDifference);
System.Console.Write("Max: " + MaxFromArray(arrForDifference) + " -");

double MinFromArray(double[] array)      // метод, ищущий максимальное число из массива случайных вещественных чисел
{
    int length = array.Length;
    int index = 0;
    double min = array[0];
    for (index = 1; index < length; index++)
    {
        if (array[index] < min) min = array[index];
    }
    return min;
}
MinFromArray(arrForDifference);
System.Console.WriteLine(" min: " + MinFromArray(arrForDifference) + " = " + Math.Round((MaxFromArray(arrForDifference)-MinFromArray(arrForDifference)),2));

