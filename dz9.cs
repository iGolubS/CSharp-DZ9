// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в
// промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

// int PrintNumbers(int start, int end)
// {
//     Console.Write($"{start} ");
//     if (start == end) return start;
//     return  PrintNumbers(start + 1, end);
// }

// Console.Clear();
// Console.Write("Введите M: ");
// int numberM=int.Parse(Console.ReadLine()!);
// Console.Write("Введите N: ");
// int numberN=int.Parse(Console.ReadLine()!);

// PrintNumbers(numberM,numberN);





// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в
// промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.Clear();
// int sum(int start, int end)
// {
//     if (start == end) return end;
//     return  end+sum(start,end-1);
// }

// Console.Clear();
// Console.Write("Введите M: ");
// int numberM=int.Parse(Console.ReadLine()!);
// Console.Write("Введите N: ");
// int numberN=int.Parse(Console.ReadLine()!);

// Console.WriteLine(sum(numberM,numberN));





// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

Console.Clear();
int Accerman(int m, int n)
{
    if(n == 0) return m+1;
    if(n > 0 && m == 0) return Accerman(1, n-1);
    return Accerman(Accerman(m-1, n),n-1);
}
Console.Write("Введите M: ");
int numberM=Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите N: ");
int numberN=Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine(Accerman(numberM,numberN));