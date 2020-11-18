using DataStructures.DoubleLinkedList;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.DoubleLinkedList
{
    public class DoubleLinkedList: DataStructures.IList
    {
        private L2Node _root;
        private L2Node end;
        private int Length;

        public DoubleLinkedList()
        {
            _root = null;
            end = null;
            Length = 0;
        }
        public DoubleLinkedList(int a)
        {
            _root = new L2Node(a);
            end = _root;
            Length = 1;
        }
        public DoubleLinkedList(int[] array)
        {
            if (array.Length != 0)
            {
                _root = new L2Node(array[0]);
                L2Node tmp = _root;
                for (int i = 1; i < array.Length; i++)
                {
                    tmp.Next = new L2Node(array[i]);
                    tmp.Next.Previous = tmp;
                    tmp = tmp.Next;
                }
                end = tmp;
                Length = array.Length;
            }
            else
            {
                _root = null;
                end = null;
                Length = 0;
            }
        }
        public void Add(int value) 
        {
                if (Length == 0)
                {
                    _root = new L2Node(value);
                    end = _root;
                    Length = 1;
                }
                else
                {
                    end.Next = new L2Node(value);
                    end.Next.Previous = end;
                    end = end.Next;
                    Length++;
                }
        }
        public void Add(int[] array) 
        {
            if (Length == 0)
            {
                if (array.Length != 0)
                {
                    _root = new L2Node(array[0]);
                    L2Node tmp = _root;
                    for (int i = 1; i < array.Length; i++)
                    {
                        tmp.Next = new L2Node(array[i]);
                        tmp.Next.Previous = tmp;
                        tmp = tmp.Next;
                    }
                    end = tmp;
                    Length = array.Length;
                }
                else
                {
                    _root = null;
                    end = null;
                    Length = 0;
                }
            }
            else
            {
                if (array.Length != 0)
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        end.Next = new L2Node(array[i]);
                        end.Next.Previous = end;
                        end = end.Next;
                    }
                    Length += array.Length;
                }
            }
        }
        public void AddFirst(int value)
        {
            if (Length == 0)
            {
                _root = new L2Node(value);
                end = _root;
                Length = 1;
            }
            else 
            {
                _root.Previous = new L2Node(value);
                _root.Previous.Next = _root;
                _root = _root.Previous;
                Length++;
            }
        }
        public void AddFirst(int [] array)
        {
            if (Length == 0)
            {
                if (array.Length != 0)
                {
                    _root = new L2Node(array[0]);
                    L2Node tmp = _root;
                    for (int i = 1; i < array.Length; i++)
                    {
                        tmp.Next = new L2Node(array[i]);
                        tmp.Next.Previous = tmp;
                        tmp = tmp.Next;
                    }
                    end = tmp;
                    Length = array.Length;
                }
                else
                {
                    _root = null;
                    end = null;
                    Length = 0;
                }
            }
            else
            {
                if (array.Length != 0)
                {
                    L2Node tmp = new L2Node(array[0]);
                    L2Node b = tmp;
                    for (int i = 1; i < array.Length; i++)
                    {
                        tmp.Next = new L2Node(array[i]);
                        tmp.Next.Previous = tmp;
                        tmp = tmp.Next;
                    }
                    tmp.Next = _root;
                    _root.Previous = tmp;
                    _root = b;
                    Length += array.Length;
                }
            }
        }
        public void AddByIndex (int index, int value)
        {
            if (index >= 0)
            {
                if (Length == 0 || index >= Length)
                {
                    Add(value);
                }
                else
                {
                    if (index == 0)
                    {
                        AddFirst(value);
                    }
                    else
                    {
                        if (index <= Length / 2)
                        {
                            L2Node tmp = _root;
                            for (int i = 1; i < index; i++)
                            {
                                tmp = tmp.Next;
                            }
                            L2Node b = tmp.Next;
                            tmp.Next = new L2Node(value);
                            tmp.Next.Previous = tmp;
                            tmp = tmp.Next;
                            tmp.Next = b;
                            b.Previous = tmp;
                            Length++;
                        }
                        else
                        {
                            L2Node tmp = end;
                            for (int i = Length - 1; i > index; i--)
                            {
                                tmp = tmp.Previous;
                            }
                            L2Node b = tmp.Previous;
                            tmp.Previous = new L2Node(value);
                            tmp.Previous.Next = tmp;
                            tmp = tmp.Previous;
                            tmp.Previous = b;
                            b.Next = tmp;
                            Length++;
                        }
                    }
                }
            }
        }
        public void AddByIndex(int index, int [] addArray)
        {
            if (index >= 0)
            {
                if (Length == 0 || index >= Length)
                {
                    Add(addArray);
                }
                else
                {
                    if (index == 0)
                    {
                        AddFirst(addArray);
                    }
                    else
                    {
                            if (index <= Length / 2)
                            {
                                L2Node tmp = _root;
                                for (int i = 1; i < index; i++)
                                {
                                    tmp = tmp.Next;
                                }
                                L2Node b = tmp.Next;
                                for (int i = 0; i < addArray.Length; i++)
                                {
                                    tmp.Next = new L2Node(addArray[i]);
                                    tmp.Next.Previous = tmp;
                                    tmp = tmp.Next;
                                }
                                tmp.Next = b;
                                b.Previous = tmp;
                                Length += addArray.Length;
                            }
                            else
                            {
                                L2Node tmp = end;
                                for (int i = Length - 1; i > index; i--)
                                {
                                    tmp = tmp.Previous;
                                }
                                L2Node b = tmp.Previous;
                                for (int i = addArray.Length - 1; i >= 0; i--)
                                {
                                    tmp.Previous = new L2Node(addArray[i]);
                                    tmp.Previous.Next = tmp;
                                    tmp = tmp.Previous;
                                }
                                tmp.Previous = b;
                                b.Next = tmp;
                                Length += addArray.Length;
                            }
                    }
                }
            }
        }
        public override bool Equals(object obj)
        {
            DoubleLinkedList doubleLinkedList = (DoubleLinkedList)obj;

            if (Length != doubleLinkedList.Length)
            {
                return false;
            }

            L2Node tmp1 = _root;
            L2Node tmp2 = doubleLinkedList._root;

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

            L2Node tmp = _root;
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
        public int GetLength()
        {
            return Length;
        }

    }
}
