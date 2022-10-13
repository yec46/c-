using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A037
{
    class Program
    {
        enum E { Red, Green, Blue};
        static void Main(string[] args)
        {
            int a = default;
            string s = default;
            Console.WriteLine("a = " + a);
            Console.WriteLine("s = " + s);

            Console.WriteLine("E = " + default(E));  // 0번째 enum 출력
            Console.WriteLine("E = " + (E)0);

            MyList<int> iList = new MyList<int>();
            Console.WriteLine("iList : " + iList.GetList());

            MyList<string> sList = new MyList<string>();
            Console.WriteLine("sList : " + sList.GetList());
        }
    }

    public class MyList<T>
    {
        private class Node
        {
            public T data;
            public Node next;
        }

        private Node head = default;

        public void AddNode(T t)
        {
            Node newNode = new Node();
            newNode.next = head;
            newNode.data = t;
            head = newNode;
        }

        public T GetList()
        {
            T temp = default(T);

            Node current = head;
            while( current != null)
            {
                temp = current.data;
                current = current.next;
            }
            return temp;
        }
    }
}
