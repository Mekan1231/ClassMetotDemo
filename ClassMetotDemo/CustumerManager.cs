using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class CustumerManager
    {
        // simule amaçlı oldugu için 10 üyeli dizi tanımlanmıştır
        Custumer[] custumers = new Custumer[10];
        
        public void AddCustumer(Custumer custumer)
        {
            if (custumers[9] == null)
            {
                for (int i = 0; i < custumers.Length; i++)
                {
                    if (custumers[i]==null)
                    {
                        custumers[i] = custumer;
                        break;
                    }

                }
                Console.WriteLine("Müşteri başarılı bir ekilde eklenmiştir");

            }
            else
            {
                Console.WriteLine("Dizi kapsesitesi dolmuştur.");
            }
        }


        public void Delete(int id)
        {
            for (int i = 0; i < custumers.Length; i++)
            {
                if (custumers[i].id==id)
                {
                    
                    for (int x = i; x < custumers.Length; x++)
                    {
                        if (custumers[x]!=null)
                        {
                            custumers[x] = custumers[x + 1];
                        }
                        else
                        {
                            break;
                        }
                    }
                    break;
                    
                }
            }

            Console.WriteLine($"{id} id numaralı müşteri silinmiştir");


        }

        public void Listele()
        {
            for (int i = 0; i < custumers.Length; i++)
            {
                if (custumers[i]!=null)
                {
                    Console.WriteLine("Müşteri");
                    Console.WriteLine("ID: " + custumers[i].id);
                    Console.WriteLine("Ismi: " + custumers[i].name);
                    Console.WriteLine("Soyadı: " + custumers[i].surname);
                    Console.WriteLine("Yaşı: " + custumers[i].age);
                }
                else
                {
                    break;
                }
            }
        }
    }
}
