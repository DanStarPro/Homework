using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleDictionary
{
    class Program
    {
        static string dictionaryFilePath = "dictionary.txt"; // Путь к файлу словаря
        static Dictionary<string, string> dictionary = new Dictionary<string, string>();

        static void Main(string[] args)
        {
            LoadDictionary(); // Загрузка словаря из файла

            while (true)
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1. Перевод слова");
                Console.WriteLine("2. Добавить новое слово");
                Console.WriteLine("3. Выход");

                Console.Write("Введите номер действия: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        TranslateWord();
                        break;
                    case "2":
                        AddWord();
                        break;
                    case "3":
                        SaveDictionary(); // Сохранение словаря в файл
                        Console.WriteLine("До свидания!");
                        return;
                    default:
                        Console.WriteLine("Неверный выбор.");
                        break;
                }
            }
        }

        static void TranslateWord()
        {
            Console.Write("Введите слово для перевода: ");
            string word = Console.ReadLine();

            if (dictionary.ContainsKey(word))
            {
                Console.WriteLine($"Перевод: {dictionary[word]}");
            }
            else
            {
                Console.WriteLine($"Слово '{word}' не найдено в словаре. Хотите добавить его? (y/n)");
                string answer = Console.ReadLine();
                if (answer.ToLower() == "y")
                {
                    AddWord(word);
                }
            }
        }

        static void AddWord(string word = null)
        {
            if (word == null)
            {
                Console.Write("Введите слово: ");
                word = Console.ReadLine();
            }

            Console.Write("Введите перевод: ");
            string translation = Console.ReadLine();

            dictionary.Add(word, translation);
            Console.WriteLine($"Слово '{word}' добавлено в словарь.");
        }

        static void LoadDictionary()
        {
            if (File.Exists(dictionaryFilePath))
            {
                string[] lines = File.ReadAllLines(dictionaryFilePath);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(':');
                    if (parts.Length == 2)
                    {
                        dictionary.Add(parts[0].Trim(), parts[1].Trim());
                    }
                }
            }
        }

        static void SaveDictionary()
        {
            List<string> lines = new List<string>();
            foreach (KeyValuePair<string, string> entry in dictionary)
            {
                lines.Add($"{entry.Key}:{entry.Value}");
            }

            File.WriteAllLines(dictionaryFilePath, lines);
        }
    }
}
