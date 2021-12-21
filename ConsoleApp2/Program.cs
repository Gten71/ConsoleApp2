using System;
using System.Linq;

using System;

using System.Collections;

namespace gg

{

    sealed class Hockey_player
    {
        public static int counter = 0;
        public static int counter25 = 0;
        private static int general_age = 0;
        private string surname;
        private int age;
        private int quanity_games;
        private int missing_washers;
        public Hockey_player()
        {
            Console.Write("Введите фамилию хоккеиста: ");
            surname = Console.ReadLine();
            Console.Write("Введите возраст хоккеиста: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество игр хоккеиста: ");
            quanity_games = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество пропущенных шайб хоккеиста: ");
            missing_washers = Convert.ToInt32(Console.ReadLine());
            general_age += age;
            counter++;
            if (age > 25)
                counter25++;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Фамилия хоккеиста:{surname}\nВозраст хоккеиста: {age}\nКоличество игр хоккеиста: {quanity_games}\nКоличество пропущенных шайб хоккеиста: {missing_washers}");
        }
        public void PrintNeedInfo()

        {
            if (age > 25)
            {
                PrintInfo();
            }
        }
        public static void average_age()

        {
            if (counter != 0)
                Console.Write(general_age / counter);
            else
                Console.Write("Невозможно определить!");
        }
    }
    class Program
    {
        public static void Menu()
        {
            Console.WriteLine("\n1-Добавить хоккеиста в список\n2-Определить средний возраст всех хоккеистов\n3-Вывести сведения о хоккеистах, которым больше 25 лет\n0-Выход");
        }
        static void Main(string[] args)
        {
            ArrayList lst = new ArrayList();
            int choice;
        main:
            Menu();
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    lst.Add(new Hockey_player());
                    break;
                case 2:
                    Console.Write($"Средний возраст: ");
                    Hockey_player.average_age();
                    break;
                case 3:
                    if (Hockey_player.counter25 > 0)
                    {
                        for (int i = 0; i < lst.Count; i++)
                        {
                            if (lst[i] as Hockey_player != null)
                            {
                                Hockey_player buff = (Hockey_player)lst[i];
                                buff.PrintNeedInfo();
                            }
                        }
                    }
                    else
                        Console.WriteLine("Нет таких хоккеистов!");
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
            }
            goto main;
        }
    }
}


