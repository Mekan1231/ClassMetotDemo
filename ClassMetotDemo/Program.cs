using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Custumer custumer1= new Custumer() { id = 1, name="Mekan", surname="Annamyradov",age=25 };
            Custumer custumer2= new Custumer() { id = 2, name="Merdan", surname="Annamyradov",age=26 };
            Custumer custumer3= new Custumer() { id = 3, name="Mergen", surname="Annamyradov",age=23 };
            Custumer custumer4= new Custumer() { id = 4, name="Maysa", surname="Annamyradova",age=21 };

            CustumerManager manager = new CustumerManager();

            manager.AddCustumer(custumer1);
            manager.AddCustumer(custumer2);
            manager.AddCustumer(custumer3);
            manager.AddCustumer(custumer4);

            manager.Listele();

            manager.Delete(2);

            manager.Listele();

        }
    }
}

