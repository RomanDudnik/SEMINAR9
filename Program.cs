//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N
/*
void ShowNumbers(int n)
{
    if (n > 1) ShowNumbers (n - 1);
    Console.Write(n + " ");
}

ShowNumbers(5);   //(3) -> 3>1? y-> (3-1 =2) -> 2>1? y-> (2-1 = 1) 1>1? n-> CW 1 2 3  

// Обратная последовательность ( от N до 1)
void ShowNumbers(int n)
{
    Console.Write(n + " ");
    if (n > 1) ShowNumbers (n - 1);
 }

ShowNumbers(5);   //(3) -> CW 3 3>1? y-> (3-1 =2) CW 2 -> 2>1? y-> (2-1 = 1) CW 1>1?n 
*/

//Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

/*
int SumDigits (int num)
{
    if (num < 0) num*= (-1);    //для работы отрицательных чисел (резервная переменная)
    if (num > 0) return SumDigits(num / 10) + num % 10;
    else return 0;
}
//как через такой цикл:
// while (num > 0)
// number %10
// num/ 10
Console.WriteLine("input num: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = SumDigits(number);
Console.WriteLine (result);
*/

//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// N < M, N = M, M < N

// N = 3, M = 9 -> 3 4 5 6 7 8 9 
// N = 8, M = 4 -> 4 5 6 7 8  
/*
void ShowNumberMN(int n, int m)
{
    if (Math.Max(n,m) != Math.Min(n,m)) ShowNumberMN(Math.Max(n,m) - 1, Math.Min(n,m));
    Console.Write($"{Math.Max(n,m)} ");
//Math.Max(n,m) Math.Min(n,m)
}
ShowNumberMN(8, 5);
*/

//Напишите программу, которая на вход принимает два числа A и B, 
//и возводит число А в степень B с помощью рекурсии.
/*
int APowB (int a, int b)
{
    if (b > 0) return APowB (a, b - 1) *a;
    // 2^3: a=2, b=3; 3>0 y (2,2) 2>0 y (2,1) 1>0 y (2,0) 0>0 n ->1
    if (b < 0) return APowB (a, b + 1) /a;   // *(1/a)
    return 1;
}

double res = APowB(2, 5);
Console.WriteLine(res);
*/