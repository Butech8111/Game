using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeEx
{
    class Node
    {
        private int value;
        public Node Left { get; private set; }
        public Node Right { get; private set; }
        public Node(int value)
        {
            this.value = value;
            Left = null;
            Right = null;
        }
        public void Add(int newValue)
        {
            if (value >= newValue)
            {
                if (Left == null) Left = new Node(newValue);
                else Left.Add(newValue);
            }
            else
            {
                if (Right == null) Right = new Node(newValue);
                else Right.Add(newValue);
            }
        }
        public Queue<int> GetList(Queue<int> answer)
        {
            Left?.GetList(answer);
            answer.Enqueue(value);
            Right?.GetList(answer);
            return answer;
        }
        public override string ToString()
        {
            return string.Join(", ", GetList(new Queue<int>()));
        }

    }
}