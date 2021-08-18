// <copyright file="User.cs" company="My Company Marina">
// Copyright (c) 2021 All Rights Reserved
// </copyright>
using System;
using System.Collections.Generic;
using System.Text;

namespace ItogovProject12
{
    /// <summary>
    /// Класс Пользователь
    /// </summary>
    public class User
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="User"/> class.
        /// </summary>
        /// <param name="login">Ввод логина пользоателя</param>
        /// <param name="name">Ввод имени пользователя</param>
        /// <param name="isPremium">Ввод наличия премиум-подписки пользоателя</param>
        public User(string login, string name, bool isPremium)
        {
            this.Login = login;
            this.Name = name;
            this.IsPremium = isPremium;
        }

        /// <summary>
        /// Gets or sets a value indicating whether поле для хранения логина
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether поле для хранения имени
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether поле для хранения наличия премиум-подписки
        /// </summary>
        public bool IsPremium { get; set; }
    }
}
