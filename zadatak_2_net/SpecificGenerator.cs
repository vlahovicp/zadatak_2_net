using System;
using System.Collections.Generic;
using System.Text;

namespace zadatak_2_net
{
    internal class SpecificGenerator : PasswordGenerator
    {
        public override string generatePassword(int size)
        {
            StringBuilder password = new StringBuilder();

            for (int i = 0; i < size; i++)
            {
                char character;
                do
                {
                    character = this.getRandomCharacter();
                } while (character < 'a' || character > 'z');
                password.Append(character);
            }
            return password.ToString();
        }
    }
}
