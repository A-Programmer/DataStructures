using System;

namespace DataStructures.Adts
{
	public class MyList<T>
	{
        private T[] array;
        private int occupied = 0;

        public MyList()
        {
            array = new T[0];
            occupied = 0;
        }

        public static MyList<T> Of(params int[] members)
        {
            MyList<T> list = new MyList<T>(members.Length);
            Array.Copy(members, list.array, members.Length);
            return list;
        }

        public MyList(int size)
        {
            array = new T[size];
            occupied = size;
        }

        public int Size()
        {
            return occupied;
        }

        public T Get(int index)
        {
            if(index < 0 || index >= occupied)
            {
                throw new Exception("Index is out of the range");
            }
            return array[index];
        }

        public MyList<T> Set(int index, T value)
        {
            if (index < 0 || index > occupied)
            {
                throw new Exception("Index is out of the range");
            }
            array[index] = value;

            return this;
        }



        public MyList<T> Insert(int index, T value)
        {
            if (index < 0 || index > occupied)
                throw new ArgumentException("index can not be out of range.");

            CapacityCheck();

            //Not optimized
            //for(var i = occupied - 1; i >= index; i--)
            //{
            //    array[i + 1] = array[i];
            //}

            if (index != occupied)
            {
                Array.ConstrainedCopy(array, index, array, index + 1, occupied - index);
            }

            Set(index, value);
            occupied++;

            return this;
        }

        public MyList<T> PushToEnd(T value)
        {
            return Insert(occupied, value);
        }

        public MyList<T> PushToStart(T value)
        {
            return Insert(0, value);
        }

        public MyList<T> Add(T value)
        {
            PushToEnd(value);

            return this;
        }

        public T Remove(int index)
        {
            var currentValue = array[index];

            if (index < 0 || index >= occupied)
            {
                throw new ArgumentException("Index can not be out of the range.");
            }

            // if(index < occupied - 1)
            // {
            //     Array.Copy(array, index + 1, array, index, occupied - (index + 1));
            // }
            for (var i = index; i < occupied - 1; i++)
            {
                array[i] = array[i + 1];
            }

            occupied--;
            return currentValue;
        }

        public T RemoveFromStart()
        {
            return Remove(0);
        }

        public T RemoveFromEnd()
        {
            return Remove(occupied - 1);
        }



        private void CapacityCheck()
        {
            if (array.Length == occupied)
            {
                Array.Resize(ref array, array.Length + 1);
            }
        }

        public override string ToString()
        {
            var stringArray = "[";
            for(var i = 0; i < occupied; i++)
            {
                stringArray += array[i] + ",";
            }
            //foreach (var item in array)
            //{
            //    stringArray += item + ", ";
            //}
            if (stringArray.Length > 0)
                stringArray = stringArray.Remove(stringArray.LastIndexOf(','));

            stringArray += "]";

            return stringArray;
        }

    }
}

