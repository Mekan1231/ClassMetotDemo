using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypes2
{
    internal class MyDictionary<Tkey,Tvalue> 
    {
        List<Tkey> keys;
        List<Tvalue> values;
        public MyDictionary()
        {
            keys=new List<Tkey>();
            values=new List<Tvalue>();
        }
        public void Add(Tkey key, Tvalue value)
        {
            keys.Add(key);
            values.Add(value);
        }

        public Tvalue this[Tkey index]
        {

            get
            {
                int key = keys.BinarySearch(index);
                
                
                    return values[key];
                
                


            } 
        }
    }
}
