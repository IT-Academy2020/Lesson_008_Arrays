using System;

// Масиви (одновимірний масив).

namespace Arrays
{
    class Program
    {
        static void Main()
        {
            // На 14 рядку створюємо масив цілочисельних елементів з іменем array розмірністю в 5 елементів
            // в блоці ініціалізатора заповнюємо його значеннями 1,2,3,4,5
            
            int[] array = new int[5] { 1, 2, 3, 4, 5 };

            // Вивід на екран значень елементів масиву.
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
