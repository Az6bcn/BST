using System;
namespace BinarySearchTree
{
    public class BST
    {
        public Node RootNode { get; set; }

        public BST()
        {
            RootNode = null;
        }

        public void Add(int value)
        {
            var newNode = NewNode(value);

            if (RootNode is null)
            {
                // add root node
                RootNode = newNode;
                return;
            }
            else
            {
                var currentNode = RootNode;
                Node parentNode;

                while (RootNode != null)
                {
                    parentNode = currentNode;

                    if (value < currentNode.Value)
                    {
                        // left child node
                        if (parentNode.LeftNode is null)
                        {
                            parentNode.LeftNode = newNode;
                            break;
                        }

                        currentNode = currentNode.LeftNode;
                        continue;
                    }
                    else
                    {
                        // right child node
                        if (parentNode.RightNode is null)
                        {
                            parentNode.RightNode = newNode;
                            break;
                        }

                        currentNode = currentNode.RightNode;
                        continue;
                    }
                }
            }
        }

        private Node NewNode(int value)
        {
            return new Node
            {
                Value = value
            };
        }
    }
}
