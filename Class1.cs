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
            _array = new int[3];
            Length = 0;
        }
        public void Add(int value)
        {
            if (Length > _array.Length)
            {
                RizeSize();
            }
            _array[Length] = value;
            Length++;
        }
        //public override bool Equals(object obj)
        //{
        //    ArrayList arrayList = (ArrayList)obj;
        //    //arrayList._array;
        //    return true;
        //}

        private void RizeSize(int size = 1)
        {
            int newLength = _array.Length;
            while (newLength < Length + size)
            {
                newLength = (int)(newLength * 1.33d + 1);
            }

            int[] newArray = new int[newLength];
            Array.Copy(_array, newArray, _array.Length);
            _array = newArray;
        }
    } }
