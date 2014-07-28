using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
    public class StactAndQueue
    {
        Stack<int> stack1 = new Stack<int>();
        Stack<int> stack2 = new Stack<int>();

        public void Push(int data)
        {
            while (stack2.Count > 0)
            {
                stack1.Push(stack2.Pop());
            }
            stack1.Push(data);
        }

        public int Pop()
        {
            while (stack1.Count > 0)
            {
                stack2.Push(stack1.Pop());
            }
            return stack2.Pop();
        }

        public int Size()
        {
            return stack1.Count + stack2.Count;
        }
    }

}
