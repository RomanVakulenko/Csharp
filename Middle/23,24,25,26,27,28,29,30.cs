// ## Почувствуй себя мидлом*
// 23. Показать таблицу квадратов чисел от 1 до N 
double N = new Random().Next(3, 7);
double count = 1;
System.Console.WriteLine("Число | Квадрат числа");
while (count < N + 1)
{
    if (count < N + 1)
    {
        double nPow2 = Math.Pow(count, 2);
        System.Console.WriteLine("   " + count + "  |       " + nPow2);
    }
    count++;
}
System.Console.WriteLine();

// 24. Найти кубы чисел от 1 до M
double M = new Random().Next(3, 7);
double count1 = 1;
System.Console.WriteLine("Число | Куб числа");
while (count1 < M + 1)
{
    if (count1 < M + 1)
    {
        double mPow3 = Math.Pow(count1, 3);
        System.Console.WriteLine("   " + count1 + "  |    " + mPow3);
    }
    count1++;
}
System.Console.WriteLine();

// 25. Найти сумму чисел от 1 до А
int A = new Random().Next(3, 7);
System.Console.WriteLine("Найти сумму рандомного числа А, равного " + A + ":");
int sum = 0;
for (int counter = 1; counter < A + 1; counter++)
{
    sum = sum + counter;
}
System.Console.WriteLine("Сумма от 1 до А = " + sum);
System.Console.WriteLine();

// 26. Возведите число X в натуральную степень Y, используя цикл
int X = new Random().Next(2, 5);
int Y = new Random().Next(2, 4);
int X1 = X;
System.Console.WriteLine("Возведите число X в натуральную степень Y, используя цикл. X = " + X + ", Y = " + Y);
for (int i = 1; i < Y; i++)
{
    X1 = X * X1;
}
System.Console.WriteLine("Число X в степени Y = " + X1);
System.Console.WriteLine();

// 27. Определить количество цифр в числе
int Z = new Random().Next(1, 100000);
System.Console.WriteLine("Определить количество цифр в числе Z = " + Z + ":");
int amountOfLoops = 0;
do 
{
    Z=Z/10;
    amountOfLoops++;
}
while (Z>0);
System.Console.WriteLine("Количество цифр в числе Z = " + amountOfLoops);
System.Console.WriteLine();
// или перевести в string и получить Lenght string-а:

// 28. Подсчитать сумму цифр в числе
int S = new Random().Next(1, 1000);
System.Console.WriteLine("Подсчитать сумму цифр в числе S = " + S + ":");
int w1 = 0;
int w = 0;
do 
{
    w = S%10;   //находим остаток 
    w1 = w1+w;  //в суммирующую переменную добавляем отделенный остаток
    S = S/10;   // от S отделяем по 1 цифре
}
while (S>0);
System.Console.WriteLine("Cуммa цифр в числе S = " + w1);
System.Console.WriteLine();

// 29. Написать программу вычисления произведения чисел от 1 до N2
int N2 = new Random().Next(2, 7);
System.Console.WriteLine("Найти произведение чисел от 1 до N2, равного  " + N2 + ":");
int product = 1;
for (int counter = 2; counter < N2 + 1; counter++)
{
    product = product * counter;
}
System.Console.WriteLine("Произведение чисел от 1 до N2 = " + product);
System.Console.WriteLine();

// 30. Показать кубы чисел, заканчивающихся на четную цифру
double evenPower3 = new Random().Next(3, 10);
double counter1 = 2;
System.Console.WriteLine("Число | Куб четного числа");
double evenCounter1 = 0;

while (counter1 < evenPower3 + 1)
{
    if (counter1 < evenPower3 + 1 & evenCounter1%2==0)
    {
        double evenPow3 = Math.Pow(counter1, 3);
        System.Console.WriteLine("   " + counter1 + "  |    " + evenPow3);
    }
    counter1++;
    evenCounter1 = counter1;
}
System.Console.WriteLine();