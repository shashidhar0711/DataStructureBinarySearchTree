using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureBinarySearchTree
{
    public class BinarySearchTree<T> where T:IComparable
    {
        /// <summary>
        /// Gets or sets the node data.
        /// </summary>
        /// <value>
        /// The node data.
        /// </value>
        public T NodeData { get; set; }

        /// <summary>
        /// Gets or sets the left tree.
        /// </summary>
        /// <value>
        /// The left tree.
        /// </value>
        public BinarySearchTree<T> LeftTree { get; set; }

        /// <summary>
        /// Gets or sets the right tree.
        /// </summary>
        /// <value>
        /// The right tree.
        /// </value>
        public BinarySearchTree<T> RightTree { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BinarySearchTree{T}"/> class.
        /// </summary>
        /// <param name="nodeData">The node data.</param>
        public BinarySearchTree(T nodeData)
        {
            this.NodeData = nodeData;
            this.LeftTree = null;
            this.RightTree = null;
        }

        /// <summary>
        /// variables
        /// </summary>
        
        bool result = false;
        int leftCount = 0;
        int rightCount = 0;

        /// <summary>
        /// Inserts the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        public void Insert(T item)
        {
            T currentNodeValue = this.NodeData;
            /// It checks, if current node value is greater than given item
            if (currentNodeValue.CompareTo(item) > 0)
            {
                if (this.LeftTree == null)
                {
                    /// create a new left tree with that item
                    this.LeftTree = new BinarySearchTree<T>(item);
                }
                else
                {
                    /// if does have already left tree insert this new item into the left tree
                    this.LeftTree.Insert(item);
                }
            }
            else
            {
                if (this.RightTree == null)
                {
                    /// create a new right tree with that item
                    this.RightTree = new BinarySearchTree<T>(item);
                }
                else
                {
                    /// if does have already right tree insert this new item into the right tree
                    this.RightTree.Insert(item);
                }
            }
        }

        /// <summary>
        /// Displays this instance.
        /// </summary>
        public void Display()
        {
            if (this.LeftTree != null)
            {
                this.leftCount++;
                this.LeftTree.Display();
            }
            Console.WriteLine(this.NodeData.ToString());

            if (this.RightTree != null)
            {
                this.rightCount++;
                this.RightTree.Display();
            }
        }

        /// <summary>
        /// Gets the size.
        /// </summary>
        /// <returns></returns>
        public void GetSize()
        {
            Console.WriteLine("size" + " " + (1 + this.leftCount + this.rightCount));
        }

    /// <summary>
    /// Searches the element.
    /// </summary>
    /// <param name="element">The element.</param>
    /// <param name="node">The node.</param>
    /// <returns></returns>
    public bool SearchElement(T element, BinarySearchTree<T> node)
        {
            if(node == null)
            {
                return false;
            }

            /// If node data equals to element
            /// it will print the node data
            if(node.NodeData.Equals(element))
            {
                Console.WriteLine("Found the element " +node.NodeData);
                return true;
            }

            /// if element is lesser than node data then it will search on left tree or nodes
            /// if element is greater than node data then it will search on right tree or nodes
            if(element.CompareTo(node.NodeData) < 0)
            {
                SearchElement(element, node.LeftTree);
            }
            if (element.CompareTo(node.NodeData) > 0)
            {
                SearchElement(element, node.RightTree);
            }
            return result;
        }
    }
}
