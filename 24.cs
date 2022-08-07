using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A24
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 32;

            Console.WriteLine(x += 2);
            Console.WriteLine(x -= 8);
            Console.WriteLine(x *= 3);
            Console.WriteLine(x /= 2);
            // ++x는 x를 먼저 증가시키고 사용
            Console.WriteLine(x ++);
            // 현재 값을 먼저 사용하고 나서 x 값 증가
            Console.WriteLine(++ x);

            Console.WriteLine(-- x);
        }
    }
}
