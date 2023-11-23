using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._22_24._11._2023.DesignPatterns.Structural.Proxy
{
    internal class Database : IDisposable, IDatabase
    {
        public int _connectionCounter = 0;
        public const int MAX_CONNECTIONS = 5;

        public Database()
        {
            Console.WriteLine("Otwieranie połącznia z bazą danych...");
        }

        public void Dispose()
        {
            Console.WriteLine("Zamykanie połącznia z bazą danych...");
        }

        public async Task RequestAsync(int @int)
        {
            if(_connectionCounter >= MAX_CONNECTIONS)
            {
                Console.WriteLine($"Zapytanie {@int} odrzucone!");
                return;
            }

            Interlocked.Increment(ref _connectionCounter);
            Console.WriteLine($"Wykonywanie zapytania {@int}");

            await Task.Delay(new Random(@int).Next(1000, 2500));

            Console.WriteLine($"Zakończono zapytanie {@int}");

            Interlocked.Decrement(ref _connectionCounter);

        }
    }
}
