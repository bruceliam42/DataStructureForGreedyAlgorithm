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
              myTree.addGreedyTreeNode(NewNode(3));
              myTree.addGreedyTreeNode(NewNode(4));
            //End of layer 1


            //Layer two of our tree with branch out more and hold 6 values
              myTree.GetGreedyTreeNodes()[0].addGreedyTreeNode(NewNode(1));
              myTree.GetGreedyTreeNodes()[0].addGreedyTreeNode(NewNode(100));

              myTree.GetGreedyTreeNodes()[1].addGreedyTreeNode(NewNode(12));
              myTree.GetGreedyTreeNodes()[1].addGreedyTreeNode(NewNode(30));

            //End layer 2


            //Begin layer 3 of the tree

            myTree.GetGreedyTreeNodes()[0].GetGreedyTreeNodes()[0].addGreedyTreeNode(NewNode(90));
            myTree.GetGreedyTreeNodes()[0].GetGreedyTreeNodes()[1].addGreedyTreeNode(myTree.GetGreedyTreeNodes()[0].GetGreedyTreeNodes()[0]); //90

            myTree.GetGreedyTreeNodes()[1].GetGreedyTreeNodes()[0].addGreedyTreeNode(NewNode(1)); 
            myTree.GetGreedyTreeNodes()[1].GetGreedyTreeNodes()[1].addGreedyTreeNode(myTree.GetGreedyTreeNodes()[1].GetGreedyTreeNodes()[0].GetGreedyTreeNodes()[0]); //Sharing a reference to the same node equal to one



            //All nodes will lead to 12, the final destination.  No need to share a reference to the same node with a cost of 12 here, as 12 will be the last node in the sequence. If we wanted to expand past 12 we would have to change this.  

            myTree.GetGreedyTreeNodes()[0].GetGreedyTreeNodes()[0].GetGreedyTreeNodes()[0].addGreedyTreeNode(NewNode(12));
            myTree.GetGreedyTreeNodes()[0].GetGreedyTreeNodes()[1].GetGreedyTreeNodes()[0].addGreedyTreeNode(NewNode(12));

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
