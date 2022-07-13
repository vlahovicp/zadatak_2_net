using System;
using System.Collections.Generic;
using System.Text;

namespace zadatak_2_net
{
    class BasicPasswordGenerator : PasswordGenerator
    {
        public override string generatePassword(int size)
        {
            StringBuilder password = new StringBuilder();
            
            for (int i = 0; i < size; i++)
            {
                password.Append(this.getRandomCharacter());
            }
            return password.ToString();
        }
    }
}
