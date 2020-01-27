using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeEx
{
    class Tree
    {
        private Node Root;
        public Tree()
        {
            Root = null;
        }
        public void Add(int newValue)
        {
            if (Root == null)
            {
                Root = new Node(newValue);
            }
            else
            {
                Root.Add(newValue);
            }
        }
        public override string ToString()
        {
            if (Root == null)
                return "No tree";
            else
                return Root.ToString();
        }
    }
}