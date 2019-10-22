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

              //This is layer 1 of our tree
              myTree.addGreedyTreeNode(NewNode(20));
              myTree.addGreedyTreeNode(NewNode(4));
              myTree.addGreedyTreeNode(NewNode(8));


            //Layer two of our tree with branch out more and hold 6 values
              myTree.GetGreedyTreeNodes()[0].addGreedyTreeNode(NewNode(1));
              myTree.GetGreedyTreeNodes()[0].addGreedyTreeNode(NewNode(100));

              myTree.GetGreedyTreeNodes()[1].addGreedyTreeNode(NewNode(12));
              myTree.GetGreedyTreeNodes()[1].addGreedyTreeNode(NewNode(30));
        
                      
              myTree.GetGreedyTreeNodes()[2].addGreedyTreeNode(NewNode(90));
              myTree.GetGreedyTreeNodes()[2].addGreedyTreeNode(NewNode(2));



            myTree.GetGreedyTreeNodes()[1].GetGreedyTreeNodes()[0].addGreedyTreeNode(NewNode(1)); 
            myTree.GetGreedyTreeNodes()[1].GetGreedyTreeNodes()[1].addGreedyTreeNode(myTree.GetGreedyTreeNodes()[1].GetGreedyTreeNodes()[0].GetGreedyTreeNodes()[0]); //Sharing a reference to the same node equal to one



            //All nodes will lead to 12
            myTree.GetGreedyTreeNodes()[1].GetGreedyTreeNodes()[1].GetGreedyTreeNodes()[0].addGreedyTreeNode(NewNode(12)); //Connects that node equal to one to a node with a cost of 12
            myTree.GetGreedyTreeNodes()[1].GetGreedyTreeNodes()[0].GetGreedyTreeNodes()[0].addGreedyTreeNode(NewNode(12)); 


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
