using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.LinkedList
{

    public class LinkedList
    {
        public int Length { get; private set; }
        private Node _root;

        public LinkedList()
        {
            Length = 0;
            _root = null;
        }
        public LinkedList(int[] array)
        {
            Length = array.Length;

            if (array.Length != 0)
            {
                _root = new Node(array[0]);
                Node tmp = _root;
                for (int i = 1; i < array.Length; i++)
                {
                    tmp.Next = new Node(array[i]);
                    tmp = tmp.Next;
                }
            }
            else
            {
                _root = null;
            }
        }

        public int this[int index]
        {
            get
            {
                Node tmp = _root;
                for (int i = 0; i < index; i++)
                {
                    tmp = tmp.Next;
                }
                return tmp.Value;
            }

            set
            {
                Node tmp = _root;
                for (int i = 0; i < index; i++)
                {
                    tmp = tmp.Next;
                }
                tmp.Value = value;
            }
        }

        public void Add(int value)
        {
            if (Length == 0)
            {
                Node newNode = new Node(value);
                _root = newNode;
                newNode.Next = null;
                Length = 1;
            }
            else
            {
                Node tmp = _root;
                for (int i = 0; i < Length - 1; i++)
                    tmp = tmp.Next;
                Node newNode = new Node(value);
                tmp.Next = newNode;
                Length++;
            }
        }
        public void Add(int []addArray)
        {
            if (Length == 0 && addArray.Length != 0)
                _root = new Node(addArray[0]);

            Node tmp = _root;
            for (int i = 0; i < Length - 1; i++)
            {
                tmp = tmp.Next;
            }
            for (int i = 0; i < addArray.Length; i++)
            {
                tmp.Next = new Node(addArray[i]);
                tmp = tmp.Next;
            }

            if (Length == 0 && addArray.Length != 0)
                _root = _root.Next;

            Length += addArray.Length;
        }
        public void AddFirst(int value)
        {
            Node current = new Node(value);
            current.Next = _root;
            _root = current;
            Length++;
        }
        public void AddFirst(int[] addArray)
        {
            if (Length == 0 && addArray.Length != 0)
            {
                _root = new Node(addArray[0]);
            }
            Node current = _root;
            for (int i = 0; i < Length - 1; i++)
            {
                _root = new Node(addArray[i]);
                current = _root;
                _root = current.Next;
            }
            for (int i = 0; i < addArray.Length; i++)
            {
                
                current = new Node(addArray[i]);
                _root = current.Next;
            }

            if (Length == 0 && addArray.Length != 0)
                current = _root;
                _root = current.Next;

            Length += addArray.Length;
        }

        public void AddByIndex(int index, int value)
        {
            if (index < 0 || index > Length)
            {
                throw new IndexOutOfRangeException();
            }
            if (index != 0)
            {
                Node current = _root;
                for (int i = 0; i < index - 1; i++)
                {
                    current = current.Next;
                }
                Node tmp = new Node(value);
                tmp.Next = current.Next;
                current.Next = tmp;
            }
            else
            {
                Node tmp = new Node(value);
                tmp.Next = _root;
                _root = tmp;
            }
            Length++;
        }

        public override bool Equals(object obj)
        {
            LinkedList linkedList = (LinkedList)obj;

            if (Length != linkedList.Length)
            {
                return false;
            }

            Node tmp1 = _root;
            Node tmp2 = linkedList._root;

            for (int i = 0; i < Length; i++)
            {
                if (tmp1.Value != tmp2.Value)
                {
                    return false;
                }
                tmp1 = tmp1.Next;
                tmp2 = tmp2.Next;
            }
            return true;
        }
        public override string ToString()
        {
            string s = "";

            Node tmp = _root;
            for (int i = 0; i < Length; i++)
            {
                s += tmp.Value + ";";
                tmp = tmp.Next;
            }
            return s;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}

