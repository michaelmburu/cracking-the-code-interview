using System;
namespace CrackingTheCodeInterview
{
    public class Queue<T>
    {
        private class QueueNode<T>
        {
            T data;
            QueueNode<T> next;

            public QueueNode(T data)
            {
                this.data = data;
            }


             QueueNode<T> first;
             QueueNode<T> last;

            public void add(T item)
            {
                QueueNode<T> t = new QueueNode<T>(item);
                if (last != null)
                {
                    last.next = t;
                }
            }

            public T remove()
            {
                if(first == null)
                {
                    throw new Exception();
                }
                T data = first.data;
                first = first.next;
                if(first == null)
                {
                    last = null;
                }


                return data;
            }

            public T peek()
            {
                if(first == null)
                {
                    throw new Exception();
                }

                return first.data;
            }

            public bool isEmpty()
            {
                return first == null;
            }
        }

    
    }
}

