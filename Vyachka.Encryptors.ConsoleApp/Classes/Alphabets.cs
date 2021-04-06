using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vyachka.Encryptors
{
    public static class Alphabets
    {
        public static char[] rusAlphabet = {'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З',
            'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч',
            'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я'};

        public static char[] engAlphabet = {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I',
            'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};

        public static int IndexOf(string language, char c)
        {
            c = char.ToUpper(c);
            if (language.Equals("rus"))
            {
                for (int i = 0; i < rusAlphabet.Length; i++)
                {
                    if (c == rusAlphabet[i])
                        return i;
                }
            }
            else if (language.Equals("eng"))
            {
                for (int i = 0; i < engAlphabet.Length; i++)
                {
                    if (c == engAlphabet[i])
                        return i;
                }
            }

            return -1;
        }
    }
}
