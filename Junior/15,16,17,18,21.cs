// ## Почувствуй себя джуном*
// 15. Дано число. Проверить кратно ли оно 7 и 23

int a = new Random().Next(1000, 10000);
Console.WriteLine(a);
int b = 7, c = 23;
int d = b * c;

bool multiple(int a, int d)
{
    if (a % d == 0) return true;
    else return false;
}
multiple(a, d);   // запускаю метод, определяющий кратность

if (multiple(a, d) == true) Console.WriteLine(" - число кратное 7 и 23 - multiple in English");
else Console.WriteLine("число некратное 7 и 23");
Console.WriteLine();

// 16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным 

int q = new Random().Next(1, 8);
Console.WriteLine(q + " - это число, обозначающее день недели");
q--;
string[] weekDays = { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };

if (q == 5 ^ q == 6)
{
    Console.WriteLine("День недели - выходной, т.к.: " + weekDays[q]);
}
else
{
    Console.WriteLine("День недели - будний, т.к.: " + weekDays[q]);
}
Console.WriteLine();

// 17. По двум заданным числам проверять является ли одно квадратом другого
int w = new Random().Next(4, 50);
Console.WriteLine(w + " - это 1ое число");
int e = new Random().Next(1, 8);
Console.WriteLine(e + " - это 2ое число");

bool checkForMathPow(int w, int e)
{
    if (w == Math.Pow(e, 2)) return true;
    else return false;
}
if (checkForMathPow(w, e) == true) Console.WriteLine("Вывод: 1ое число является квадратом 2ого");
else Console.WriteLine("Вывод: 1ое число не является квадратом 2ого");
Console.WriteLine();

// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
// не(х или у) = не х и не у - логически проверил - истинно, a как решить его через консоль??

Console.Clear();

bool[] arrT = { true, false };
bool[] arrG = { true, false };
int number1 = 0;
int number2 = 0;
bool Checking = true;
for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
    {
        if (!(arrT[i] | arrG[j]) != !arrT[i] & !arrG[j])
        {
            Checking = false;
            break;
        }
        number1 = Convert.ToInt32(arrT[i]);
        number2 = Convert.ToInt32(arrG[j]);
        System.Console.WriteLine(number1);
        System.Console.WriteLine(number2);
        System.Console.WriteLine(Checking);
        System.Console.WriteLine();
    }
}
if (Checking = true) Console.WriteLine("Утверждение истинно");
else System.Console.WriteLine("Утверждение ложно");

// 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
// 20. Задать номер четверти, показать диапазоны для возможных координат
// 21. Программа проверяет пятизначное число на палиндромом.

int[] arr = { 5, 4, 3, 4, 5 };
Console.WriteLine(); // делаем пустую строку
Console.WriteLine(string.Join("", arr));

bool palindrome(int[] array)
{
    int i=0;
    if (array[0] == array[^1] & array[1] == array[^2]) return true;
    else if (array[i] == array[^(i+1)] & i< (array.Length/2))
    {
        i++; 
        return true;
    }
    else return false;
}
    
if (palindrome(arr) == true) Console.WriteLine("Введенное число является палиндромом");
else Console.WriteLine("Число - не палиндром");
Console.WriteLine();

// 22. Найти расстояние между точками в пространстве 2D/3D