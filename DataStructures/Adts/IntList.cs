using System;
namespace DataStructures
{
    public class IntList
    {
        private int[] array;
        private int occupied;

        public IntList()
        {
            array = new int[0];
            occupied = 0;
        }

        public IntList(int size)
        {
            array = new int[size];
            occupied = size;
        }

        public static IntList Of(params int[] members)
        {
            var list = new IntList(members.Length);
            Array.Copy(members, list.array, members.Length);

            return list;
        }

        public int Size()
        {
            return occupied;
        }


        public override string ToString()
        {
            var stringArray = "[";
            foreach (var item in array)
            {
                stringArray += item + ", ";
            }
            if (stringArray.Length > 0)
                stringArray = stringArray.Remove(stringArray.LastIndexOf(','));

            stringArray += "]";

            return stringArray;
        }


    }
}

