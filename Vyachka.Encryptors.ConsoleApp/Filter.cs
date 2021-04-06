using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vyachka.Encryptors
{
    public static class Filter
    {
        public static string FilterText(string msg, string language)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < msg.Length; i++)
            {
                if (IsCorrectChar(msg[i], language))
                {
                    result.Append(msg[i]);
                }
            }
            return result.ToString();
        }

        private static bool IsCorrectChar(char c, string language)
        {
            bool result = false;
            if (language.Equals("eng"))
                result = ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'));
            else if (language.Equals("rus"))
                result = (((c >= 'А' && c <= 'Я') || c == 'Ё') || ((c >= 'а' && c <= 'я') || c == 'ё'));
            return result;
        }
    }
}
