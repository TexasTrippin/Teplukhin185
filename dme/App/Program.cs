using System;
using CoreLib;
namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Utils.GenNumOrder("Иванов Иван Иванович", DateTime.Now));
            Console.ReadKey();
        }
    }
}
