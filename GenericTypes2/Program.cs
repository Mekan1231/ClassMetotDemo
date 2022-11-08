using System;
using System.Collections;
using System.Collections.Generic;

namespace GenericTypes2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> isimler=new Dictionary<int,string>();
            isimler.Add(123, "Mekan");
            isimler.Add(223, "Mergen");
            isimler.Add(323, "Merdan");
            isimler.Add(443, "Maysa");

            Console.WriteLine(isimler[123]);

            //ArrayList takimler = new ArrayList();
            //Console.WriteLine(takimler.Capacity);
            //takimler.Add(1);
            //Console.WriteLine(takimler.Capacity);

            MyDictionary<int, string> isimler2 = new MyDictionary<int, string>();
            isimler2.Add(134, "Mekan");
            isimler2.Add(254, "Mergen");
            isimler2.Add(312, "Merdan");
            isimler2.Add(467, "Maysa");

            Console.WriteLine(isimler2[254]);

        }
    }
}