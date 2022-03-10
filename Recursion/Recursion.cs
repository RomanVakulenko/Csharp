// // ## Рекурсия
// // 66. Показать натуральные числа от 1 до N, N задано
// // int N = 5;
// // int wholeNumbers (int N)
// // {   
// //     if (N==1) return 1;
// //     else return N*wholeNumbers(N-1);
// // }
// // // System.Console.WriteLine(wholeNumbers(N));
// // for (int i = 1; i < N+1; i++)
// // {
// //     System.Console.WriteLine(wholeNumbers(i));
// // }
// void Recur(int n)
// {
//     if (n == 1) Console.Write(" "+ n);
//     else
//     {
//         Recur(n - 1);
//         Console.Write(" "+ n);
//     }
// }
// Recur(8);
// System.Console.WriteLine();

// // или
// void PrintNumber(int n)
// {             
//     if(n != 7) PrintNumber(n - 1);                                    
//     Console.Write(" "+ n);
// }
// PrintNumber(13);
// System.Console.WriteLine();

// // 67. Показать натуральные числа от N до 1, N задано

// void From1toN (int n)
// {
//     if (n < 1) 
//     {
//         Console.Write("{0} ", n);
//         From1toN(n + 1);
//     }
// }
// From1toN (-10);

// 68. Показать натуральные числа от M до N, N и M заданы

// void ShowNumber(int n68, int m68)
// {
//         if (n68<m68)
//         {
//             ShowNumber(n68 + 1, m68);
//         }
//         else 
//         {
//             if(n68 > m68) ShowNumber(n68 - 1, m68);
//         }                              
//         Console.Write(" "+ n68);
// }
// ShowNumber(-23, 15);
// System.Console.WriteLine();

// 69. Найти сумму элементов от M до N, N и M заданы
// System.Console.WriteLine();
// System.Console.WriteLine("69. Найти сумму элементов от M до N, N и M заданы");
// int sum =-1;
// void SumOfElements(int n68, int m68)
// {
        
//         if (n68<m68)
//         {
//             sum = sum+n68;
//             SumOfElements(n68 + 1, m68);
//         }
//         else 
//         {
//             if(n68 > m68) 
//             {
//               sum = sum+n68;
//               SumOfElements(n68 - 1, m68);
//             }
//         }                            
//         Console.Write($"{n68} ");
// }
// SumOfElements(3, -1);
// Console.Write("SumOfElements = " + sum);
// 70. Найти сумму цифр числа
// 71. Написать программу вычисления функции Аккермана
// 72. Написать программу возведения числа А в целую стень B
double x;
int y;
Input(out x, out y);
PrintResult(x, y, Grade(x, y));
void Input(out double n, out int m)
{
    System.Console.WriteLine("Введите число:  ");
    n = double.Parse(Console.ReadLine());
    System.Console.WriteLine("Введите целую степень числа:  ");
    m = int.Parse(Console.ReadLine());
}
double Grade(double a, int b)
{
    if (b == 0) return 1;
    if (b == 1) return a;
    else return a * Grade(a, b - 1);
}
void PrintResult(double a, int b, double c)
{
    System.Console.WriteLine($"Результат возведения числа {a} в степень {b} равен {c:F1}.");
}
// 73. Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. Первые два элемента последовательности задаются пользователем
double a, b;
int c;

Input(out a, out b, out c);
System.Console.WriteLine();
System.Console.Write($"{a} |{b} |");
for (int i = 3; i <= c; i++)
{
    System.Console.Write($"{(Fibonacci(i-2)*a + Fibonacci(i-1)*b):F1} |");
}

void Input(out double n, out double m, out int s)
{
    System.Console.WriteLine("Введите первое число последовательности:  ");
    n = double.Parse(Console.ReadLine());

    System.Console.WriteLine("Введите второе число последовательности:  ");
    m = double.Parse(Console.ReadLine());

    System.Console.WriteLine("Введите количество чисел последовательности:  ");
    s = int.Parse(Console.ReadLine());
}

double Fibonacci(int n)
 {
     if(n == 1 || n == 2) return 1;
     else return Fibonacci(n-1) + Fibonacci(n-2);
 }
 
// 74. В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита