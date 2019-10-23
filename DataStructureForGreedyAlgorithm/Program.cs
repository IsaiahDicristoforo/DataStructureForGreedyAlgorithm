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

            GreedyTreeNode myTree = new GreedyTreeNode(); //This is the root node.  It does not need a cost

            /*
             * 
             * 
             * Begin Layer One: 5,6,9
             * 
             * 
             * */

             //Adding 5 6, and 9, the first layer of the tree
            myTree.addGreedyTreeNode(NewNode(5));
            myTree.addGreedyTreeNode(NewNode(6));
            myTree.addGreedyTreeNode(NewNode(9));


            /*
             * 
             * 
             * connect 5,6,9 to 30
             * 
             * 
             * */
            
            //Connecting 5 to 30
            myTree.GetGreedyTreeNodes()[0].addGreedyTreeNode(NewNode(30)); 
           
            //6 To Thirty
            myTree.GetGreedyTreeNodes()[1].addGreedyTreeNode(myTree.GetGreedyTreeNodes()[0].GetGreedyTreeNodes()[0]);

            //9 to the existing 30 Node
            myTree.GetGreedyTreeNodes()[2].addGreedyTreeNode(myTree.GetGreedyTreeNodes()[0].GetGreedyTreeNodes()[0]);

            /*
           * 
           * 
           * Create 3 AND connect 6 and 9 To Three
           * 
           * 
           * */

           // Create 3 and Connect 6 To Three
            myTree.GetGreedyTreeNodes()[1].addGreedyTreeNode(NewNode(3));

            //Connect 9 to the existing 3 Node
            myTree.GetGreedyTreeNodes()[2].addGreedyTreeNode(myTree.GetGreedyTreeNodes()[1].GetGreedyTreeNodes()[0]);


            /*
             * Create 1 and connect 9 to 1
             * 
             */
          
            //Create 1 and connect 9 to the 1 node
            myTree.GetGreedyTreeNodes()[2].addGreedyTreeNode(NewNode(1));


            /*
            * Create 4 and connect 30 to 4 and 3 To 4
            * 
            */

            //Create the 4 Node, and add 30 to it
            myTree.GetGreedyTreeNodes()[0].GetGreedyTreeNodes()[0].addGreedyTreeNode(NewNode(4));

            //Connect the 3 Node to the 4 Node
            myTree.GetGreedyTreeNodes()[1].GetGreedyTreeNodes()[1].addGreedyTreeNode(myTree.GetGreedyTreeNodes()[0].GetGreedyTreeNodes()[0]);

            /*
             * 
             * Create the 5 Node 
             * 
             */
            
            //Create the 5 Node and connect the 3 Node to it.
            myTree.GetGreedyTreeNodes()[1].GetGreedyTreeNodes()[1].addGreedyTreeNode(NewNode(5));

            //Connect the 30 Node to the 5 Node
            myTree.GetGreedyTreeNodes()[0].GetGreedyTreeNodes()[0].addGreedyTreeNode(myTree.GetGreedyTreeNodes()[1].GetGreedyTreeNodes()[1].GetGreedyTreeNodes()[1]);

            //Connect the 1 Node To The 5 Node
            myTree.GetGreedyTreeNodes()[2].GetGreedyTreeNodes()[2].addGreedyTreeNode(myTree.GetGreedyTreeNodes()[1].GetGreedyTreeNodes()[1].GetGreedyTreeNodes()[1]);

            /*
             * 
             * 
             * Create the 8 Node and and connect  30, 3, and 1 to it.
             * 
             */
             
            //Create the 8 node and connect it to 1
            myTree.GetGreedyTreeNodes()[2].GetGreedyTreeNodes()[2].addGreedyTreeNode(NewNode(8));

            //Connect 3 to 8
            myTree.GetGreedyTreeNodes()[1].GetGreedyTreeNodes()[1].addGreedyTreeNode(myTree.GetGreedyTreeNodes()[2].GetGreedyTreeNodes()[2].GetGreedyTreeNodes()[1]);

            //Connect 30 to 8
            myTree.GetGreedyTreeNodes()[0].GetGreedyTreeNodes()[0].addGreedyTreeNode(myTree.GetGreedyTreeNodes()[2].GetGreedyTreeNodes()[2].GetGreedyTreeNodes()[1]);


            /*
            * 
            * 
            * Create the 2 Node and and connect 4, 5, and 8 to it.
            * 
            */

            //Create the 2 Node and connect the 4 Node to it.
            myTree.GetGreedyTreeNodes()[0].GetGreedyTreeNodes()[0].GetGreedyTreeNodes()[0].addGreedyTreeNode(NewNode(2));

            //Connect the 2 Node to the 5 Node
            myTree.GetGreedyTreeNodes()[1].GetGreedyTreeNodes()[1].GetGreedyTreeNodes()[1].addGreedyTreeNode(myTree.GetGreedyTreeNodes()[0].GetGreedyTreeNodes()[0].GetGreedyTreeNodes()[0]);

            //Connect the 2 Node to the 8 Node
            myTree.GetGreedyTreeNodes()[2].GetGreedyTreeNodes()[2].GetGreedyTreeNodes()[1].addGreedyTreeNode(myTree.GetGreedyTreeNodes()[0].GetGreedyTreeNodes()[0].GetGreedyTreeNodes()[0]);

          
            /*
             * 
             * 
             * Create the 1 Node connect it to 5
             * 
             */

            //Create the 1 node and connect it to 5
            myTree.GetGreedyTreeNodes()[1].GetGreedyTreeNodes()[1].GetGreedyTreeNodes()[1].addGreedyTreeNode(NewNode(1));

            //Connect 4 to 1
            myTree.GetGreedyTreeNodes()[0].GetGreedyTreeNodes()[0].GetGreedyTreeNodes()[0].addGreedyTreeNode(myTree.GetGreedyTreeNodes()[1].GetGreedyTreeNodes()[1].GetGreedyTreeNodes()[1].GetGreedyTreeNodes()[1]);

            //Connect 8 To 1
            myTree.GetGreedyTreeNodes()[2].GetGreedyTreeNodes()[2].GetGreedyTreeNodes()[1].addGreedyTreeNode(myTree.GetGreedyTreeNodes()[1].GetGreedyTreeNodes()[1].GetGreedyTreeNodes()[1].GetGreedyTreeNodes()[1]);

        


            /*
             * 
             * 
             * Create the 10 Node and connect it to the 2 node
             * 
             */
            
            //Create the 10 node and connect it to the 2 node
            myTree.GetGreedyTreeNodes()[0].GetGreedyTreeNodes()[0].GetGreedyTreeNodes()[0].GetGreedyTreeNodes()[0].addGreedyTreeNode(NewNode(10));

            //Connect 1 to 10
            myTree.GetGreedyTreeNodes()[1].GetGreedyTreeNodes()[1].GetGreedyTreeNodes()[1].GetGreedyTreeNodes()[1].addGreedyTreeNode(myTree.GetGreedyTreeNodes()[0].GetGreedyTreeNodes()[0].GetGreedyTreeNodes()[0].GetGreedyTreeNodes()[0].GetGreedyTreeNodes()[0]);

            //Console.WriteLine(myTree.GetGreedyTreeNodes()[1].GetGreedyTreeNodes()[1].GetGreedyTreeNodes()[1].GetGreedyTreeNodes()[1].GetGreedyTreeNodes()[0].cost);

            GreedyTreeNode n = myTree.FindCheapestRoute();

            Console.WriteLine(n.cost);
            n = n.FindCheapestRoute();

            Console.WriteLine(n.cost);
            n = n.FindCheapestRoute();

            Console.WriteLine(n.cost);
            n = n.FindCheapestRoute();

            Console.WriteLine(n.cost);
            n = n.FindCheapestRoute();

            Console.WriteLine(n.cost);



















            /*

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
*/

        }


        public static GreedyTreeNode NewNode(int cost)
        {
            GreedyTreeNode newNode = new GreedyTreeNode();
            newNode.cost = cost;

            return newNode;

        }

        

    



    }
}
