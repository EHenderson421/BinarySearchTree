using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeProject
{
    class Tree
    {
        // Member Variables
        Node head;
        Node current;

        //Constructor
        public Tree(int data)
        {
            head = new Node(data);
        }

        //Member Methods
        public void Add(int data)
        {
            Node toAdd = new Node(data);

            if (head == null)
            {
                head = toAdd;
                return;
            }

            current = head;
            current = Traverse(current, toAdd);

            if (current.data > toAdd.data)
            {
                current.left = toAdd;
            }

            else
            {
                current.right = toAdd;
            }
        }


        public Node Traverse(Node current,  Node toAdd)
        {
            return current;
        }


    }
}
