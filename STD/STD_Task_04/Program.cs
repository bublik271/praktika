using System;

namespace task12
{
    class Program
    {
        static void Main(string[] args)
        {
            int userHealth = 600;
            int bossHealth = 1000;

            bool RahamonIsTrue = false;
            bool huganzakuraIsTrue = false;

            string command = "".ToLower();

            Console.WriteLine("Вы, теневой маг. Вы должны убить босса, используя 5 разных заклинаний. \r\n" +
                "Для ознакомления со списком заклинаний наберите команду - ''список команд''. Учтите, что за \r\nкаждое использованное заклинание вы будите получать урон. " +
                "Игра закончится, когда кто нибудь умрет.\r\nУдачи! ");

            while (userHealth > 0 && bossHealth > 0)
            {
                Console.Write("Введите команду:");
                command = Console.ReadLine();
                if (command == "рашамон")
                {
                    bossHealth -= 150;
                    userHealth -= 60;
                    Console.WriteLine("Вы нанесли 150 урона и получили 60 урона. Ваше здоровье {0}. Здоровье босса {1}", userHealth, bossHealth);
                    RahamonIsTrue = true;
                }

                else if (command == "хуганзакура")
                {
                    if (RahamonIsTrue == false)
                    {
                        userHealth -= 100;
                        Console.WriteLine("Для начала нужно призвать теневого духа! (Команда Рашамон). Ваше заклинание не нанесло урона! " +
                            "Вы получили 50 урона. Ваше здоровье {0}. Здоровье босса {1}", userHealth, bossHealth);
                    }
                    else
                    {
                        bossHealth -= 100;
                        userHealth -= 50;
                        Console.WriteLine("Ваше заклинание нанесло 100 урона. Вы получили 50 урона. Ваше здоровье {0}. Здоровье босса {1}", userHealth, bossHealth);
                        RahamonIsTrue = false;
                        huganzakuraIsTrue = true;
                    }
                }

                else if (command == "межпространственный разлом")
                {
                    userHealth += 80;
                    Console.WriteLine("Вы спрятались в межпростравенном разломе и не получили урона. Вы восстановили 80 единиц здоровья. Ваше здоровье {0}. Здоровье босса {1}", userHealth, bossHealth);
                }
                else if (command == "ветряной сглаз")
                {
                    if (huganzakuraIsTrue == false)
                    {
                        userHealth -= 100;
                        Console.WriteLine("Для начала нужно использовать хуганзакуру! (Команда Хуганзакура). Ваше заклинание не нанесло урона! " +
                            "Вы получили 100 урона. Ваше здоровье {0}. Здоровье босса {1}", userHealth, bossHealth);
                    }
                    else
                    {
                        bossHealth -= 100;
                        userHealth -= 50;
                        Console.WriteLine(" Ваше заклинание нанесло 100 урона. Вы получили 50 урона. Ваше здоровье {0}. Здоровье босса {1}", userHealth, bossHealth);
                        huganzakuraIsTrue = false;
                    }
                }
                else if (command == "астралстеп")
                {
                    if (huganzakuraIsTrue == false)
                    {
                        userHealth -= 100;
                        Console.WriteLine("Для начала нужно использовать хуганзакуру! (Команда Хуганзакура). Ваше заклинание не нанесло урона! " +
                            "Вы получили 100 урона. Ваше здоровье {0}. Здоровье босса {1}", userHealth, bossHealth);
                    }
                    else
                    {
                        bossHealth -= 100;
                        userHealth -= 50;
                        Console.WriteLine(" Ваше заклинание нанесло 100 урона. Вы получили 50 урона. Ваше здоровье {0}. Здоровье босса {1}", userHealth, bossHealth);
                        huganzakuraIsTrue = false;
                    }
                }

                else if (command == "список команд")
                {
                    Console.WriteLine("Заклинание Рашамон. Наносит 100 урона, вы получаете 50 урона. \r\n" +
                        "Заклинание Хуганзакура. Возможно только после использования заклинания Рашамон. Если вы все сделаете правильно, \r\nто босс получит 100 урона, а вы получите 50 урона. \r\n" +
                        "Заклинание Ветряной сглаз возможно только после применения заклинания Хуганзакура. \r\nЕсли вы выполните условия применения заклинания босс получит 100 урона," +
                        " а вы получите 50 урона. \r\n" +
                        "Заклинание астралстеп возможно только после применения заклинания Хуганзакура. \r\nЕсли вы выполните условие условия применения заклинания босс получит 100 урона," +
                        "а вы получите 50 урона. \r\n" +
                        "Заклинание Межпространственный разлом. Данное заклинание не наносит урон, но спасает вас от атак босс \r\n(то есть вы не получите урон). Также данное заклинание восстановит вам 65 единиц здоровья.");
                }

                else
                {
                    Console.WriteLine("Заклинание не опознано. Попробуйте еще раз");
                }

            }

            if (userHealth <= 0)
            {
                Console.WriteLine("Вы погибли!");
            }
            else
            {
                Console.WriteLine("Вы победили!");
            }
            Console.WriteLine("Для выхода нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}