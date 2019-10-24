﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new LinkedListNode of type String and display its
            // properties
            LinkedListNode<String> lln = new LinkedListNode<string>("orange");
            Console.WriteLine("display properties");
            DisplayProperties(lln);

            // create linked list
            LinkedList<String> ll = new LinkedList<string>();
            ll.AddLast(lln);
            Console.WriteLine("after adding node to list");
            DisplayProperties(lln);

            // add
            ll.AddFirst("red");
            ll.AddLast("yellow");
            Console.WriteLine("\nafter adding other nodes");
            DisplayProperties(lln);

            Console.WriteLine("traversal");
            LinkedListNode<string> node = ll.First;
            while (node != null)
            {
                Console.WriteLine("   {0}", node.Value);
                node = node.Next;
            }
            Console.WriteLine();
        }

        public static void DisplayProperties(LinkedListNode<string> lln)
        {
            if (lln.List == null)
            {
                Console.WriteLine("   Node is not linked.");
            }
            else
            {
                Console.WriteLine("   Node belongs to a linked list with {0} elements", lln.List.Count);
            }

            if (lln.Previous == null)
            {
                Console.WriteLine("   Previous node is null");
            }
            else
            {
                Console.WriteLine("   Value of previous node: {0}", lln.Previous.Value);
            }

            if (lln.Next == null)
            {
                Console.WriteLine("   Next node is null");
            }
            else
            {
                Console.WriteLine("   Value of next node: {0}", lln.Next.Value);
            }
        }
    }
}
