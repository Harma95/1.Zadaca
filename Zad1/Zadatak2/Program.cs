using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak2
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<String> list=new GenericList<string>();
            list.Add("Rafo");
            list.Add("princeza");
            list.Add("KKer");
            list.Add("faka");
            list.Add("Ana");
            foreach (string item in list)
            {
                Console.WriteLine(item);
                if (item == null)
                    break;
            }
            list.Remove("Rafo");
            list.RemoveAt(3);
            list.ispis();
            
        }
    }
}
