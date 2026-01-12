using System;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        private const string ApiKey = "cc43d19a0f10ffa43c01f0f45a59e02e";
        static async Task Main(string[] args)
        {
            WeatherFacade weatherFacade = new WeatherFacade(ApiKey);
            while (true)
            {
                Console.Write("Podaj nazwę miasta lub zakończ działanie programu wpisując 'exit': ");
                string city = Console.ReadLine();
                if (city.ToLower() == "exit") break;
                try
                {
                    double temp = await weatherFacade.GetTemperatureAsync(city);
                    Console.WriteLine($"Aktualna temperatura w {city}: {temp}°C\n");
                }
                catch (Exception)
                {
                    Console.WriteLine("Niepoprawna nazwa miasta lub klucz API.\n");
                }
            }
        }
    }
}