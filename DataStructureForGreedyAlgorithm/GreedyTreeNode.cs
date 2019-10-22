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

    //This is a test committ
    

    /// <summary>
    /// Model a node in a tree structure
    /// </summary>
    class GreedyTreeNode
    {
        private List<GreedyTreeNode> greedyTreeNodes;
        private int mCost;

        /// <summary>
        /// Root Node Constructor
        /// </summary>
        /// <param name="cost"></param>
        public GreedyTreeNode()
        {
            this.cost = 0;
            greedyTreeNodes = new List<GreedyTreeNode>();
        }

        /// <summary>
        /// The cost to get to this node if you are traversing the tree
        /// </summary>
        public int cost {
            get { return mCost; }
            set { mCost = value; }
        }
        /// <summary>
        /// Find the cheapest route out of this node
        /// </summary>
        /// <returns>A reference to the cheapest node connected to this node</returns>
        public GreedyTreeNode FindCheapestRoute()
        {
            int minCost = int.MaxValue; 
            GreedyTreeNode cheapestGreedyTreeNode = null;
            foreach (GreedyTreeNode greedyTreeNode in greedyTreeNodes)
            {
                if (greedyTreeNode.cost < minCost) {
                    minCost = greedyTreeNode.cost;
                    cheapestGreedyTreeNode = greedyTreeNode;    // Copy the reference
                };
            }
            return cheapestGreedyTreeNode;
        }
        public void addGreedyTreeNode(GreedyTreeNode greedyTreeNode)
        {
            greedyTreeNodes.Add(new GreedyTreeNode(greedyTreeNode));
        }
        /// <summary>
        /// Copy Constructor
        /// </summary>
        /// <param name="greedyTreeNode"></param>
        public GreedyTreeNode(GreedyTreeNode NewGeedyTreeNode)
        {
            this.mCost = NewGeedyTreeNode.cost;
            greedyTreeNodes = new List<GreedyTreeNode>();
            foreach (GreedyTreeNode greedyTreeNode in NewGeedyTreeNode.GetGreedyTreeNodes())
            {
                this.addGreedyTreeNode(greedyTreeNode);
            }
        }
      
        /// <summary>
        /// Get the list of nodes connected to this node
        /// </summary>
        /// <returns>The list of nodes connected to this node.</returns>
        public List<GreedyTreeNode> GetGreedyTreeNodes() { return greedyTreeNodes; }
    }
}
