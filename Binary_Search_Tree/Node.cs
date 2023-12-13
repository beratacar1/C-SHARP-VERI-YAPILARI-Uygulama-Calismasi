using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    internal class Node
    {
        public int data;
        public Node lc; // lc = left child
        public Node rc; // rc = right child


        public Node(int a)
        {
            data = a;
            lc = null;
            rc = null;
        }

        
        public String toString()
        {
            return "Node{" +
                    "data=" + data +
                    ", lc=" + lc +
                    ", rc=" + rc +
                    '}';
        }
    }
}
