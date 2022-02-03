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
int a = 1;
int b = 3;
int c = 3;

int max = a;
if(b> max) max=b;
if(c>max) max=c;

Console.WriteLine(max);

//  5. Написать программу вычисления значения функции y = f(a)
//  6. Выяснить является ли число чётным
//  7. Показать числа от -N до N
//  8. Показать четные числа от 1 до N
//  9. Показать последнюю цифру трёхзначного числа
// 10. Показать вторую цифру трёхзначного числа
// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
// 12. Удалить вторую цифру трёхзначного числа
// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.
// 14. Найти третью цифру числа или сообщить, что её нет
// Console.WriteLine("Hello, World!");
