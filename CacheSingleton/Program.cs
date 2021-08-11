using CacheSingleton.Singleton;
using System;

namespace CacheSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Getting cache object... Cache Guid: {Cache.GetInstance().Guid}");
            Console.WriteLine($"Getting cache object... Cache Guid: {Cache.GetInstance().Guid}");
            Console.WriteLine($"Getting cache object... Cache Guid: {Cache.GetInstance().Guid}");
            Console.WriteLine("The 3 times we get cache, it is the same!");
        }
    }
}
