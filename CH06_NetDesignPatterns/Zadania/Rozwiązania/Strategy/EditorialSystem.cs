using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Strategy
{
    public class EditorialSystem
    {
        private IImageStrategy _strategy;
        public EditorialSystem(IImageStrategy strategy)
        {
            _strategy = strategy;
        }
        public void SetStrategy(IImageStrategy strategy)
        {
            _strategy = strategy;
        }
        public async Task FindAndDisplayPhotos(string category)
        {
            Console.WriteLine($"\nWyszukiwanie zdjęć w kategorii '{category}'..");
            List<string> results = await _strategy.SearchPhotosAsync(category);
            if (results.Count > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                foreach (var url in results)
                {
                    Console.WriteLine($"Wyniki wyszukiwania: {url}");
                    try
                    {
                        Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
                    }
                    catch (Exception ex)
                    {
                        break;
                    }
                }
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("Nie znaleziono zdjęć lub wystąpił błąd API.");
            }
        }
    }
}