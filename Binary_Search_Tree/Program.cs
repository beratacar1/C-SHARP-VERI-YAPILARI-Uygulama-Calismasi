﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BST bst = new BST();

            bst.add(30);
            bst.add(20);
            bst.add(15);
            bst.add(15);
            bst.add(40);
            bst.add(50);
            bst.add(45);
            bst.add(38);
            bst.add(12);
            bst.add(18);
            bst.add(39);

            bst.print();
            bst.delete(40);
            bst.print();
        }
    }
}
