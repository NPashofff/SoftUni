using System;
using System.IO.Compression;

namespace _06_Zip_and_Extract
{
    class Program
    {
        static void Main(string[] args)
        {
            ZipFile.CreateFromDirectory("../../../ForZip", "../../../Zip/ZipMe.zip");

            ZipFile.ExtractToDirectory("../../../Zip/ZipMe.zip", "../../../Extracted");
        }
    }
}
