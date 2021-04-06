using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vyachka.Encryptors
{
    public static class KeyChecker
    {
        public static bool CheckKey(string key, string mode)
        {
            switch (mode)
            {
                case "eng":
                case "rus":
                    if (key.Length == 0)
                    {
                        return false;
                    }
                    
                    for (int i = 0; i < key.Length; i++)
                    {
                        if (Alphabets.IndexOf(mode, key[i]) == -1)
                            return false;
                    }

                    return true;

                case "num":
                    try
                    {
                        return (int.Parse(key) > 0);
                    }
                    catch (FormatException)
                    {
                        return false;
                    }
            }

            return false;
        }
    }
}
