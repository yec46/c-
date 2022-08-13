using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A28
{
    class Program
    {
        static void Main(string[] args)
        {
            //Contains()
            // 스트링에 특정 문자열이 포함되어있는지를 체크합니다. bool 메소드
            string s1 = "mouse, cow, tiger, rabbit, dragon";
            string s2 = "Cow";
            bool b = s1.Contains(s2);
            Console.WriteLine("'{0}' is in the string  '{1}' : {2}", s2, s1, b);

            //Indexof() 
            //문자열에서 특정 문자 또는 문자열이 나타나는 인덱스를 리턴해줍니다. 0부터 시작 없을땐 -1 리턴 
            if (b)
            {
                int index = s1.IndexOf(s2);
                if(index >= 0)
                {
                    Console.WriteLine("'{0}' begin at index '{1}'", s2, index);
                }
            }

            //StringComparison.CurrentCultureIgnoreCase
            //대소문자 구분여부, 언어, 정렬 순서 등을 표현, 대소문자를 구분하지 않고 비교함 
            if (s1.IndexOf(s2, StringComparison.CurrentCultureIgnoreCase) >= 0)
            {
                Console.WriteLine("'{0}' is the string '{1}'", s2, s1);
            }

        }
    }
}
