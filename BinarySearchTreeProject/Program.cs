using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree myTree = new Tree();
            myTree.Add(50);
            myTree.Add(40);
            myTree.Add(700);
            myTree.Add(-10);
            myTree.Add(20);
            myTree.Add(70);
            myTree.Search(-10);
            Console.ReadLine();

        }
    }
}
