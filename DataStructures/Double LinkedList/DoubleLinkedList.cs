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
        public void Remove()  
        {
            if (Length==0)
            {
                throw new Exception("Nothing to remove");
            }
            if (Length != 0)
            {
                if (Length != 1)
                {
                    end.Previous.Next = null;
                    end = end.Previous;
                    Length--;
                }
                else
                {
                    _root = null;
                    end = null;
                    Length--;
                }
            }
        }
        public void Remove(int quantity)  
        {
            if (Length == 0)
            {
                throw new Exception("Nothing to remove");
            }
            if (quantity>Length)
            {
                throw new Exception("Not enough items to remove");
            }
            if (Length != 0)
            {
                if (quantity < Length)
                {
                    for (int i = 0; i < quantity; i++)
                    {
                        end.Previous.Next = null;
                        end = end.Previous;
                    }
                    Length -= quantity;
                }
                else
                {
                    _root = null;
                    end = null;
                    Length = 0;
                }
            }
        }
        public void RemoveFirst() 
        {
            if (Length != 0)
            {
                _root = _root.Next;
                Length--;
            }
            else
            {
                throw new Exception("Nothing to remove");
            }
        }
        public void RemoveFirst(int quantity)  
        {
            if (Length==0)
            {
                throw new Exception("Not enough items to remove ");
            }
            if (quantity>Length)
            {
                throw new Exception("Nothing to remove");
            }
            if (Length != 0)
            {
                if (Length <= quantity)
                {
                    _root = null;
                    Length = 0;
                }
                else
                {
                    if (quantity != 0)
                    {
                        L2Node tmp = _root;
                        for (int i = 0; i < quantity - 1; i++)
                        {
                            tmp = tmp.Next;
                        }
                        _root = tmp.Next;
                        Length -= quantity;
                    }
                }
            }
        }
        public void RemoveByIndex(int index)  
        {
            if (Length != 0 && index >= 0 && Length > index)
            {
                if (index == 0)
                {
                    RemoveFirst();
                }
                else if (index == Length - 1)
                {
                    Remove();
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
                        tmp.Next = tmp.Next.Next;
                        tmp.Next.Previous = tmp;
                        Length--;
                    }
                    else
                    {
                        L2Node tmp = end;
                        for (int i = Length - 1; i > index; i--)
                        {
                            tmp = tmp.Previous;
                        }
                        tmp.Previous = tmp.Previous.Previous;
                        tmp.Previous.Next = tmp;
                        Length--;
                    }
                }
            }
            else if (Length == 0)
            {
                throw new Exception("Nothing to remove");
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        public void RemoveByIndex(int index, int quantity)  
        {
            if (Length != 0 && Length > index && index >= 0 && quantity >= 0)
            {
                if (index == 0)
                {
                    RemoveFirst(quantity);
                }
                else
                {
                    if (quantity <= Length / 2)
                    {
                        L2Node tmp = _root;
                        for (int i = 1; i < index; i++)
                        {
                            tmp = tmp.Next;
                        }
                        if (Length > index + quantity)
                        {
                            L2Node b = tmp.Next;
                            for (int i = 1; i < quantity; i++)
                            {
                                b = b.Next;
                            }
                            tmp.Next = b.Next;
                            tmp.Next.Previous = tmp;
                            Length -= quantity;
                        }
                        else
                        {
                            tmp.Next = null;
                            end = tmp;
                            Length = index;
                        }
                    }
                    else
                    {
                        if (Length > index + quantity)
                        {
                            L2Node tmp = end;
                            for (int i = Length - 1; i > index + quantity; i--)
                            {
                                tmp = tmp.Previous;
                            }
                            L2Node b = tmp.Previous;
                            for (int i = 1; i < quantity; i++)
                            {
                                b = b.Previous;
                            }
                            tmp.Previous = b.Previous;
                            tmp.Previous.Next = tmp;
                            Length -= quantity;
                        }
                        else
                        {
                            L2Node tmp = end;
                            for (int i = Length; i > index; i--)
                            {
                                tmp = tmp.Previous;
                            }
                            tmp.Next = null;
                            end = tmp;
                            Length = index;
                        }
                    }
                }
            }
            else
            {
                if (Length == 0)
                {
                    throw new Exception("Nothing to remove");
                }
                if (quantity<=0)
                {
                    throw new Exception("Quantity should be more than zero");
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }
        public int GetIndexByValue(int value)
        {
            L2Node tmp = _root;
            if (Length == 0)
            {
                throw new Exception("List is empty");
            }
            
            for (int i = 0; i < Length; i++)
            {
                if (tmp.Value == value)
                { 
                    return i;
                }
                tmp = tmp.Next;
            }
            return -1;
        }
        public int GetValueByIndex(int index)
        {
            int value = 0;
            if (Length == 0)
            {
                throw new Exception("List is empty");
            }

                L2Node tmp = _root;
            for (int i = 0; i < Length; i++)
            {
                if (i == index)
                {
                    value = tmp.Value;
                    return value;
                }
                tmp = tmp.Next;
            }
            return -1;
        }
        public int[] ReturnArray()
        {
            int[] array = new int[Length];
            if (Length != 0)
            {
                int i = 0;
                L2Node tmp = _root;
                do
                {
                    array[i] = tmp.Value;
                    i++;
                    tmp = tmp.Next;
                }
                while (tmp != null);
            }
            return array;
        }
        public int ReturnLength  
        {
            get { return Length; }
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
