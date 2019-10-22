/*
 * Bill Nicholson
 * nicholdw@ucmail.uc.edu
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureForGreedyAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a root node. The cost is not relevant.
            GreedyTreeNode myTree = new GreedyTreeNode();

            // Add more nodes...
            GreedyTreeNode node1 = new GreedyTreeNode();
            node1.cost = 1;

            GreedyTreeNode node2 = new GreedyTreeNode();
            node2.cost = 4;

            GreedyTreeNode node3 = new GreedyTreeNode();
            node3.cost = 7;

            GreedyTreeNode node4 = new GreedyTreeNode();
            node4.cost = 90;

            GreedyTreeNode node5 = new GreedyTreeNode();
            node5.cost = 8;

            GreedyTreeNode node6 = new GreedyTreeNode();
            node6.cost = 100;


            myTree.addGreedyTreeNode(node1);
            myTree.addGreedyTreeNode(node2);
            myTree.addGreedyTreeNode(node3);

            myTree.GetGreedyTreeNodes()[0].addGreedyTreeNode(node4);
            myTree.GetGreedyTreeNodes()[0].addGreedyTreeNode(node5);

            myTree.GetGreedyTreeNodes()[0].GetGreedyTreeNodes()[1].addGreedyTreeNode(node6);
            myTree.GetGreedyTreeNodes()[0].GetGreedyTreeNodes()[1].addGreedyTreeNode(node1);


            GreedyTreeNode next = myTree.FindCheapestRoute();
            Console.WriteLine("Cost.... " + next.cost);


            for (int i = 1; i < 3; i++)
            {
                 next = next.FindCheapestRoute();
                Console.WriteLine("Total Cost.... " + next.cost);
            }



        }

    



    }
}
