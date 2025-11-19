using ConsoleApp6.Класс;
using ConsoleApp6.Класс.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Console.Write("Введите имя игрока: ");
            Console.Write("Введите имя игрока: ");
            string playerName = Console.ReadLine();

            PlayerEntity player = new PlayerEntity(playerName);
            Console.WriteLine(player.DealDamage());
        } // 
    }
}
