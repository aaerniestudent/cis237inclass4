using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass4
{
    interface IGenericLinkedList<T>
    {

        void AddToFront(T Data);
        void AddToBack(T Data);
        T RemoveFromFront();
        T RemoveFromBack();

        void Display();

        bool IsEmpty { get; }
        int Size { get; }
    }
}
