using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    class IntegerList : IIntegerList
    {
        private int index = 0;
        private int length;
        private int[] internalStorage=null;

        public IntegerList()
        {
            internalStorage = new int[4];
        }
        public IntegerList(int size)
        {
            internalStorage = new int[size];
        }

        public void Add(int element)
        {
            length=internalStorage.Length;
            if (length==index)
            {
                int []temp=internalStorage;
                internalStorage = new int[internalStorage.Length*2];
                for (int i = 0; i < index; i++)
                {
                    internalStorage[i] = temp[i];
                }
            }
            internalStorage[index] = element;
            index++;
        }

        public bool Remove(int item)
        {
            for (int i = 0; i < index; i++)
            {
                if (internalStorage[i] == item)
                {
                    for (int j = i; j <index-1 ; j++)
                    {
                        internalStorage[j] = internalStorage[j + 1];
                    }
                    internalStorage[index] = 0;
                    this.index--;
                    return true;
                }
            }
            return false;
        }

        public bool RemoveAt(int index)
        {
            if (index < 0 || index > this.index)
                return false;
            for (int j = index-1; j < this.index - 1; j++)
            {
                internalStorage[j] = internalStorage[j + 1];
            }
            this.index--;
            return true;
        }

        public int GetElement(int index)
        {
            if (index < 0 || index > this.index)
                throw new IndexOutOfRangeException("Index is not in range");
            return internalStorage[index];
        }

        public int IndexOf(int item)
        {
            int counter=0;
            for (int i = 0; i < index; i++)
            {
                if (item == internalStorage[i])
                    counter++;
            }
            return counter;
        }

        public int Count
        {
            get { return index ; }
        }

        public void Clear()
        {
            for (int i = 0; i < index; i++)
            {
                internalStorage[i] = 0;
            }
            index = 0;
        }

        public bool Contains(int item)
        {
            for (int i = 0; i < index; i++)
            {
                if (internalStorage[i] == item)
                    return true;
            }
            return false;
        }
        public void ispis()
        {
            for (int i = 0; i < index; i++)
            {
                Console.WriteLine(internalStorage[i]);
            }
            Console.WriteLine(internalStorage.Length);
        }
    }
}
