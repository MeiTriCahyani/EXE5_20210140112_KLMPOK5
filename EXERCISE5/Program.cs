using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCISE5
{
    class Node
    {
        public int key;
        public Node next;

        public Node()
        {
            this.key = key;
            this.next = null;

        }
    }

    class Queue
    {
        public Node Mei, Cahyani;
        public Queue()
        {
            this.Mei = this.Cahyani = null;
        }

        public void insert(int key)
        {
            Node temp = new Node();

            if (this.Cahyani == null)
            {
                this.Mei = this.Cahyani = temp;
                return;
            }
            this.Cahyani.next = temp;
            this.Cahyani = temp;
        }
        public void delete()
        {
            if (this.Mei == null)
                return;
            this.Mei = this.Mei.next;
            if (this.Mei == null)
                this.Cahyani = null;
        }
        public void display()
        {
            Node current = Mei;
            if (Mei == null)
            {
                Console.WriteLine("list is empty");
                return;
            }
            Console.WriteLine("nodes of singly linked list:");
            while (current != null)
            {
                Console.Write(current.key + "");
                current = current.next;
            }
            Console.WriteLine();

        }



        
    }
}

