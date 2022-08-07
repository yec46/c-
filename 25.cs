using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A25
{
    class Program
    {
        static void Main(string[] args)
        {
            //string 클래스 
            string s = " Hello, World! ";
            string t;

        
            Console.WriteLine(s.Length); 
            Console.WriteLine(s[8]); 
            Console.WriteLine(s.Insert(8, "C# "));                      // string 안의 특정 위치에 string 을 삽입합니다.
            Console.WriteLine(s.PadLeft(20, '.'));                      // string 앞에 특정 문자를 삽입하여 글자수를 맞춥니다.           
            Console.WriteLine(s.PadRight(20, '.'));                     // string 뒤에 특정 문자를 삽입하여 글자수를 맞춥니다.           
            Console.WriteLine(s.Remove(6));                             // string 에서 substring을 삭제합니다.          
            Console.WriteLine(s.Remove(6, 7));                          // string 에서 substring을 삭제합니다.          
            Console.WriteLine(s.Replace('l', 'm'));                     // string에서 문자 혹은 substring을 다른 문자 혹은 substring으로 대체합니다.
            Console.WriteLine(s.ToLower());                             // string에서 문자 를 소문자로 변환합니다.
            Console.WriteLine(s.ToUpper());                             // string에서 문자 를 대문자로 변환합니다.
            Console.WriteLine('/' + s.Trim() + '/');                    // string에서 앞뒤의 공백문자 또는 특정 문자를 제거합니다.
            Console.WriteLine('/' + s.TrimStart() + '/');               // string에서 앞의 공백문자 또는 특정 문자를 제거합니다.
            Console.WriteLine('/' + s.TrimEnd() + '/');                 // string에서 앞의 공백문자 또는 특정 문자를 제거합니다.

            string[] a = s.Split(',');
            foreach (var i in a)
                Console.WriteLine('/' + i + '/');

            char[] destination = new char[10];
            s.CopyTo(8, destination, 0, 6);                             // string의 일부분을 문자 배열로 복사합니다.
            Console.WriteLine(destination);
            Console.WriteLine('/' + s.Substring(8) + '/');              // string에서 특정 문자에서 끝까지의 substring을 추출합니다.
            Console.WriteLine('/' + s.Substring(8, 5) + '/');           // string에서 특정 문자에서 끝까지의 substring을 추출합니다.   

            Console.WriteLine(s.Contains("ll"));                        // 특정 문자 또는 문자열을 포함하는지 true/false로 리턴합니다.
            Console.WriteLine(s.IndexOf('o'));                         // 특정 문자 또는 문자열이 처음으로 나오는 index를 리턴합니다.
            Console.WriteLine(s.LastIndexOf('o'));                     // 특정 문자 또는 문자열이 마지막으로 나오는 index를 리턴합니다.
            Console.WriteLine(s.CompareTo("abc"));                     // string 값을 비교해서 작으면 - 값 같으면 0 크면 + 값을 리턴합니다.

            Console.WriteLine(String.Concat("Hi~", s));                // 한개이상의 substring을 합쳐서 새로운 string을 만듭니다.
            Console.WriteLine(String.Compare("abc", s));                // 두개의 string을 비교해서 상대적인 위치를 리턴합니다.
            Console.WriteLine(t = String.Copy(s));                      // 현재 string을 복사해 새로운 string을 만듭니다.

            String[] val = { "apple", "orange", "grape", "pear" };
            String result = String.Join(",", val);                      //  배열이나 컬렉션의 멤버들을 모아서 새로운 string을 만듭니다. 이때 멤버 사이에 구분자를 삽입합니다.
            Console.WriteLine(result);


            
        }
    }
}
