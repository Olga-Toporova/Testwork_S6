/* Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний 
элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21 */

class Program
{
    static void WriteArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++) Console.Write(array[i] + " ");
        Console.Write($" -> ");
        int comp = 0;
        int j = array.Length - 1;
        if (array.Length % 2 == 0)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                comp = array[i] * array[j];
                j--;
                Console.Write(comp + " ");
            }
        }
        else
        {
            for (int i = 0; i < array.Length / 2 + 1; i++)
            {
                if (i < array.Length / 2)
                {
                    comp = array[i] * array[j];
                    j--;
                    Console.Write(comp + " ");
                }
                else
                {
                    Console.Write(array[i]);
                }
            }
        }

        Console.WriteLine(" ");
    }

    static void Main(string[] args)
    {
        Console.Write("Введите размер массива: ");
        int N = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[N];
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Введите значение: ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        WriteArray(array);
    }
}