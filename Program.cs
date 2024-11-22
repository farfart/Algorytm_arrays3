/*
 *Оголосити два масиви. Реалізувати читання (введення даних з клавіатури) з екрану обох масивів
 *через функцію читання. 
 *Вивести початкові масиви на екран через окрему функцію 
 *(кожен масив виводиться окремим викликом функції).
Реалізувати такі дії над масивами через окремі функції:
1. Обчислити суму масивів та зберегти результат у третьому масиві, який виводиться на екран через функцію виводу.
2. Обчислити кількість парних елементів у першому та другому масивах. Вивести результат на екран.
3. Всі від'ємні елементи замінити 0 у першому масиві. Вивести оновлений масив на екран.
4. Всі числа, що закінчуються на 5 поділити на 5 у другому масиві. Вивести оновлений масив на екран.
Побудувати блок-схему для всіх блоків програми.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorytm_array_laba3
{
    internal class Program
    {
        /* void Matrix(double d, int a, int b)
         {
             for (int i = 0; i < a; i++)
             {
                 for (int j = 0; j < b; j++)
                     d[i][j] = 0;
             }

         }*/



        // виводить(друкує )на екран уведені елементи масиву
        static void Print(double[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine();
        }

        // записує (читає) уведені елементи масиву 
        static void Read(double[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] =Convert.ToDouble(Console.ReadLine());
            }

        }

        // Фукція суми двох масивів 
        static double[] Sum(double[] Arr1, double[] Arr2)
        {

            double[] Arr3 = new double[Arr1.Length < Arr2.Length ? Arr2.Length : Arr1.Length]; //масив 3 буде мати таку ж розмір, як і масив який отримаємо у результаті умови 
            int c = Arr1.Length < Arr2.Length ? Arr1.Length : Arr2.Length; // "с" надамо величину масиву який отримаємо у результаті умови  
            bool n = false;
            for (int i = 0; i < c; i++)
            {
                if (!n) //!n (n==false)
                {
                    Arr3[i] = Arr1[i] + Arr2[i];

                    if (Arr1.Length != Arr2.Length && i == c - 1 && !n)
                    {
                        c += Math.Abs(Arr1.Length - Arr2.Length); //значення с + модульну різницю 
                        n = true;

                    }
                }
                else
                {
                    if (Arr1.Length < Arr2.Length)
                        Arr3[i] = Arr2[i];
                    else
                    {
                        Arr3[i] = Arr1[i];

                    }

                }

            }
            return Arr3;
        }
        // Обчислення парних елементів 
        static double CountEvenNumbers(double[] arr)
        {
            int count = 0;
            foreach (int num in arr)
            {
                if (num % 2 == 0) // Перевірка на парність
                {
                    count++;
                }
            }
            return count;
        }


        // Всі від'ємні елементи замінює на 0 у першому масиві
        static void change1(double[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    arr[i] = 0;
                }
            }
        }

        // Всі елементи які закінчуються на 5 / на 5 у другому масиві
        static void change2(double[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]% 10 ==5) // дивимось на останю цифру числа 
                {
                    arr[i]/=5;
                }

            }
        }

       

        static void Main(string[] args)
       {
            Console.OutputEncoding = Encoding.UTF8;

            int size = 0;
            Console.WriteLine("Введіть розмірність масиву 1:");
            size = Convert.ToInt32(Console.ReadLine());
            double[] Arr1 = new double[size];
            Console.WriteLine("Введіть розмірність масиву 2:");
            size = Convert.ToInt32(Console.ReadLine());
            double[] Arr2 = new double[size];

            Console.WriteLine("Введіть елементи масиву 1:");
            Read(Arr1);
            Console.WriteLine("Введіть елементи масиву 2:");
            Read(Arr2);

            Console.WriteLine("Масив 1:");
            Print(Arr1);
            Console.WriteLine("Масив 2:");
            Print(Arr2);

            double[] Arr3 = Sum(Arr1, Arr2);

            Console.WriteLine("№1:");
            Console.WriteLine("Сума 1 та 2 масивів: ");
            Print(Arr3);

            double evenCount1 = CountEvenNumbers(Arr1);
            double evenCount2 = CountEvenNumbers(Arr2);

            Console.WriteLine("№2:");
            Console.WriteLine($"Кількість парних елементів у першому масиві: {evenCount1}");
            Console.WriteLine($"Кількість парних елементів у пдругому масиві: {evenCount2}");

            Console.WriteLine("№3:");
            Console.WriteLine("Всі від'ємні елементи у першому масиві замінюємо на 0:");
            change1(Arr1);

            Console.WriteLine("№4:");
            Console.WriteLine("Всі елементи другого масива які закінчуються на 5, ділимо на 5:");
            change2(Arr2);

            Console.ReadKey();
        }
    }
}
