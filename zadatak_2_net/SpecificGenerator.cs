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
                char character = this.getRandomCharacter();

                if (character >= 'A' && character <= 'Z')
                    character = (char)(character + ('a' - 'A'));
                else if (character >= '0' && character <= '9')
                    character = (char)(character + ('a' - '0'));

                password.Append(character);
            }
            return password.ToString();
        }
    }
}
