using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    class Program
    {
        static void Main(string[] args)
        {
            IntegerList listOfIntegers = new IntegerList();
            listOfIntegers.Add(1);
            listOfIntegers.Add(3);
            listOfIntegers.Add(4);
            listOfIntegers.Add(5);
            listOfIntegers.Add(7);
            listOfIntegers.Add(15);
            listOfIntegers.Add(19);
            listOfIntegers.Add(19);
            listOfIntegers.Add(19);
            listOfIntegers.ispis();
            Console.WriteLine(listOfIntegers.RemoveAt(4));
          //  Console.WriteLine(listOfIntegers.Remove(15));
            listOfIntegers.ispis();
            Console.WriteLine(listOfIntegers.Count);
            Console.WriteLine(listOfIntegers.Remove(100));
            Console.WriteLine(listOfIntegers.RemoveAt(5));
            listOfIntegers.ispis();
            listOfIntegers.Clear();
            Console.WriteLine(listOfIntegers.Count); 
            
        }
    }
}
