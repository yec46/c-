using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A31
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("this is a StringBulider Test.");
            Console.WriteLine("{0} {1} characters)", sb.ToString(), sb.Length);

            //sb 초기화
            sb.Clear();
            Console.WriteLine("{0} {1} characters)", sb.ToString(), sb.Length);

            //sb의 맨뒤에 문자열 추가
            sb.Append("This is a new String");
            Console.WriteLine("{0} {1} characters)", sb.ToString(), sb.Length);
            
            //sb의 5번째 위치에 xyz를 2번 삽입
            sb.Insert(5, "xyz ", 2);
            Console.WriteLine("{0} {1} characters)", sb.ToString(), sb.Length);

            //sb의 5번째 위치에 4개의 문자 삭제
            sb.Remove(5,4);
            Console.WriteLine("{0} {1} characters)", sb.ToString(), sb.Length);

            //sb의 xyz를 찾아 abc로 대체
            sb.Replace("xyz", "abc");
            Console.WriteLine("{0} {1} characters)", sb.ToString(), sb.Length);

            //string과 stringbuilder의 차이를 위한 타이머 재기 
            Stopwatch time = new Stopwatch();
            string test = string.Empty;
            time.Start();
            for(int i = 0; i<100000; i++)
            {
                test += i;
            }
            time.Stop();
            Console.WriteLine("String : " + time.ElapsedMilliseconds + "ms");

            StringBuilder test1 = new StringBuilder();
            time.Reset();
            for(int i=0; i < 100000; i++)
            {
                test1.Append(i);
            }
            time.Stop();
            Console.WriteLine("String : " + time.ElapsedMilliseconds + "ms");

        }
    }
}
