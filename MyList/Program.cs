using System.Collections.Generic;

namespace MyList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<int> list = new List<int>();
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //Console.WriteLine(list[2]);
            //list.Add(4);
            //list.Add(5);
            //Console.WriteLine(list[4]);

            MyList<int> myList = new MyList<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            foreach (var item in myList.Items)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
