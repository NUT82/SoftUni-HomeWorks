using System;
using System.IO;
using System.Text.RegularExpressions;

namespace LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("../../../../Resources/text.txt");
            string[] newLines = new string[lines.Length];
            int lineCount = 0;
            foreach (var line in lines)
            {
                lineCount++;
                int letters = Regex.Matches(line, @"[A-Za-z]").Count;
                int punctuationMarks = Regex.Matches(line, @"[-.,?!'""]").Count;
                newLines[lineCount - 1] = $"Line {lineCount}: " + line + $" ({letters})({punctuationMarks})";
            }
            
            File.WriteAllLines("../../../../Resources/output.txt", newLines);
        }
    }
}
