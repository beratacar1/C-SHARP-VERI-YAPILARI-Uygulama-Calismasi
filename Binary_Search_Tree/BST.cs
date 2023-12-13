using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    internal class BST
    {
        Node root;

        public BST() { root = null; }

        public void delete(int a)
        {
            root = deleteRecursive(root, a);
        }

        private Node deleteRecursive(Node current, int a)
        {
            if (current == null) return current;
            if (current.data > a)
            {
                current.lc = deleteRecursive(current.lc, a);

            }
            if (current.data < a)
            {
                current.rc = deleteRecursive(current.rc, a);
            }
            else
            {
                if (current.lc == null) return current.rc;
                if (current.rc == null) return current.lc;

                int leftMax = findMax(current.lc);
                current.data = leftMax;
                current.lc = deleteRecursive(current.lc, leftMax);
            }
            return current;
        }

        public int findMax(Node current)
        {
            int max = current.data;
            while (current.rc != null)
            {
                max = current.rc.data;
                current = current.rc;
            }
            return max;
        }

        public void preOrder()
        {
            preOrderRecursive(root);
        }

        private void preOrderRecursive(Node current)
        {
            if (current != null)
            {
                Console.Write(current.data + " ");
                preOrderRecursive(current.lc);
                preOrderRecursive(current.rc);
            }
        }

        public void inOrder()
        {
            inOrderRecursive(root);
        }

        private void inOrderRecursive(Node current)
        {
            if (current != null)
            {
                inOrderRecursive(current.lc);
                Console.Write(current.data + " "); 
                inOrderRecursive(current.rc);
            }
        }

        public void postOrder()
        {
            postOrderRecursive(root);
        }

        private void postOrderRecursive(Node current)
        {
            if (current != null)
            {
                postOrderRecursive(current.lc);
                postOrderRecursive(current.rc);
                Console.WriteLine(current.data + " ");
            }
        }

        public void add(int a) { root = addRecursive(root, a); }
        private Node addRecursive(Node current, int a)
        {
            if (current == null) { current = new Node(a); return current; }
            else if (current.data > a)
            {
                current.lc = addRecursive(current.lc, a);
            }
            else if (current.data < a)
            {
                current.rc = addRecursive(current.rc, a);
            }
            return current;
        }

        public Node search(int s)
        {
            return searchRecursive(root, s);
        }
        private Node searchRecursive(Node current, int s)
        {
            if (current == null || current.data == s) return current;
            if (current.data < s)
            {
                return searchRecursive(current.rc, s);

            }
            return searchRecursive(current.lc, s);
        }
        public void print() { printRecursive(root, ""); }
        private void printRecursive(Node current, String indent)
        {
            Console.WriteLine(indent + current.data); 
            if (current.lc != null)
            {
                printRecursive(current.lc, indent + "    ");
            }
            if (current.rc != null)
                printRecursive(current.rc, indent + "    ");
        }
    }
}
