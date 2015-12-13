using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PongGame
{
    interface IGenericList<T>: IEnumerable<T>
    {
        void Add(T item);
        bool Remove(T item);
        bool RemoveAt(int index);
        T GetElement(int index);
        int IndexOf(T item);
        int Count { get; }
        void Clear();
        bool Contains(T item);
    }
}
