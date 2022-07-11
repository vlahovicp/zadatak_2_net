﻿using System;
using System.Collections.Generic;

namespace zadatak_2_net
{
    class Program
    {
        static void Main(string[] args)
        {
            PasswordGenerator passwordGenerator = new BasicPasswordGenerator();

            var passwords = new List<string>();

            for (int i = 0; i < 10; i++)
            {
                passwords.Add(passwordGenerator.generatePassword(10));
            }

            passwords.ForEach(delegate (string password)
            {
                Console.WriteLine(password);
            });
        }
    }
}
