using System;
using System.IO;

namespace OOP_lab_3_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader file = new StreamReader("input.txt");

            string text = file.ReadToEnd();

            string[] words = text.Split(new char[] { '\n', '\r', ' ', ':', ';', '.', ',', '?', '!', '(', ')', '{', '}', '[', ']', '@', '#', '№', '$', '^', '%', '&', '*', '/', '|' }, StringSplitOptions.RemoveEmptyEntries);

            string longestWord = words[0];

            foreach (string word in words)
            {
                if (longestWord.Length <= word.Length)
                {
                    longestWord = word;
                }
            }

            StreamWriter newFile = File.CreateText("output.txt");

            newFile.WriteLine("Найдовше слово: {0}", longestWord);

            newFile.Close();
        }
    }
}
