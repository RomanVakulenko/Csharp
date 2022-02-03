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
// 4.1. найти максимальное число через функцию нахождения максимального числа из множества
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
//  7. Показать числа от -N до N
//  8. Показать четные числа от 1 до N
//  9. Показать последнюю цифру трёхзначного числа
// 10. Показать вторую цифру трёхзначного числа
// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
void FillArray(int[] collection)   // метод, наполняющий массив случайными целыми числами
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 100);
        //index = index + 1;
        index++;
    }
}

void PrintArray(int[] col)         // метод, выводящий массив наполненный случайными целыми числами
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int findNumber) // метод, выводящий искомое число среди массива целых случайных чисел
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection[index] == findNumber)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int Max (int[] collection) // метод, ищущий максимальное число из массива случайных целых чисел
{
    int length = collection.Length;
    int index = 0;
    int max = collection[0];
    for (index = 1; index < length; index++)
    {
        if (collection[index] > max) max = collection[index];
    }
    return max;
}

int[] array = new int[10]; // создай новый массив, в котором будет 10 элементов, заполнен по умолчанию нулям

FillArray(array);   // метод-функция формирует массив из случайных чисел от 10 до 99 включительно
PrintArray(array);  // метод-функция выводит сформированный массив из случайных чисел от 10 до 99 включительно
Console.WriteLine(); // записывает на новую строку пустоту - т.е. делаем пустую строку

Console.WriteLine(Max(array));

// 12. Удалить вторую цифру трёхзначного числа
// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.
// 14. Найти третью цифру числа или сообщить, что её нет
// Console.WriteLine("Hello, World!");
