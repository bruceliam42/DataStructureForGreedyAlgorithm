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

            myTree.addGreedyTreeNode(NewNode(20));
            myTree.addGreedyTreeNode(NewNode(4));
            myTree.addGreedyTreeNode(NewNode(8));

            myTree.GetGreedyTreeNodes()[0].addGreedyTreeNode(NewNode(37));
            myTree.GetGreedyTreeNodes()[0].addGreedyTreeNode(NewNode(100));

            myTree.GetGreedyTreeNodes()[1].addGreedyTreeNode(NewNode(30));
            myTree.GetGreedyTreeNodes()[1].addGreedyTreeNode(NewNode(12));
                myTree.GetGreedyTreeNodes()[1].GetGreedyTreeNodes()[1].addGreedyTreeNode(NewNode(2));
                myTree.GetGreedyTreeNodes()[1].GetGreedyTreeNodes()[1].addGreedyTreeNode(NewNode(10));
                     myTree.GetGreedyTreeNodes()[1].GetGreedyTreeNodes()[1].GetGreedyTreeNodes()[0].addGreedyTreeNode(NewNode(10));
                     myTree.GetGreedyTreeNodes()[1].GetGreedyTreeNodes()[1].GetGreedyTreeNodes()[0].addGreedyTreeNode(NewNode(9));




            myTree.GetGreedyTreeNodes()[2].addGreedyTreeNode(NewNode(90));
            myTree.GetGreedyTreeNodes()[2].addGreedyTreeNode(NewNode(2));




            GreedyTreeNode next = myTree.FindCheapestRoute();
            Console.WriteLine("Cost.... " + next.cost);


            for (int i = 1; i <= 3; i++)
            {
                 next = next.FindCheapestRoute();
                Console.WriteLine("Cost.... " + next.cost);
            }



        }

        public static GreedyTreeNode NewNode(int cost)
        {
            GreedyTreeNode newNode = new GreedyTreeNode();
            newNode.cost = cost;

            return newNode;

        }

    



    }
}
