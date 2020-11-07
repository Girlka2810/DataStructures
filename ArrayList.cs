using System;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;

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
                    return "Значение отсутствует";
                }
            }
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
                newLenght = (int)(newLenght);
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
