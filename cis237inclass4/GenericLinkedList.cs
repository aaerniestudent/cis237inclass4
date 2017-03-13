using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass4
{
    class GenericLinkedList<T> : IGenericLinkedList<T>
    {

        protected class Node
        {
            public T Data { get; set; }
            public Node Next { get; set; }
        }

        protected Node _head;
        protected Node _tail;
        protected int _size;

        public bool IsEmpty
        {
            get
            {
                return _head == null;
            }
        }

        public int Size
        {
            get
            {
                return _size;
            }
        }

        public void AddToFront(T Data)
        {
            Node oldHead = _head;
            _head = new Node();
            _head.Data = Data;
            _head.Next = oldHead;
            _size++;
            if (_tail == null)
            {
                _tail = _head;
            }
        }

        public void AddToBack(T Data)
        {
            Node oldTail = _tail;
            _tail = new Node();
            _tail.Data = Data;
            _tail.Next = null;
            _size++;
            if (_head == null)
            {
                _head = _tail;
            }
            else
            {
                oldTail.Next = _tail;
            }
        }

        public T RemoveFromFront()
        {
            if (IsEmpty)
            {
                throw new Exception("list is empty");
            }
            else
            {
                T returnData = _head.Data;
                _head = _head.Next;
                _size--;
                return returnData;
            }
        }

        public T RemoveFromBack()
        {
            if (IsEmpty)
            {
                throw new Exception("list is empty");
            }
            T returnData = _tail.Data;
            if (_head == _tail)
            {
                _head = null;
                _tail = null;
            }
            else
            {
                Node currentNode = _head;
                while (currentNode.Next != _tail)
                {
                    currentNode = currentNode.Next;
                }
                _tail = currentNode;
                _tail.Next = null;
            }
            _size--;
            return returnData;
        }
               
        public void Display()
        {
            if (_head != null)
            {
                Node currentNode = _head;
                Console.WriteLine("The list is:");
                while (currentNode != null)
                {
                    Console.WriteLine(currentNode.Data);
                    currentNode = currentNode.Next;
                }
            }
            else
            {
                Console.WriteLine("No Data");
            }
        }
    }
}

