using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vyachka.Encryptors
{
    public enum EncryptMethod{
        RailFence, Column, Vigener
    }

    public class Program
    {
        static void Main(string[] args)
        {
            string defPlainText = "морожdfvfеноdе";
            Console.WriteLine($"The task is to encrypt/decrypt the word \'{defPlainText}\'\n");

            EncryptMethod method = GetEncryptMethod(5);

            string text = Filter.FilterText(defPlainText, "rus");
            string cipherText = "";
            string key = "1";

            switch (method)
            {
                case EncryptMethod.RailFence:
                    if(KeyChecker.CheckKey(key, "num"))
                        cipherText = RailFenceEncryptor.Encrypt(text, key);
                    else
                        Console.WriteLine("Incorrect key!");

                    break;

                case EncryptMethod.Column:
                    if(KeyChecker.CheckKey(key, "eng"))
                        cipherText = ColumnEncryptor.Encrypt(text, key);     
                    else
                        Console.WriteLine("Incorrect key!");
                   
                    break;

                case EncryptMethod.Vigener:
                    if (KeyChecker.CheckKey(key, "rus"))
                        cipherText = VigenerEncryptor.Encrypt(text, key);
                    else
                        Console.WriteLine("Incorrect key!");
                        
                    break;
            }

            Console.WriteLine($"Method: {method}\nKey: {key}\nPlain text: {text}\nCipher text: {cipherText}");
            Console.ReadLine();
        }

        private static EncryptMethod GetEncryptMethod(int rand)
        {
            EncryptMethod method = EncryptMethod.RailFence;
            switch(rand)
            {
                case 1:
                    method = EncryptMethod.RailFence;
                    break;
                case 2:
                    method = EncryptMethod.Column;
                    break;
                case 3:
                    method = EncryptMethod.Vigener;
                    break;
            }

            return method;
        }
    }
}
