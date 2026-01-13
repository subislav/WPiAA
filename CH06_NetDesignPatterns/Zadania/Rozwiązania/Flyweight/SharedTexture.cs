using System;

namespace Flyweight
{
    public class SharedTexture
    {
        public string Filename { get; private set; }
        public SharedTexture(string filename)
        {
            Filename = filename;
            Console.WriteLine($"Wczytano teksturę z pliku '{filename}'.");
        }
        public void Render(int x, int y)
        {
            Console.WriteLine($"Rysuję teksturę '{Filename}' na pozycji ({x}, {y})");
        }
    }
}