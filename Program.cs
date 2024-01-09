using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите элементы массива через пробел:");
        string input = Console.ReadLine();
        string[] words = input.Split(' ');
        string[] result = FilterWords(words);

        Console.WriteLine("Исходный массив: [" + string.Join(", ", words) + "]");
        Console.WriteLine("Результат: [" + string.Join(", ", result) + "]");
        Console.ReadKey();
    }

    static string[] FilterWords(string[] words)
    {
        int count = 0;

        // Подсчитываем количество слов, удовлетворяющих условию
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length <= 3)
            {
                count++;
            }
        }

        // Создаем новый массив нужного размера
        string[] result = new string[count];
        int index = 0;

        // Заполняем новый массив подходящими словами
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length <= 3)
            {
                result[index] = words[i];
                index++;
            }
        }

        return result;
    }

}