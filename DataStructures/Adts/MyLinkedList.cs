using System;
namespace DataStructures.Adts
{
	public class MyLinkedList<T>
	{
        private Node<T> _head = null;
        private Node<T> _tail = null;
        private int _size = 0;

        public int Size()
        {
            return _size;
        }

        public void AddToStart(T value)
        {
            this._head = new Node<T>(value, this._head);
            if (this.IsEmpty())
            {
                this._tail = this._head;
            }
            this._size++;
        }

        public void AddToEnd(T value)
        {
            var node = new Node<T>(value, null);
            if (this.IsEmpty())
            {
                this._head = node;
            }
            else
            {
                this._tail.SetNext(node);
            }
            this._tail = node;
            this._size++;
        }

        public T Get(int i)
        {
            if (IsEmpty() || i < 0)
            {
                throw new Exception("Not such element found.");
            }

            if (i == 0)
                return this._head.GetValue();

            if (i == _size - 1)
                return this._tail.GetValue();

            Node<T> current = this._head;
            int index = 0;

            while (index != i)
            {
                current = current.GetNext();
                index++;
                if (current == null)
                {
                    throw new Exception("Not such element found.");
                }
            }

            return current.GetValue();
        }

        public void Remove(int index)
        {
            if (this.IsEmpty())
                throw new Exception("No such element found.");

            var prev = _head;
            var current = _head.GetNext();

            for (var i = 1; i < index; i++)
            {
                if (current == null)
                    throw new Exception("No such element found");
                prev = current;
                current = current.GetNext();
            }
            prev.SetNext(current.GetNext());
            current.SetNext(null);
        }

        // TODO: Implementing Insert





        private bool IsEmpty()
        {
            return this._size == 0;
        }



        private class Node<T>
        {
            private T _value;
            private Node<T> _next;

            public Node(T value, Node<T> next)
            {
                this._value = value;
                this._next = next;
            }

            public T GetValue()
            {
                return this._value;
            }

            public Node<T> GetNext()
            {
                return this._next;
            }

            public void SetValue(T value)
            {
                this._value = value;
            }

            public void SetNext(Node<T> next)
            {
                this._next = next;
            }
        }
    }
}

