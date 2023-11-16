using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ДЗ_11._11._2023.Program;

namespace ДЗ_11._11._2023
{
    internal class ACipher:ICipher
    {
        public string Encode(string str)
        {
            string ciphertext = " "; 
            for (int i = 0; i < str.Length;
                ciphertext = ciphertext + (char)(str[i] + 1)) ; 
            return ciphertext;
        }
        public string Decode(string str)
        {
            string plaintext = "";
            for (int i = 0; i < str.Length;
                plaintext = plaintext + (char)(str[i]-1)) ;
            return plaintext;
        }
    }
}
