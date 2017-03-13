using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass4
{
    class Program
    {
        static void Main(string[] args)
        {
            //just ignoring the iIntegerLinkedList
            IntegerLinkedList linkedList = new IntegerLinkedList();

            linkedList.AddMainSort(5);
            linkedList.AddMainSort(3);
            linkedList.AddMainSort(4);
            linkedList.AddMainSort(2);
            linkedList.AddMainSort(1);

            linkedList.Display();

            linkedList.RemoveMaintainSort(3);
            linkedList.RemoveMaintainSort(1);

            linkedList.Display();

            IGenericLinkedList<string> genericLinkedList = new GenericLinkedList<string>();

            genericLinkedList.AddToFront("A");
            genericLinkedList.AddToFront("B");
            genericLinkedList.AddToFront("C");
            genericLinkedList.AddToBack("D");
            genericLinkedList.AddToBack("E");
            genericLinkedList.AddToBack("F");           

            genericLinkedList.Display();

            genericLinkedList.RemoveFromBack();
            genericLinkedList.RemoveFromFront();

            genericLinkedList.Display();
        }
    }
}
