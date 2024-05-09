using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Program
{
    public class Program
    {
        
        public class MyStack
        {
            ArrayList heap = new ArrayList();

            public void Push(object obj)
            {
                if (obj == null)
                    throw new InvalidOperationException("Null detected");

                heap.Add(obj);
            }

            public object Pop()
            {
                
                if (heap.Count == 0)
                    throw new InvalidOperationException("Heap empty");

                object element = heap[0];
                heap.Remove(element);
                
                return element;
                
            }

            public void Clear()
            {
                heap.Clear();
            }
        }

        static void Main(string[] args)
        {
            var stack = new MyStack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }
    }

}