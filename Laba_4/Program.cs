using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Laba_4
{
    public class Program
    {
        static string FILEPATH = AppDomain.CurrentDomain.BaseDirectory+"labaFile.txt";
        static void Main(string[] args)
        {
            string final = "";
            string text = ReadFile();

            Console.WriteLine(text);

            if (text=="null")
            {
                Console.WriteLine("File is empty");
            }
            else
            {
                final = Analize(text);
            }

            Console.WriteLine("----");
            Console.WriteLine(final);

            Console.ReadKey();
        }
        private static string ReadFile()
        {
            try
            {
                if (File.Exists(FILEPATH))
                {
                    return System.IO.File.ReadAllText(FILEPATH);
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString());}

            return "null";
        }

        public static string Analize(string text)
        {
            string regexNumberType1 = @"(\+\d{11})|(\d{11})";
            string regexStringType2 = @"\b\s\b[А-Я]\w*\b";

            text = Regex.Replace(text, regexNumberType1, "[censored]");
            text = Regex.Replace(text, regexStringType2, " [censored]");

            return text;
        }
    }
}
