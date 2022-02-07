//  9. Показать последнюю цифру трёхзначного числа
String b = Convert.ToString(123); 
System.Console.WriteLine(b[2]);

// 10. Показать вторую цифру трёхзначного числа
System.Console.WriteLine(b[1]);

// 12. Удалить вторую цифру трёхзначного числа
string a = "123";
string Delete2ndChar (string a, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = a.Length;
    for (int i = 0; i < length; i++)
    {
        if(a[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{a[i]}";
    }
    return result;
}

string c = Delete2ndChar(a, '2','\0');
Console.WriteLine(c);

// 14. Найти третью цифру числа или сообщить, что её нет
int digit = new Random().Next(80, 140); // от 80 включительно до 140
Console.WriteLine("Рандомное число: " + digit);

if (digit>99 & digit <140)
{
    String x = Convert.ToString(digit);
    System.Console.WriteLine("Третья цифра числа " + x[2]);
}
else System.Console.WriteLine("Третья цифра числа отсутствует");

// // Сортировка одномерного массива
// int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

// void PrintArray(int[] array)
// {
//     int count = array.Length;

//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// void SelectionSort(int[] array)
// {
//     for (int i = 0; i < array.Length - 1 ; i++)
//     {
//         int maxPosition = i;
        
//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if(array[j] > array[maxPosition]) maxPosition = j;
//         }
//         int temporary = array[i];
//         array[i] = array[maxPosition];
//         array[maxPosition] = temporary;
//     }
// }
// PrintArray(arr);
// SelectionSort(arr);

// PrintArray(arr);