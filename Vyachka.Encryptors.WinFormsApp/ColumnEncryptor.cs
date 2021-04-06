using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vyachka.Encryptors
{
    public static class ColumnEncryptor
    {
        public static string Encrypt(string plainText, string key)
        {
            int rowsAmount = CountRowsAmount(plainText, key);
            //matrix for distributing the plain text
            char[,] cipherMatrix = FillCipherMatrix(plainText, key);
            byte[] cipherPositions = FillCipherPositionsArray(key);
            var cipherText = new StringBuilder(plainText.Length);
            byte columnToWrite = 1;
        
            while(columnToWrite < key.Length + 1)
            {
                for(int i = 0; i < cipherPositions.Length; i++)
                {
                    if (cipherPositions[i] == columnToWrite)
                    {
                        for(int row = 0; row < rowsAmount; row++)
                        {
                            if(cipherMatrix[row, i] > 0)
                            {
                                cipherText.Append(cipherMatrix[row, i]);
                            }
                        }

                        columnToWrite++;
                    }  
                }
            }
            
            return cipherText.ToString();
        }

        private static char[,] FillCipherMatrix(string plainText, string key)
        {
            int rowsAmount = CountRowsAmount(plainText, key);
            int columnsAmount = key.Length;
            char[,] cipherMatrix = new char[rowsAmount, columnsAmount];
            int row = 0;
            int column = 0;

            for (int index = 0; index < plainText.Length; index++)
            {
                cipherMatrix[row, column] = plainText[index];
                column++;
                if (column > columnsAmount - 1)
                {
                    column = 0;
                    row++;
                }
            }

            return cipherMatrix;
        }

        private static byte[] FillCipherPositionsArray(string key)
        {
            byte[] cipherPositions = new byte[key.Length];
            char[] keyChars = key.ToCharArray();
            Array.Sort(keyChars);
            byte position = 1;
            
            for(int index = 0; index < keyChars.Length; index++)
            {
                int keyIndex = 0;
                bool isNotFound = true;
                while(isNotFound)
                {
                    if (keyChars[index] == key[keyIndex])
                    {
                        if (cipherPositions[keyIndex] > 0)
                        {
                            keyIndex++;
                            continue;
                        }
                        else
                        {
                            cipherPositions[keyIndex] = position;
                            position++;
                            isNotFound = false;
                        }
                    }
                    
                    keyIndex++;
                }
            }

            return cipherPositions;
        }

        public static string Decrypt(string cipherText, string key)
        {
            char[,] plainMatrix = FillPlainMatrix(cipherText, key);
            var plainText = new StringBuilder(cipherText.Length);
            int row = 0;
            int column = 0;

            for (int index = 0; index < cipherText.Length; index++)
            {
                plainText.Append(plainMatrix[row, column]);
                column++;
                if (column > key.Length - 1)
                {
                    column = 0;
                    row++;
                }
            }

            return plainText.ToString();
        }

        private static char[,] FillPlainMatrix(string cipherText, string key)
        {
            byte[] cipherPositions = FillCipherPositionsArray(key);
            int rowsAmount = CountRowsAmount(cipherText, key);
            char[,] plainMatrix = new char[rowsAmount, key.Length];
            int columnToWrite = 1;
            int amoumtOfEmptyCells = rowsAmount * key.Length - cipherText.Length;
            int indexOfCipherChar = 0;

            while (columnToWrite < key.Length + 1)
            {
                for (int i = 0; i < cipherPositions.Length; i++)
                {
                    if (cipherPositions[i] == columnToWrite)
                    {
                        if(key.Length - i - 1 < amoumtOfEmptyCells)
                        {
                            for(int j = 0; j < rowsAmount - 1; j++)
                            {
                                plainMatrix[j, i] = cipherText[indexOfCipherChar];
                                indexOfCipherChar++;
                            }
                        }
                        else
                        {
                            for (int j = 0; j < rowsAmount; j++)
                            {
                                plainMatrix[j, i] = cipherText[indexOfCipherChar];
                                indexOfCipherChar++;
                            }
                        }

                        columnToWrite++;
                    }
                }
            }

            return plainMatrix;
        }

        private static int CountRowsAmount(string text, string key)
        {
            if (text.Length % key.Length == 0)
            {
                return text.Length / key.Length;
            }
            else
            {
                return text.Length / key.Length + 1;
            }
        }
    }
}
