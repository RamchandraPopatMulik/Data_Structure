using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection1
{
    internal class LinkedList
    {
        internal Node head;
        internal void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("Inserted into Linked List :  {0}", node.data);
        }
        //internal void Display()
        //{
        //    Node temp = this.head;
        //    if (temp == null)
        //    {
        //        Console.WriteLine(" Linked List is Empty ");
        //    }
        //    while (temp != null)
        //    {
        //        Console.WriteLine(temp.data + " ");
        //        temp = temp.next;
        //    }
        //}

        internal Node InsertAtParticularPosition(int position, int data)
        {
            Node temp = head;
            if (position < 1)
            {
                Console.WriteLine("Invalid Data");
            }
            if (position == 1)
            {
                var newNode = new Node(data);
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                while (position-- != 0)
                {
                    if (position == 1)
                    {
                        var node = new Node(data);
                        node.next = temp.next;
                        temp.next = node;
                        break;
                    }
                    temp = temp.next;
                }
                if (position != 1)
                {
                    Console.WriteLine("Position Out of Range");
                }
            }
            return head;
        }
        internal Node RemoveFirstNode()
        {
            if (head == null)
            {
                return null;
            }
            head = head.next;
            return head;
        }
        internal Node RemoveLastNode()
        {
            if(head==null)
            {
                return null;
            }
            Node newNode = head;
            while(newNode.next.next !=null)
            {
                newNode = newNode.next;
            }
            newNode.next= null;
            return head;
        }
        public void Display()
        {

            int i = 1;
            Node temp = head;

            Console.WriteLine();
            if (temp == null)
            {
                Console.WriteLine("LinkedList is Empty");
            }
            while (temp != null)
            {
                Console.WriteLine($"Element {i} in Linked List is : " + temp.data);
                temp = temp.next;
                i++;

            }
        }
    }
}
