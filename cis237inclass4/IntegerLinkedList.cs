using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass4
{
    class IntegerLinkedList : IIntegerLinkedList
    {
        //make node class
        protected class Node
        {
            public int Data { get; set; }
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

        public void AddToFront(int IntegerData)
        {
            Node oldHead = _head;
            _head = new Node();
            _head.Data = IntegerData;
            _head.Next = oldHead;
            _size++;
            if (_tail==null)
            {
                _tail = _head;
            }
        }

        public void AddToBack(int IntegerData)
        {
            Node oldTail = _tail;
            _tail = new Node();
            _tail.Data = IntegerData;
            _tail.Next = null;
            _size++;
            if (_head == null)
            {
                _head = _tail;
            } else
            {
                oldTail.Next = _tail;
            }            
        }

        public int RemoveFromFront()
        {
            if (IsEmpty)
            {
                throw new Exception("list is empty");
            }else {  
                int returnData = _head.Data;
                _head = _head.Next;
                _size--;
                return returnData;
            }
        }

        public int RemoveFromBack()
        {
            if (IsEmpty)
            {
                throw new Exception("list is empty");
            }
            int returnData = _tail.Data;
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

        public void AddMainSort(int IntegerData)
        {
            Node newNode = new Node();
            newNode.Data = IntegerData;
            if (this.IsEmpty || _head.Data >= newNode.Data)
            {
                newNode.Next = _head;
                _head = newNode;
                //check to see if tail is null if so set it to head so head and tail are the same
                if (_tail == null)
                {
                    _tail = _head;
                }
            } else
            {
                //set up a node pointer to walk through the list
                Node currentNode = _head;
                while (currentNode.Next != null 
                    && currentNode.Next.Data < newNode.Data)
                {
                    currentNode = currentNode.Next;
                }
                newNode.Next = currentNode.Next;
                currentNode.Next = newNode;
                if (_tail == currentNode)
                {
                    _tail = newNode;
                }
            }
            _size++;
        }

        public int RemoveMaintainSort(int RemoveData)
        {
            if (IsEmpty)
            {
                throw new Exception("list is empty");
            }
            int returnData;
            if (_head == _tail || _head.Data == RemoveData)
            {
                returnData = _head.Data;
                _head = _head.Next;
                if (_head == null)
                {
                    _tail = null;
                }
            }else
            {
                Node currentNode = _head;
                while(currentNode.Next != _tail && currentNode.Next.Data != RemoveData)
                {
                    currentNode = currentNode.Next;
                }
                if (currentNode.Next.Data == RemoveData)
                {
                    returnData = currentNode.Next.Data;                 
                    if (currentNode.Next == _tail)
                    {
                        _tail = currentNode;
                    }
                    currentNode.Next = currentNode.Next.Next;
                }else
                {
                    throw new Exception("Item not found");
                }
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
            } else
            {
                Console.WriteLine("No Data");
            }
        }
    }
}
