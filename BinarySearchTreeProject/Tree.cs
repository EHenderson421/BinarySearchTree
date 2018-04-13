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
        public Tree()
        {

        }

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
            while (current != null)
            {
                if (current.data > toAdd.data && current.left != null)
                {
                    current = current.left;
                }

                else if (current.data <= toAdd.data && current.right != null)
                {
                    current = current.right;
                }

                else
                {
                    return current;
                }
            }
            return current;
        }


        public bool Search(int searchData)
        {
            current = head;
            while (current.left != null || current.right != null)
            {
                if (current.data == searchData)
                {
                    Console.WriteLine("You are searching for: " + searchData);
                    Console.WriteLine("We Found: " + current.data);
                    Console.ReadLine();
                    return true;
                }

                else if (searchData < current.data)
                {
                    Console.WriteLine("We Found: " + current.data);
                    Console.WriteLine(searchData + " Is less than " + current.data);
                    Console.WriteLine("We will now move 'Left'");
                    current = current.left;
                }

                else
                {
                    Console.WriteLine("We Found: " + current.data);
                    Console.WriteLine(searchData + " Is greater than " + current.data);
                    Console.WriteLine("We will now move 'Right'");
                    current = current.right;
                }
            }

            if (current.data == searchData)
            {
                Console.WriteLine("You are searching for: " + searchData);
                Console.WriteLine("We Found: " + current.data);
                Console.ReadLine();
                return true;
            }

            else
            {
                Console.WriteLine("Value not found");
                return false;
            }
        }
    }
}
