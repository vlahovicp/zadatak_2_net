using System;
using System.Text;

namespace zadatak_2_net
{
    class SpecificPasswordGenerator : PasswordGenerator
    {
        public override string generatePassword(int size)
        {
            StringBuilder password = new StringBuilder();
            const string chars = "abcdefghijklmnopqrstuvwxyz";

            for (int i = 0; i < size;)
            {
                var RandomChar = getRandomCharacter();
                if (chars.Contains(RandomChar) && !Char.IsDigit(RandomChar))
                {
                    password.Append(RandomChar);
                    i++;
                }
            }

            return password.ToString();
        }
    }
}
