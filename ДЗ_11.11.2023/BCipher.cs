using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static ДЗ_11._11._2023.Program;

namespace ДЗ_11._11._2023
{
    internal class BCipher:ICipher
    {
        public string Encode(string str)
        {
            string alphabet = "абвгдеёжзийклмнопрстуфхшщъыьэюя";
            string encryptedText = "";

            foreach (char letter in str.ToLower())
            {
                int index = alphabet.IndexOf(letter);
                if (index != -1)
                {
                    char encryptedLetter = alphabet[alphabet.Length - 1 - index];
                    encryptedText += char.IsUpper(letter) ? char.ToUpper(encryptedLetter) : encryptedLetter;
                }
                else
                {
                    encryptedText += letter;
                }
            }
            return encryptedText;
        }
        public string Decode(string str)
        {
            string alphabet = "абвгдеёжзийклмнопрстуфхшщъыьэюя";
            string encryptedText = "";

            foreach (char letter in str.ToLower())
            {
                int index = alphabet.IndexOf(letter);
                if (index != -1)
                {
                    char encryptedLetter = alphabet[alphabet.Length - 1 + index];
                    encryptedText += char.IsUpper(letter) ? char.ToUpper(encryptedLetter) : encryptedLetter;
                }
                else
                {
                    encryptedText += letter;
                }
            }
            return encryptedText;
        }
    }
}
