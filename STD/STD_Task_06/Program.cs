using System;
using System.Collections.Generic;


namespace zd5
{
    class Program
    {
        static List<string> fio = new List<string>();
        static List<string> position = new List<string>();

        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1) Добавить досье");
                Console.WriteLine("2) Вывести все досье");
                Console.WriteLine("3) Удалить досье");
                Console.WriteLine("4) Поиск по фамилии");
                Console.WriteLine("5) Выход");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddDossier();
                        break;
                    case 2:
                        PrintDossiers();
                        break;
                    case 3:
                        RemoveDossier();
                        break;
                    case 4:
                        SearchByLastName();
                        break;
                    case 5:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Неверный выбор");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void AddDossier()
        {
            Console.WriteLine("Введите ФИО:");
            string name = Console.ReadLine();
            fio.Add(name);

            Console.WriteLine("Введите должность:");
            string pos = Console.ReadLine();
            position.Add(pos);
        }

        static void PrintDossiers()
        {
            for (int i = 0; i < fio.Count; i++)
            {
                Console.WriteLine($"{i + 1}) {fio[i]} - {position[i]}");
            }
        }

        static void RemoveDossier()
        {
            Console.WriteLine("Введите номер досье для удаления:");
            int index = int.Parse(Console.ReadLine()) - 1;
            fio.RemoveAt(index);
            position.RemoveAt(index);
        }

        static void SearchByLastName()
        {
            Console.WriteLine("Введите фамилию для поиска:");
            string lastName = Console.ReadLine();

            for (int i = 0; i < fio.Count; i++)
            {
                if (fio[i].Split(' ')[0] == lastName)
                {
                    Console.WriteLine($"{i + 1}) {fio[i]} - {position[i]}");
                }
            }
        }
    }
}
