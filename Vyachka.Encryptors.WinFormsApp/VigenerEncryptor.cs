using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vyachka.Encryptors
{
    public static class VigenerEncryptor
    {
        private static char[] alphabet = Alphabets.rusAlphabet;
        private static int alphabetLength = Alphabets.rusAlphabet.Length;

        public static string Encrypt(string plainText, string key)
        {
            key = CreateKey(plainText, key);
            StringBuilder cipherText = new StringBuilder();
            for (int i = 0; i < plainText.Length; i++)
            {
                bool isLowerCase = char.IsLower(plainText[i]);
                char charToAppend = alphabet[(Alphabets.IndexOf("rus", Char.ToUpper(plainText[i])) +
                        Alphabets.IndexOf("rus", Char.ToUpper(key[i]))) % alphabetLength];
                if (isLowerCase)
                {
                    charToAppend = Char.ToLower(charToAppend);
                }
                    
                cipherText.Append(charToAppend);
            }
            return cipherText.ToString();
        }

        public static string Decrypt(string cipherText, string key)
        {
            key = CreateKey(cipherText, key);
            StringBuilder plainText = new StringBuilder();
            for (int i = 0; i < cipherText.Length; i++)
            {
                bool isLowerCase = Char.IsLower(cipherText[i]);
                char charToAppend = alphabet[((alphabetLength + Alphabets.IndexOf("rus", Char.ToUpper(cipherText[i])) -
                        Alphabets.IndexOf("rus", Char.ToUpper(key[i]))) % alphabetLength)];
                if (isLowerCase) charToAppend = Char.ToLower(charToAppend);
                plainText.Append(charToAppend);
            }

            return plainText.ToString();
        }

        private static string CreateKey(string plainText, string key)
        {
            var newKey = new StringBuilder(key);
            for (int i = 0; i < plainText.Length - key.Length; i++)
            {
                bool isLowerCase = Char.IsLower(newKey[i]);
                char charToAppend = key[i % key.Length];
                if (isLowerCase)
                {
                    charToAppend = Char.ToLower(charToAppend);
                }
                   
                newKey.Append(charToAppend);
            }
            return newKey.ToString();
        }
    }
}
