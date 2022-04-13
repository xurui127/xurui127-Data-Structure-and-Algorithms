using System;
using System.Collections.Generic;
using System.Text;

namespace AVLBST
{

    class AVLBST
    {
        public class Node
        {
            public int data;
            public Node leftNode;
            public Node rightNode;
            public int height;
            public Node()
            {
                data = 0;
                leftNode = null;
                rightNode = null;
                height = 0;
            }
            public Node(int _data)
            {
                data = _data;
                leftNode = null;
                rightNode = null;
                height = 0;
            }
        }


        private Node root;
        public AVLBST()
        {
            root = null;
        }
        public AVLBST(int _data)
        {
            root = new Node(_data);
          
        }
        public AVLBST(int[] _data)
        {
            root = null;
            for (int i = 0; i < _data.Length; i++)
            {
               Insert(_data[i]);
            }
        }

    
        private void insert(int _data, Node node)
        {
            if (root == null)
            {
                root = new Node(_data); ;
                node = root;
            }
            else if (_data < node.data)
            {
                if (node.leftNode == null)
                {
                    node.leftNode = new Node(_data);
                }
                else
                {
                    insert(_data, node.leftNode);
                }
            }
            else if (_data > node.data)
            {
                if (node.rightNode == null)
                {
                    node.rightNode = new Node(_data);
                }
                else
                {
                    insert(_data, node.rightNode);
                }
            }
            node.height = 1 + Math.Max(height(node.leftNode), height(node.rightNode));

            // balance the tree
            int balance = getBalance(node);

            // If this node become unbalanced, then
            // there are 4 cases 

            // Left Left Case
            if (balance > 1 && _data < node.leftNode.data)
            {
                rightRotated(node);
            }

            //Left Right Case
            else if (balance>1 && _data>node.leftNode.data)
            {
                leftRotation(node.leftNode);
                rightRotated(node);
            }

            // Right Right Case 
            else if (balance<-1 && _data > node.rightNode.data)
            {
                leftRotation(node);
            }
            else if (balance<-1 && _data < node.rightNode.data)
            {
                rightRotated(node.rightNode);
                leftRotation(node);
            }

        }

        private Node remove (int _data ,Node node)
        {
            if (node ==null)
            {
                return node;
            }
            if (_data < node.data)
            {
                node.rightNode = remove(_data, node.leftNode);
            }
            else if(_data > node.data)
            {
                node.rightNode = remove(_data, node.rightNode);
            }
            else // data == node.data
            {
                if (node.leftNode == null || node.rightNode == null)
                {
                    Node temp = null;
                    if (node.leftNode != null)
                    {
                        temp = node.leftNode;
                    }
                    else
                    {
                        temp = node.rightNode;
                    }
                    node = null;
                    node = temp;
                }
                else
                {
                    Node temp = minValueNode(node.rightNode);
                    node.data = temp.data;
                    node.rightNode = remove(temp.data,node.rightNode);
                }
            }
            if (node != null )
            {
                node.height = 1 + Math.Max(height(node.leftNode), height(node.rightNode));
            }
            int balance = getBalance(node);

            // If this node becomes unbalanced
            // then there are 4 cases 
            // Left Left Case 
            if (balance >1 && getBalance(node.leftNode)>=0)
            {
                rightRotated(node);
            }
            else if (balance>1 && getBalance(node.leftNode) <0)
            {
                leftRotation(node.leftNode);
                rightRotated(node);
            }
            else if (balance<-1 && getBalance(node.rightNode)<=0)
            {
                leftRotation(node);
            }
            else if (balance<-1 && getBalance(node.rightNode)>0)
            {
                rightRotated(node.rightNode);
                leftRotation(node);
            }
            return node;
        }

        private Node minValueNode(Node node)
        {
            Node current = node;
            while(current.leftNode!= null)
            {
                current = current.leftNode;
            }
            return current;
        }

        private int getBalance(Node node)
        {
            if (node == null)
            {
                return 0;
            }
            else
            {
                return height(node.leftNode) - height(node.rightNode);
            }
        }
        private int height(Node node)
        {
            if (node == null)
            {
                return -1;
            }
            else
            {
                return node.height;
            }
        }
        // A utility function to right 
        // rotae subtree rooted with node
        private void rightRotated(Node node)
        {
            // set ch to left child node to rotate to right 
            Node ch = node.leftNode;
            // perform rotation 
            int temp = node.data;
            node.data = ch.data;
            node.leftNode = ch.leftNode;
            ch.data = temp;
            ch.leftNode = ch.rightNode;
            ch.rightNode = node.rightNode;
            node.rightNode = ch;

            // Updata heights
            ch.height = Math.Max(height(ch.leftNode), height(ch.rightNode))+1;
            node.height = Math.Max(height(node.leftNode), height(node.rightNode))+1;
        }

        private void leftRotation(Node node)
        {
            Node ch = node.rightNode;

            // Perform rotation 
            int temp = node.data;
            node.data = ch.data;
            node.rightNode = ch.rightNode;
            ch.data = temp;
            ch.rightNode = ch.leftNode;
            ch.leftNode = node.leftNode;
            node.leftNode = ch;

            // Update heights 
            ch.height = Math.Max(height(ch.leftNode), height(ch.rightNode))+1;
            node.height = Math.Max(height(node.leftNode), height(node.rightNode))+1;

        }
        private void preOrder(Node node)
        {
            if (node !=null)
            {
                Console.WriteLine(node.data + "  height = " + node.height);
                preOrder(node.leftNode);
                preOrder(node.rightNode);
            }
        }

        private void inOrder(Node node)
        {
            if (node!= null )
            {
                inOrder(node.leftNode);
                Console.WriteLine(node.data + " height = " + node.height);
                inOrder(node.rightNode);
            }
        }

        private void posOrder(Node node)
        {
            if (node != null)
            {
                posOrder(node.leftNode);
                posOrder(node.rightNode);
                Console.WriteLine(node.data + " height = " + node.height);
            }
        }


        // Public Methods 

        public void Insert(int _data)
        {
            insert(_data, root);
        }

        public void Remove(int _data)
        {
            root = remove(_data, root);
        }
        public void PreOrder()
        {
            preOrder(root);
        }
        public void InOrder()
        {
            inOrder(root);
        }
        public void PosOrder()
        {
            posOrder(root);
        }

    }
}
