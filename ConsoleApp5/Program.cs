using System.IO;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo di = new DirectoryInfo("c:\\");
            var dirList = di.GetDirectories();
            foreach (var folder in dirList)
            {
                Console.WriteLine(folder.Name);
                Dön(folder);
            }
        }
        static void Dön(DirectoryInfo di)
        {
            try
            {
                var dirList = di.GetDirectories();
                foreach (var folder in dirList)
                {
                    Console.WriteLine(folder.Name);
                    Dön(folder);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}