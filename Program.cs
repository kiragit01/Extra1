using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1 рисунок

            //Console.Write("a = ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("b = ");
            //int b = int.Parse(Console.ReadLine());
            //while(a <= b) 
            //{
            //    for(int i = 0; i < a; i++)
            //    {
            //        Console.Write(a + " ");
            //    }
            //    Console.WriteLine();
            //    a++;
            //}


            //2 рисунок


            //int a = int.Parse(Console.ReadLine());
            //int half, count;
            //half = a;
            //count = a - 1;
            //for (int j = 0; j < a; j++)
            //{
            //    for (int i = 0; i < half; i++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int i = 0; i < a - count; i++)
            //    {
            //        Console.Write("#");
            //    }
            //    count -= 2;
            //    half--;
            //    Console.WriteLine();
            //}



            //3 рисунок


            //int a = int.Parse(Console.ReadLine());
            //int half = a;
            //for (int j = 0; j < a; j++)
            //{
            //    for (int i = 0; i < half; i++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int i = 0; i < a; i++)
            //    {
            //        Console.Write("#");
            //    }
            //    half--;
            //    Console.WriteLine();
            //}


            //4 рисунок


            //int a = int.Parse(Console.ReadLine());
            //int half, count;
            //half = a;
            //count = a - 1;
            //for (int j = 0; j < a; j++)
            //{
            //    for (int i = 0; i < half; i++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int i = 0; i < a - count; i++)
            //    {
            //        Console.Write("#");
            //    }
            //    count -= 2;
            //    half--;
            //    Console.WriteLine();
            //}
            //for (int j = a; j >= 0; j--)
            //{
            //    for (int i = 0; i < half; i++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int i = 0; i < a - count; i++)
            //    {
            //        Console.Write("#");
            //    }
            //    count += 2;
            //    half++;
            //    Console.WriteLine();
            //}


            //5 рисунок


            //int a = int.Parse(Console.ReadLine());
            //int half, count;
            //half = 0;
            //count = a;
            //for (int j = 0; j < a; j++)
            //{
            //    for (int i = 0; i < half; i++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int i = 0; i < count; i++)
            //    {
            //        Console.Write("#");
            //    }
            //    half++;
            //    count -= 1;
            //    Console.WriteLine();
            //}








            //1. Число Армстронга – такое число из К цифр, для которого сумма К-х степеней его цифр равна самому числу.
            //Например, 153=13+53+33. Найти все числа Армстронга из трех цифр. Ответ: 153, 370, 371, 407.

            //for (int i = 100; i < 1000; i++)
            //    if(Math.Pow(i % 10, 3) + Math.Pow(i / 10 % 10, 3) + Math.Pow(i / 100, 3) == i)
            //        Console.WriteLine(i);



            //2. Четырехзначное число считается счастливым, если сумма его первых двух цифр равна сумме последних двух цифр.
            //По другой версии, счастливым является число, в котором сумма двузначных чисел первой и второй половины равна 100.
            //Найти все 4-значные числа, счастливые одновременно и в том, и в другом смысле. Ответ: 5050.

            //for (int i = 1000; i < 10000; i++)
            //    if (i / 1000 + i / 100 % 10 == i % 10 + i / 10 % 10 && i / 100 + i % 100 == 100) 
            //        Console.WriteLine(i);



            //3. У «счастливых» шестизначных билетов сумма первых трех цифр равна сумме последних трех цифр.
            //Сколько их? Ответ: 55252.

            //int a = 0;
            //for (int i = 100000; i < 1000000; i++)
            //    if (i / 100000 + i / 10000 % 10 + i / 1000 % 10 == i % 10 + i / 10 % 10 + i / 100 % 10)
            //        a++;
            //Console.WriteLine(a);



            //4.	Натуральное число называется совершенным, если оно равно сумме своих делителей,
            //включая 1 и, естественно, исключая это самое число.
            //Например, совершенным является число 6 ( 6 1 2 3 ). Найти все совершенные числа, меньшие 100 000.

            //int a;
            //for (int i = 1; i < 100000; i++)
            //{
            //    a = 0;
            //    for (int j = 1; j < i; j++)
            //        if(i % j == 0)
            //            a += j;
            //    if(i  == a)
            //        Console.WriteLine(i);
            //}



            //5. В некоторой стране используются денежные купюры достоинством в 1, 2, 4, 8, 16, 32 и 64.
            //Дано натуральное число n. Как наименьшим количеством таких денежных купюр можно выплатить
            //суммы n, n 1, ..., n 10 (указать количество каждой из используемых для выплаты купюр)?
            //Предполагается, что имеется достаточно большое количество купюр всех достоинств.

            int n = int.Parse(Console.ReadLine());
            int count = 0, t = 64;
            while (n >= 0)
            {
                while(n - t >= 0)
                {
                    count++;
                    n -= t;
                }
                Console.WriteLine($"{t} = {count}");
                count = 0;
                t /= 2;
            }










            Console.ReadKey();
        }
    }
}
