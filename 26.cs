using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A26
{
    class A26
    {
        static void Main(string[] args)
        {
            Console.WriteLine("더하고자 하는 숫자들을 입력하세요 : ");
            string s = Console.ReadLine();
            Console.WriteLine(s);

            int sum = 0;
            string[] v = s.Split();
            Console.WriteLine(s);
            foreach(var i in v)
            {
                sum += int.Parse(i);
            }
            Console.WriteLine("결과는 {0}", sum);


        }
    }
}
