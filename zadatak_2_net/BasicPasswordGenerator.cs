using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zadatak_2_net
{
    class BasicPasswordGenerator : PasswordGenerator
    {
        public override string generatePassword(int size)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, size)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
