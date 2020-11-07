using System;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

namespace DataStructures
{
    public class ArrayList
    {
        public int Length { get; private set; }
        private int[] _array;
       
        public ArrayList()
        {
            _array = new int[0] ;
            Length = 0;
        }
        public ArrayList(int a)
        {
            _array = new int[1] { a };
            Length = 1;
        }
        public ArrayList(int[]a)
        {
            _array = a;
            Length = a.Length;
        }
        //1
        public void Add(int value)
        {
            if (Length<= _array.Length)
            {
                IncreaseLength();
            }
            _array[Length] = value;
            Length++;
           
        }
        private void IncreaseLength(int number = 1)
        {
            int newLenght = Length;
            while (newLenght <= Length + number)
            {
                newLenght = (int)(newLenght * 1.33 + 1);
            }

            int[] newArray = new int[newLenght];
            Array.Copy(_array, newArray, Length);

            _array = newArray;
        }
        //2
        public void AddFirst(int value)
        {
            if(Length<_array.Length)
            {
                IncreaseLength();
            }
            for (int i = Length; i!=0; i--)
            {
                _array[i] = _array[i - 1];
            }
            _array[0] = value;
            Length++;
        }
        //3
        public void AddByIndex(int index,int value)
        {
            if (index == Length)
            {
                Add(value);
            }
            else if ((Length > 0) && (index < Length) && (index >= 0))
            {
                if (Length < _array.Length)
                {
                    IncreaseLength();
                }
                int[] newArray = new int[Length + 1];
                for (int i = 0; i < Length; i++)
                {
                    newArray[i] = _array[i];
                }
                for (int i = index; i < Length; i++)
                {
                    newArray[i + 1] = _array[i];
                }
                newArray[index] = value;
                _array = newArray;
                Length++;
            }
        }
        private void ReductionLength()
        {
            int newLenght = Length-1;
            while (newLenght >= Length)
            {
                newLenght = (int)(newLenght*0.5);
            }

            int[] newArray = new int[newLenght];
            Array.Copy(_array, newArray, Length-1);

            _array = newArray;
        }
        //4
        public void Remove ()
        {
            if (Length > 0)
            {
                ReductionLength();
                Length--;
            }
        }
        //5
        public void RemoveFirst()
        {
            if (Length > 0)
            {
                int[] newArray = new int[Length];
                for (int i = 0; i < Length - 1; i++)
                {
                    newArray[i] = _array[i + 1];
                }
                _array = newArray;

                ReductionLength();
                Length--;
            }
        }
        //6
        public void RemoveByIndex(int index)
        {
            if ((Length > 0) && (index < Length) && (index >= 0))
            {
                int[] newArray = new int[Length];
                newArray = _array;
                for (int i = index; i < Length - 1; i++)
                {
                    newArray[i] = _array[i + 1];
                }
                _array = newArray;

                ReductionLength();
                Length--;
            }
        }
        //7
        public int GetLength()
        {
            int a = _array.Length;
            return a;
        }
        //8
        public string GetValueByIndex(int index)
        {
            {
                if ((Length > 0) && (index < Length) && (index >= 0))
                {
                    return (_array[index] + "");
                }
                else
                {
                   throw new Exception("Index doesn't exist");
                }
            }
        }
        //9
        public int GetIndexByValue(int value)
        {
            bool check = false;
            int index=0;
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] == value)
                {
                    index = i;
                    check = true;
                }
            }
            if (check == true)
            {
                return index;
            }
            else
            {
                throw new Exception("Value doesn't exist");
            }
        }
        //10
        public void ChangeByIndex (int index,int value)
        {
            if (Length < _array.Length)
            {
                IncreaseLength();
            }
            for (int i=0;i<_array.Length;i++)
            {
                if(index==i)
                {
                    _array[i] = value;
                }
            }
        }
        //11
        public void Reverse()
        {
            for (int i = 0, j = GetLength() - 1; i < j; i++, j--)
            {
                int temp = _array[i];
               _array[i] = _array[j];
                _array[j] = temp;
            }
        }
        //12
        public int FindMaxValue()
        {
            int max = _array[0];
            for (int i=0; i<GetLength();i++)
            {
                if (max < _array[i])
                    max = _array[i];
            }
            return max;
        }
        //13
        public int FindMinValue()
        {
            int min = _array[0];
            for (int i = 0; i < GetLength(); i++)
            {
                if (min > _array[i])
                    min = _array[i];
            }
            return min;
        }
        //14
        public int FindIndexOfMaxValue()
        {
            int max = _array[0];
            int index = 0;
            for (int i = 0; i < _array.Length; i++)
            { if (max <= _array[i])
                {
                    max = _array[i];
                    index = i;
                }
            }
            return index;
        }
        //15
        public int FindIndexOfMinValue()
        {
            int min = _array[0];
            int index = 0;
            for (int i = 0; i < _array.Length; i++)
            {
                if (min >= _array[i])
                {
                    min = _array[i];
                    index = i;
                }
            }
            return index;
        }
        //16
        public void InsertionSortAscendingOrder()
        {
            for (int i = 1; i < _array.Length; i++)
            {
                for (int j = i; j > 0 && _array[j - 1] > _array[j]; j--)
                {
                    int temp = _array[j - 1];
                    _array[j - 1] = _array[j];
                    _array[j] = temp;
                }
            }
        }
        //17
        public void InsertionSortDescendingOrder()
        {
            for (int i = 1; i < _array.Length; i++)
            {
                for (int j = i; j > 0 && _array[j - 1] < _array[j]; j--)
                {
                    int temp = _array[j - 1];
                    _array[j - 1] = _array[j];
                    _array[j] = temp;
                }
            }
        }
        //18
        public void RemoveByValueFirst(int value)
        {

            for (int i = 0; i < Length; i++)
            {
                if (_array[i] == value)
                {
                    RemoveByIndex(i);
                    i--;
                }
            }
        }
        //19
        public void RemoveByValueAll(int value)
        {

            for (int i = 0; i < Length; i++)
            {
                while (_array[i] == value)
                {
                    RemoveByIndex(i);
                    i--;
                }
            }
        }
        //21
        public void AddArray(int []a)
        {
            while (Length + a.Length > _array.Length)
            {
                IncreaseLength();
            }

            for (int i = 0; i < a.Length; i++)
            {
                _array[Length + i] = a[i];
            }

            Length += a.Length;
        }
        public override bool Equals(object obj)
        {
            ArrayList arrayList = (ArrayList)obj;

            if (Length != arrayList.Length)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < Length; i++)
                {
                    if (_array[i] != arrayList._array[i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

    } }
