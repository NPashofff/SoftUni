using System;
using System.IO;

namespace _04__Copy_Binary_File
{
    class Program
    {
        static void Main(string[] args)
        {
            using FileStream reader = new FileStream("copyMe.png", FileMode.Open);
            using FileStream writer = new FileStream("../../../copyOfMe.png", FileMode.Create);
            int biteBuffer = 4096;

            while (reader.CanRead)
            {
                byte[] buffer = new byte[biteBuffer];
                int readBites = reader.Read(buffer, 0, buffer.Length);

                if (readBites == 0 )
                {
                    break;
                }

                writer.Write(buffer, 0, readBites);
            }
        }
    }
}
