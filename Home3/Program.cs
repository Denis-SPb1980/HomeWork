using System;
using System.Runtime.Intrinsics.X86;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task0();
            Task1();
            Task2();
            Task3();
            Task4();
            Task5();
        }

        //0.Создайте массив целых чисел.Напишете программу, которая выводит сообщение о том, входит ли заданное число в массив или нет.  Пусть число для поиска задается с консоли.
        public static void Task0()
        {
            Random random = new Random();
            int[] array = new int[5]; // задаем массив

            Console.WriteLine("Enter a number to check:");
            int inputNumber = int.Parse(Console.ReadLine()); // запрашиваем у пользователя число для проверки

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 10);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            bool found = false;
            int num;

            for (int i = 0; i < array.Length; i++)
            {
                num = array[i];
                if (num == inputNumber)
                {
                    found = true;
                    break;
                }
            }
            if (found == true)
                Console.WriteLine("Number " + inputNumber + " included in the array.");
            else
                Console.WriteLine("Number " + inputNumber + " not included in the array.");
        }

        //1. Создайте массив целых чисел. Удалите все вхождения заданного числа из массива.  
        //Пусть число задается с консоли.Если такого числа нет - выведите сообщения об этом.
        //В результате должен быть новый массив без указанного числа.  

        public static void Task1()
        {
            // Создаем массив целых чисел
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.Write("Enter a number to delete from the array: ");
            int inputNumber = int.Parse(Console.ReadLine());

            // Удаляем все вхождения заданного числа из массива
            int[] newNums = nums.Where(num => num != inputNumber).ToArray();

            if (newNums.Length == nums.Length)
            {
                Console.WriteLine("The number was not found in the array");
            }
            else
            {
                Console.WriteLine("New array:");
                foreach (int num in newNums)
                {
                    Console.Write(num + " ");
                }
            }
        }

        // 2. Создайте и заполните массив случайным числами и выведете максимальное, минимальное и среднее значение.
        //Для генерации случайного числа используйте метод Random(). Пусть будет возможность создавать массив произвольного размера.Пусть размер массива вводится с консоли.  
        public static void Task2()
        {
            Console.WriteLine("Please enter the size of the array: ");
            int inputNumber = int.Parse(Console.ReadLine()); // запрашиваем у пользователя размер массива
            Random random = new Random();
            int[] array = new int[inputNumber]; // задаем размер массива

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 10);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            double average = 0;
            for (int i = 0; i < array.Length; i++)
            {
                average += array[i];
            }

            Console.WriteLine("Maximum array number: " + max);
            Console.WriteLine("Minimum array number : " + min);
            Console.WriteLine("Average array number : " + average / array.Length);
        }


        // 3.Создайте 2 массива из 5 чисел.
        //Выведите массивы на консоль в двух отдельных строках.
        //Посчитайте среднее арифметическое элементов каждого массива и сообщите, для какого из массивов это значение оказалось больше
        //(либо сообщите, что их средние арифметические равны).  
        public static void Task3()
        {
            int[] array = { 2, 7, 7, 2, 6 }; // задаем массив
            int[] array2 = { 1, 4, 9, 8, 3 }; // задаем второй массив

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();

            for (int j = 0; j < array.Length; j++)
            {
                Console.Write(array2[j] + " ");
            }

            Console.WriteLine();

            double average1 = array.Average();
            double average2 = array2.Average();

            if (average1 > average2)
            {
                Console.WriteLine("The average value of the first array is greater than");
            }
            else if (average1 < average2)
            {
                Console.WriteLine("The average value of the second array is greater");
            }
            else
            {
                Console.WriteLine("The average value of the array elements are equal to");
            }
        }

        //4. Создайте массив и заполните массив.
        //Выведите массив на экран в строку.
        //Замените каждый элемент с нечётным индексом на ноль.
        //Снова выведете массив на экран на отдельной строке. 

        public static void Task4()
        {
            int[] array = { 1, 5, 7, 2, 6 }; // задаем массив

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 != 0)
                {
                    array[i] = 0;
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        //7.Создайте двумерный массив целых чисел.Выведите на консоль сумму всех элементов массива

        public static void Task5()
        {
            int[,] array = { { 1, 5, 7, 2, 6 }, { 2, 3, 7, 9, 5 } }; // создаем двумерный массив

            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                    sum += array[i, j];
                }
                Console.WriteLine();
            }

            Console.WriteLine("Sum of all array elements: " + sum);
        }
    }
}
