using System;

namespace DataStructureBinarySearchTree
{
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Binary Search Tree");
            /// Creating a reference of object class
            BinarySearchTree<int> binarySearch = new BinarySearchTree<int>(56);
            /// Inserting elements in to binary search tree
            binarySearch.Insert(56);
            binarySearch.Insert(30);
            binarySearch.Insert(70);
            /// printing all elements
            binarySearch.Display();
        }
    }
}
