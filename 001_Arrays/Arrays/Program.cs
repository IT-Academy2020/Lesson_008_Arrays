using System;

// Масиви (одновимірний масив).

namespace Arrays
{
    class Program
    {
        static void Main()
        {

            // На 14 рядку створюємо масив цілочисельних елементів з ім'ям array розмірністю в 5 елементів

            int[] array = new int[5];

            // На 18 рядку елементу масиву array за індексом 0 присвоюємо значення 10

            array[0] = 10;
            array[1] = 20;
            array[2] = 30;
            array[3] = 40;
            array[4] = 50;

            // На 26 рядку виводимо на екран значення елемента масиву array за індексом 0

            Console.WriteLine(array[0]);
            Console.WriteLine(array[1]);
            Console.WriteLine(array[2]);
            Console.WriteLine(array[3]);
            Console.WriteLine(array[4]);

            // Delay.
            Console.ReadKey();
        }
    }
}
