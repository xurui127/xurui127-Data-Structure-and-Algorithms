using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BST
{

    class BST
    {
        public class Node
        {
            public int data;
            public Node leftNode;
            public Node rightNode;
            public int height;


            public Node()
            {
                leftNode = null;
                rightNode = null;
                height = 0;
            }
            public Node(int newData)
            {
                data = newData;
                leftNode = null;
                rightNode = null;
                height = 0;
            }
        }

        private Node root;
        BST()
        {
            root = null;
        }
        BST(int newData)
        {
            root = new Node(newData);
        }
      public  BST(int[] newData)
        {
            root = null;
            for (int i = 0; i < newData.Length; i++)
            {
                Insert(newData[i]);
            }
           
            }
        private int Height(Node node)
        {
            if (node ==null)
            {
                return -1;
            }
            else
            {
                return node.height;
            }
        }
        private Node Insert( int data ,Node node)
        {
           
            if (node == null)
            {
                node = new Node(data);
            }
            
            else if (data < node.data)
            {
                node.leftNode = Insert(data, node.leftNode);

            }
            else if (data >node.data)
            {
                node.rightNode = Insert(data, node.rightNode);

            }
            node.height = 1 + Math.Max(Height(node.leftNode), Height(node.rightNode));
            root = node;
            return node;
        }
        private Node minValueNode(Node _node)
        {
            Node current = _node;
            while(current.leftNode != null)
            {
                current = current.leftNode;
            }
            return current;
        }
        private void Inoder(Node node)
        {
            if (node != null)
            {
                Inoder(node.leftNode);
                Console.WriteLine(node.data + " Height : " + node.height);
                Inoder(node.rightNode);
            }
        }
        private void Preoder(Node node)
        {
            if (node !=null)
            {
                Console.WriteLine(node.data + " Height : " + node.height);
                Preoder(node.leftNode);
                Preoder(node.rightNode);
            }
        }
        private void Posoder(Node node)
        {
            if (node!=null)
            {
            Posoder(node.leftNode);
            Posoder(node.rightNode);
            Console.WriteLine(node.data + " Height : " + node.height);

            }
        }
        private Node remove(int _data,Node _node)
        {
            if (_node == null)
            {
                return _node;
            }
            if (_data < _node.data)
            {
                _node.leftNode = remove(_data, _node.leftNode);
            }
            else if (_data> _node.data)
            {
                _node.rightNode = remove(_data, _node.rightNode);
            }
            else // _data = _node.data
            {
                if ((_node.leftNode == null)||(_node.rightNode == null)) // case: the node have Zero or One child node
                {
                    Node temp = null;
                    if (_node.leftNode != null)
                    {
                        temp = _node.leftNode;
                    }
                    else
                    {
                        temp = _node.rightNode;
                    }
                    _node = null;
                    _node = temp;
                }
                else // case: the target node has two children 
                {
                    Node temp = minValueNode(_node.rightNode);
                    _node.data = temp.data;
                    _node.rightNode = remove(temp.data, _node.rightNode);
                }
                if (_node != null)
                {
                    _node.height = 1 + Math.Max(Height(_node.leftNode), Height(_node.rightNode));
                }
               
            }
            return _node;
        }
        private void breadthFirst(Node _node)
        {
            Queue<Node> nodes = new Queue<Node>();
            nodes.Enqueue(_node);
            while (nodes.Any())
            {
                Node w = nodes.Peek();
                nodes.Dequeue();
                if (w != null)
                {
                    Console.WriteLine(w.data + " - height = " + w.height);
                    nodes.Enqueue(w.leftNode);
                    nodes.Enqueue(w.rightNode);
                }
            }
        }
        public void InOrder()
        {
            Inoder(root);
        } 
        public void PreOder()
        {
            Preoder(root);
        }
        public void PosOder()
        {
            Posoder(root);
        }
        public void Insert(int data)
        {
            Insert(data, root);
        }
        public void Remove(int _data)
        {
            remove(_data, root);
        }
        public void BreadthFirst()
        {
            breadthFirst(root);
        }
    }
}
