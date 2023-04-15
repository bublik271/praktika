using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите начальное количество золота:");
        int gold = int.Parse(Console.ReadLine());

        int price = 20;
        int crystalsBought = 0;

        while (true)
        {
            Console.WriteLine("Введите количество кристаллов, которое вы хотите купить (или введите 0, чтобы выйти из программы):");
            int crystalsToBuy = int.Parse(Console.ReadLine());

            if (crystalsToBuy == 0)
            {
                Console.WriteLine("Программа завершена.");
                break;
            }

            int crystalsAffordable = gold / price;

            if (crystalsToBuy <= crystalsAffordable)
            {
                crystalsBought += crystalsToBuy;
                gold -= price * crystalsToBuy;
                Console.WriteLine($"Вы купили {crystalsToBuy} кристаллов. У вас осталось {gold} золота и {crystalsBought} кристаллов в планах к продаже.");
            }
            else
            {
                Console.WriteLine($"Сделку невозможно совершить. У вас есть только {crystalsAffordable} кристаллов и {gold} золота.");
            }
        }
    }
}
