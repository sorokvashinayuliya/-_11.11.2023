using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ_11._11._2023
{
    internal class Program
    {
        internal interface ICipher
        {
            string Encode(string str);
            string Decode(string str);

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 10.1. Создать интерфейс ICipher, который определяет методы поддержки шифрования строк.");
            ICipher cipher2 = new ACipher();
            Console.WriteLine("Введите текст для шифрования:");
            string text2 = Console.ReadLine();
            string encryptedText2 = cipher2.Encode(text2);
            Console.WriteLine("Зашифрованный текст: " + encryptedText2);
            ICipher cipher3 = new ACipher();
            Console.WriteLine("Введите текст для дешифрования:");
            string text3 = Console.ReadLine();
            string encryptedText3 = cipher3.Decode(text3);
            Console.WriteLine("Расшифрованный текст: " + encryptedText3);
            Console.WriteLine("Класс шифрует строку, выполняя замену каждой буквы, стоящей в алфавите на i-й позиции, на букву того же регистра, расположенную в алфавите на i-й позиции с конца алфавита");
            ICipher cipher = new BCipher();
            Console.WriteLine("Введите текст для шифрования:");
            string text = Console.ReadLine();
            string encryptedText = cipher.Encode(text);
            Console.WriteLine("Зашифрованный текст: " + encryptedText);
            ICipher cipher1 = new BCipher();
            Console.WriteLine("Введите текст для дешифрования:");
            string text1 = Console.ReadLine();
            string encryptedText1 = cipher.Decode(text);
            Console.WriteLine("Расшифрованный текст: " + encryptedText);
            Console.WriteLine("Упражнение 10.2. Создать класс Figure");
            Point point = new Point(0, 1, "blue", true);
            point.PrintCoordinates();
        }
    }
}
