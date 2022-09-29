// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int sum (int m, int n)
// {
//   if ( m == n )
//   return m;
//   return sum(m, n-1) + n;   
// }
// Console.Write("Введите знчение  M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите знчение  N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.Write("Сумма натуральных элементов в промежутке от M до N равна: " + sum(M,N));

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int aker (int m, int n)
{
  if(m == 0)
  return n+1;
  if ( m > 0 && n == 0)
  return aker(m-1, 1);
  if ( m > 0 && n > 0)
  return aker(m-1, aker(m, n -1));
  return aker(n,m);
}

Console.Write("Введите знчение  M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите знчение  N: ");
int N = Convert.ToInt32(Console.ReadLine());
while(M < 0 || N < 0)
{
  Console.WriteLine("Значения M и N не могут быть отрицательными!");
  Console.Write("Введите знчение  M: ");
  M = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите знчение  N: ");
  N = Convert.ToInt32(Console.ReadLine());
}
Console.Write(aker(M,N));