// <copyright file="Program.cs" company="My Company Marina">
// Copyright (c) 2021 All Rights Reserved
// </copyright>
using System;
using System.Collections.Generic;
using System.Threading;

namespace ItogovProject12
{
    /// <summary>
    /// Класс Program
    /// </summary>
    public class Program
    {
        /// <summary>
        /// метод Main
        /// </summary>
        public static void Main()
        {
            List<User> spisok = new List<User> { new User("Mai", "Маша", true), new User("Sasha", "Саша", false), new User("Pit", "Петя", false) };

            foreach (var item in spisok)
            {
                Console.WriteLine($"Здравствуйте, {item.Name}");
                if (!item.IsPremium)
                {
                    ShowAds();
                }
            }
        }

        /// <summary>
        /// метод вывода рекламы
        /// </summary>
        public static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            Thread.Sleep(3000);
        }
    }
}
