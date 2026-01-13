using System;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static async Task Main(string[] args)
        {
            EditorialSystem editor = new EditorialSystem(new PexelsStrategy());
            while (true)
            {
                Console.WriteLine("\nWybór bazy zdjęć:");
                Console.WriteLine("1. Pexels");
                Console.WriteLine("2. Pixabay");
                Console.WriteLine("3. Wyjście");
                string choice = Console.ReadLine();
                if (choice == "3") break;
                if (choice == "1")
                {
                    editor.SetStrategy(new PexelsStrategy());
                }
                else if (choice == "2")
                {
                    editor.SetStrategy(new PixabayStrategy());
                }
                else
                {
                    continue;
                }
                Console.Write("Podaj kategorię: ");
                string category = Console.ReadLine();
                await editor.FindAndDisplayPhotos(category);
            }
        }
    }
}