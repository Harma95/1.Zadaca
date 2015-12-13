using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Zadatak2
{
    class GenericList<T> : IGenericList<T>
    {
        private int index = 0;
        private int length;
        private T[] internalStorage=null;

        public GenericList()
        {
            internalStorage = new T[4];
        }
        public GenericList(int size)
        {
            internalStorage = new T[size];
        }

        public void Add(T element)
        {
            length=internalStorage.Length;
            if (length==index)
            {
                T []temp=internalStorage;
                internalStorage = new T[internalStorage.Length*2];
                for (int i = 0; i < index; i++)
                {
                    internalStorage[i] = temp[i];
                }
            }
            internalStorage[index] = element;
            index++;
        }

        public bool Remove(T item)
        {
            for (int i = 0; i < index; i++)
            {
                if (internalStorage[i].Equals(item))
                {
                    for (int j = i; j <index-1 ; j++)
                    {
                        internalStorage[j] = internalStorage[j + 1];
                    }
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

        public T GetElement(int index)
        {
            if (index < 0 || index > this.index)
                throw new IndexOutOfRangeException("Index is not in range");
            return internalStorage[index];
        }

        public int IndexOf(T item)
        {
            int counter=0;
            for (int i = 0; i < index; i++)
            {
                if (item.Equals( internalStorage[i]))
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
                internalStorage[i] = default(T);
            }
            index = 0;
        }

        public bool Contains(T item)
        {
            for (int i = 0; i < index; i++)
            {
                if (internalStorage[i].Equals(item))
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
            Console.WriteLine(index);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new GenericListEnumerator<T>(this);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        private class GenericListEnumerator<T> : IEnumerator<T>
        {
            private int currentIndex=-1;
            GenericList<T> list;
            public GenericListEnumerator(GenericList<T> list)
            {
                this.list = list;
            }
            public T Current
            {
                get {return list.internalStorage[currentIndex]; }
            }

            public void Dispose()
            {
                Console.WriteLine("Nothing to dispose");
            }

            object IEnumerator.Current
            {   
                get { return Current; }
            }

            public bool MoveNext()
            {
                currentIndex++;
                if (currentIndex < list.index)
                    return true;
                return false;
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }
        }


    }
}

