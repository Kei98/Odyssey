using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteGUI
{
    class SimpleLL<T>
    {

        private Node<T> head;
        private int size;

        private SimpleLL<T> nombres = new SimpleLL<T>();


        public SimpleLL()
        {
            this.head = null;
            this.size = 0;
        }

        public SimpleLL<T> GetSimpleLL()
        {
            return nombres;
        }

        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);
            if (size == 0)
            {
                head = node;
                size++;
            }
            else
            {
                Node<T> temp = head;
                while (temp.GetNext() != null)
                {
                    temp = temp.GetNext();
                }
                temp.SetNext(node);
                size++;
            }
        }

        public T GetDataByIndex(int index)
        {
            Node<T> temp = this.GetHead();

            while (index != 0)
            {
                temp = temp.GetNext();
                index--;
            }
            System.Console.WriteLine("El dato es: " + temp.GetData());
            return temp.GetData();
        }

        public void SetDataByIndex(int index, T data)
        {
            Node<T> temp = this.GetHead();
            while (index != 0)
            {
                temp = temp.GetNext();
                index--;
            }
            temp.SetData(data);
        }

        public void Delete(T data)
        {
            if (head.GetData().Equals(data))
            {
                head = head.GetNext();
            }
            else
            {
                Node<T> current = this.head;
                while (current != null)
                {
                    if (current.GetNext().GetData().Equals(data))
                    {
                        current.SetNext(current.GetNext().GetNext());
                        break;
                    }
                    current = current.GetNext();
                }
            }
        }

        public void PrintL()
        {
            int i = 0;
            if (size == 0)
            {
                System.Console.WriteLine("Empty");
            }
            else
            {
                Node<T> temp = head;
                while (temp.GetNext() != null)
                {
                    System.Console.WriteLine("Node " + i + ":" + temp.GetData());
                    i++;
                    temp = temp.GetNext();
                }
                System.Console.WriteLine("Node " + i + ":" + temp.GetData());
            }
        }

        public void DeleteValue(int i)
        {
            if (this.Empty())
            {
                PrintL();
            }
            else
            {
                Node<T> temp = this.head;
                if (i == 0)
                {
                    this.head = this.head.GetNext();
                    size--;
                }
                else if (i < size)
                {
                    int j = 0;
                    while ((i - 1) != j)
                    {
                        temp = temp.GetNext();
                        j++;
                    }
                    temp.SetNext(temp.GetNext().GetNext());
                    this.size--;
                }
                else
                {
                    System.Console.WriteLine("The element was not found.");
                }
            }
        }
        /**
        public SimpleLL<T> GetSimpleLL()
        {
            return usersInfo;
        }
    */
        public void Clear()
        {
            head = null;
            this.SetSize(0);
        }

        private Boolean Empty()
        {
            return false;
        }

        public Node<T> GetHead()
        {
            return head;
        }

        private void SetHead(Node<T> head)
        {
            this.head = head;
        }

        private void SetSize(int size)
        {
            this.size = size;
        }

        public int GetSize()
        {
            return size;
        }


    }
}
