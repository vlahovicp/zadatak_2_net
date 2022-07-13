using System;
using System.Collections.Generic;
using System.Text;

namespace zadatak_2_net
{
     class SpecificGenerator : PasswordGenerator
    {
        public override string generatePassword(int size)
        {
            int Counter = 0;
            const string chars = "abcdefghijklmnopqrstuvwxyz";
            string password = null;

            do
            {
                var RandomChar = getRandomCharacter();

                if (chars.Contains(RandomChar))
                {
                    password += RandomChar;
                    Counter++;
                }
            } while (Counter < size);

            return password;
        }
    }
}
