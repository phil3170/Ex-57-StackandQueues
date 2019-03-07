using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_57_StackandQueues
{
    public class MyQueue<T>
    {
        private class Node
        {
            public T Data { get; set; }
            public Node Next { get; set; }
        }
        private Node Head { get; set; }
        private Node Tail { get; set; }

        public MyQueue()
        {
            Node n = new Node(data=new T());
        }

        public void Enqueue(T item)
        {
        }

        public T Dequeue()
        {
            if (IsEmpty())
            {
                return default(T);
            }
            else
            {
                Node n = Head;
                Head = Head.Next;
                if (Head == null)
                {
                    Tail = null;
                }
                n.Next = null
                return n.Data;
            }
        }

        public int Count()
        {

        }

        public Boolean IsEmpty()
        {
            return (Head == null);
        }
    }

}
