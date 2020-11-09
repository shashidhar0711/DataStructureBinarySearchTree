using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureBinarySearchTree
{
    /// <summary>
    /// Binary search tree generic class 
    /// </summary>
    /// <typeparam name="T"></typeparam>
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
        int leftCount = 0;
        int rightCount = 0;
        bool result = false;

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
    }
}
