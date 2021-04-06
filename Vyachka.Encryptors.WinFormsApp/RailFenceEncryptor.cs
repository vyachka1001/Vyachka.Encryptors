using System;
using System.Text;

namespace Vyachka.Encryptors
{
    public static class RailFenceEncryptor
    {
        public static string Encrypt(string plainText, string strKey)
        {
            int key = int.Parse(strKey);
            if(key == 1)
            {
                return plainText;
            }

            StringBuilder cipherText = new StringBuilder();
            for (int lvl = 0; lvl < key; lvl++)
            {
                int j = lvl;
                bool flag = false;
                while (j < plainText.Length)
                {
                    cipherText.Append(plainText[j]);
                    j += GetOffset(lvl, flag, key);
                    flag = !flag;
                }
            }
            return cipherText.ToString();
        }

        public static string Decrypt(string cipherText, string strKey)
        {
            int key = int.Parse(strKey);
            if(key == 1)
            {
                return cipherText;
            }
            StringBuilder plainText = new StringBuilder();
            StringBuilder[] strLevels = new StringBuilder[key];
            int index = 0;
            for (int lvl = 0; lvl < key; lvl++)
            {
                int j = lvl;
                bool flag = false;
                int counter = 0;
                while (j < cipherText.Length)
                {
                    counter++;
                    j += GetOffset(lvl, flag, key);
                    flag = !flag;
                }
                strLevels[lvl] = new StringBuilder(cipherText.Substring(index, counter));
                index += counter;
            }

            bool isEnd = false;
            while (!isEnd)
            {
                isEnd = true;
                for (int j = 0; j < key - 1; j++)
                {
                    if (strLevels[j].Length != 0)
                    {
                        plainText.Append(strLevels[j][0]);
                        strLevels[j].Remove(0, 1);
                        isEnd = false;
                    }
                }
                for (int j = key - 1; j > 0; j--)
                {
                    if (strLevels[j].Length != 0)
                    {
                        plainText.Append(strLevels[j][0]);
                        strLevels[j].Remove(0, 1);
                        isEnd = false;
                    }
                }
            }
            return plainText.ToString();
        }

        private static int GetOffset(int lvl, bool flag, int key)
        {
            if (flag && (lvl != 0) && (lvl != key - 1))
            {
                return lvl * 2;
            }
            if (lvl == key - 1)
            {
                lvl = 0;
            }
            return (key - lvl - 1) * 2;
        }
    }
}
