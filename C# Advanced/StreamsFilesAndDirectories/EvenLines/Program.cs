using System;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;

namespace EvenLines
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader = new StreamReader("../../../../Resources/text.txt");
            using (reader)
            {
                int countLines = 0;
                string currLine = reader.ReadLine();
                var writer = new StreamWriter("../../../../Resources/output.txt");
                using (writer)
                {
                    while (currLine != null)
                    {
                        if (countLines % 2 == 0)
                        {
                            Regex regex = new Regex(@"[-,.!?]");
                            currLine = regex.Replace(currLine, "@");
                            currLine = ReverseOrderOfWords(currLine);
                            writer.WriteLine(currLine);
                        }
                        countLines++;
                        currLine = reader.ReadLine();
                    }
                }
            }
            ;
        }

        private static string ReverseOrderOfWords(string text)
        {
            string[] splitText = text.Split();
            splitText = splitText.Reverse().ToArray();
            return string.Join(" ", splitText);
        }
    }
}
