using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteGUI
{
    class Node<T>
    {

        private Node<T> next;
        private Node<T> previous;
        private T data;

        public Node(T data)
        {
            this.data = data;
            this.next = null;
            this.previous = null;
        }

        public Node<T> GetNext()
        {
            return next;
        }

        public void SetNext(Node<T> next)
        {
            this.next = next;
        }

        public Node<T> GetPrevious()
        {
            return previous;
        }

        public void SetPrevious(Node<T> previous)
        {
            this.previous = previous;
        }

        public T GetData()
        {
            return data;
        }

        public void SetData(T data)
        {
            this.data = data;
        }
    }
}
