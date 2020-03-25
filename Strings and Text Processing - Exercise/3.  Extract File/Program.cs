using System.Threading.Channels;

namespace _3.__Extract_File
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var fileLocation = Console.ReadLine();
            var fileNameAndExtension = fileLocation.Substring(fileLocation.LastIndexOf('\\') + 1);
            var fileName = fileNameAndExtension.Substring(0, fileNameAndExtension.LastIndexOf('.'));
            var fileExtension = fileNameAndExtension.Substring(fileNameAndExtension.LastIndexOf('.') + 1);

            Console.WriteLine("File name: " + fileName);
            Console.WriteLine("File extension: " + fileExtension);
        }
    }
}
