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
            int N = Convert.ToInt32(Console.ReadLine());
            Console.Write("Сколько кристаллов по цене 15 Вы хотите купить?: ");
            int Crystal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("У вас осталось " + (N - 15 * Crystal) + " золота и " + Crystal + " кристаллов");

        }
    }
}