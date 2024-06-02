using System;

class Program
{
    static void Main()
    {
        // Ввод массива строк с клавиатуры
        Console.WriteLine("Введите строки через запятую:");
        string input = Console.ReadLine();
        
        // Разделение введенной строки на массив строк
        string[] initialArray = input.Split(',');

        // Убираем лишние пробелы из строк массива
        for (int i = 0; i < initialArray.Length; i++)
        {
            initialArray[i] = initialArray[i].Trim();
        }

        // Выводим начальный массив
        Console.WriteLine("Начальный массив:");
        PrintArray(initialArray);

        // Формируем новый массив строк, длина которых <= 3
        string[] resultArray = FilterArray(initialArray);

        // Выводим результат
        Console.WriteLine("\nРезультат:");
        PrintArray(resultArray);
    }

    static string[] FilterArray(string[] array)
    {
        // Подсчитываем количество строк длиной <= 3
        int count = 0;
        foreach (string str in array)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }

        // Создаем новый массив для хранения отфильтрованных строк
        string[] result = new string[count];
        int index = 0;

        // Заполняем новый массив
        foreach (string str in array)
        {
            if (str.Length <= 3)
            {
                result[index] = str;
                index++;
            }
        }

        return result;
    }

    static void PrintArray(string[] array)
    {
        Console.Write("[");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
            if (i < array.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]");
    }
}

