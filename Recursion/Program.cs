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

void ShowNumber(int n68, int m68)
{
        if (n68<m68)
        {
            ShowNumber(n68 + 1, m68);
        }
        else 
        {
            if(n68 > m68) ShowNumber(n68 - 1, m68);
        }                              
        Console.Write(" "+ n68);
}
ShowNumber(-23, 15);
System.Console.WriteLine();

// 69. Найти сумму элементов от M до N, N и M заданы
System.Console.WriteLine();
System.Console.WriteLine("69. Найти сумму элементов от M до N, N и M заданы");
int sum =-1;
void SumOfElements(int n68, int m68)
{
        
        if (n68<m68)
        {
            sum = sum+n68;
            SumOfElements(n68 + 1, m68);
        }
        else 
        {
            if(n68 > m68) 
            {
              sum = sum+n68;
              SumOfElements(n68 - 1, m68);
            }
        }                            
        Console.Write($"{n68} ");
}
SumOfElements(3, -1);
Console.Write("SumOfElements = " + sum);
// 70. Найти сумму цифр числа
// 71. Написать программу вычисления функции Аккермана
// 72. Написать программу возведения числа А в целую стень B
// 73. Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. Первые два элемента последовательности задаются пользователем
// 74. В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита