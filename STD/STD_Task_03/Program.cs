using System;

namespace zd3
{

    class Program
    {
        static void Main(string[] args)
        {
            // Пароль для доступа к тайному сообщению
            string password = "mypassword";

            // Счетчик попыток ввода пароля
            int attempts = 0;

            while (true)
            {
                Console.Write("Введите пароль: ");
                string input = Console.ReadLine();

                if (input == password)
                {
                    Console.WriteLine("Пароль верный!");
                    Console.WriteLine("Секретное сообщение: ...");
                    break; // выходим из цикла, если пароль верный
                }
                else
                {
                    Console.WriteLine("Пароль неверный!");

                    attempts++;

                    if (attempts == 3)
                    {
                        Console.WriteLine("Вы ввели неверный пароль 3 раза. Программа завершена.");
                        break; // завершаем программу, если было 3 неверных попытки
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
