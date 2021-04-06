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
            bool result;
            switch(language)
            {
                case "eng":
                    result = ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'));
                    break;

                case "rus":
                    result = (((c >= 'А' && c <= 'Я') || c == 'Ё') || ((c >= 'а' && c <= 'я') || c == 'ё'));
                    break;

                case "num":
                    result = (c >= '0' && c <= '9');
                    break;

                default:
                    return false;
            }

            return result;
        }
    }
}
