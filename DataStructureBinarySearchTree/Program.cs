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
            binarySearch.Insert(30);
            binarySearch.Insert(70);
            binarySearch.Insert(22);
            binarySearch.Insert(40);
            binarySearch.Insert(60);
            binarySearch.Insert(95);
            binarySearch.Insert(11);
            binarySearch.Insert(65);
            binarySearch.Insert(3);
            binarySearch.Insert(16);
            binarySearch.Insert(63);
            binarySearch.Insert(67);
            /// printing all elements
            /// it will prit size of binary tree
            binarySearch.Display();

            /// seaching elements if it exist it will print or not
            bool result = binarySearch.SearchElement(67, binarySearch);
        }
    }
}
