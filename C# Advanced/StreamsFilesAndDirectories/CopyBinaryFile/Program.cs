using System;
using System.IO;

namespace CopyBinaryFile
{
    class Program
    {
        static void Main(string[] args)
        {
            using var reader = new FileStream("../../../../Resources/copyMe.png", FileMode.Open);
            using var writer = new FileStream("../../../../Resources/copy_copyMe.png", FileMode.Create);
            byte[] buffer = new byte[4096];
            while (reader.Position != reader.Length)
            {
                reader.Read(buffer, 0, buffer.Length);
                writer.Write(buffer);
            }
        }
    }
}
