using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeExample
{
    class main
    {
        static void Main()
        {
            Tree tree = new Tree();
            tree.Add(3);
            tree.Add(2);
            tree.Add(1);
            tree.Add(4);
            Console.WriteLine(tree);
        }
    }    
}
