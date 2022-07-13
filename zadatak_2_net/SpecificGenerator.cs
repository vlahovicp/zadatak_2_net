using System;
using System.Collections.Generic;
using System.Text;

namespace zadatak_2_net
{
    class SpecificGenerator : PasswordGenerator
    {
        public override string generatePassword(int size)
        {
            StringBuilder rezultat = new StringBuilder();
            for (int i = 0; i < size; i++)
            {
                rezultat.Append(this.getRandomCharacter());
            }

            return rezultat.ToString().ToLowerInvariant();
        }
    }
}
