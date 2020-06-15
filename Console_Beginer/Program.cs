using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Beginer
{
    class Program
    {
        public static void Increate(ref int value)
        {
            value++;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello các cậu");
            int value = 4;
            Console.WriteLine("kêt quả đầu tiên:"+value);
            Increate(ref value);
            Console.WriteLine("Kết quả sau khi tăng với ref:" +value);
            Console.ReadKey();
        }
    }
}
