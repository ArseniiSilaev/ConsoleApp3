using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество золота: ");
            int goldCount = Convert.ToInt32(Console.ReadLine());
            int crystalPrice = 15;
            Console.Write("Сколько кристаллов по цене " + crystalPrice + " Вы хотите купить ?: ");
            int crystalCount = Convert.ToInt32(Console.ReadLine());
            goldCount -= crystalPrice * crystalCount;
            Console.WriteLine("У вас осталось " + goldCount + " золота и " + crystalCount + " кристаллов");
        }
    }
}
