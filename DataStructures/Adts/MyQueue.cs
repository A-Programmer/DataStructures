using System;
namespace DataStructures.Adts
{
	public class MyQueue<T>
	{
		MyList<T> list = new MyList<T>();

		public int Size()
		{
			return list.Size();
		}

		public MyQueue<T> Add(T v)
		{
			list.PushToEnd(v);
			return this;
		}

		public T Take()
		{
			CheckIfQueueIsNotEmpty();
			return list.RemoveFromStart();
		}

		public T Head()
        {
            CheckIfQueueIsNotEmpty();
            return list.Get(0);
		}

		public T Tail()
        {
            CheckIfQueueIsNotEmpty();
            return list.Get(Size() - 1);
		}


        public override string ToString()
        {
            return list.ToString();
        }

        private void CheckIfQueueIsNotEmpty()
        {
            if (Size() == 0)
                throw new Exception("Queue is empty");
        }


    }
}

