using System;

namespace RecognizingVin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Укажите путь к файлу изображения с именем файла и расширением: ");

            string filePath = Console.ReadLine();

            var result = new IronOcr.IronTesseract().Read(filePath);

            var text = result.Text.Replace("O", "0");

            Console.ReadKey();

            Console.WriteLine(text);
        }
    }
}
