using System;
namespace DataStructures.Adts
{
	public class MyStack<T>
	{
		private MyList<T> list = new MyList<T>();


		public int Size()
		{
			return list.Size();
		}

		public T Push(T v)
		{
			return list.PushToEnd(v);
		}

		public T Pop()
		{
			CheckStackIsNotEmpty();
			return list.RemoveFromEnd();
		}

		public T Top()
        {
            CheckStackIsNotEmpty();
            return list.Get(Size() - 1);
		}

		private void CheckStackIsNotEmpty()
		{
			if (Size() == 0)
				throw new Exception("Stack is empty");
		}

        public override string ToString()
        {
			return list.ToString();
        }
    }
}

