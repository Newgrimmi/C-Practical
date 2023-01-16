using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Task1
{
    class Program
    {
        static ListNode Head = new ListNode();
        static ListNode Tail = new ListNode();
        static int Count;

        static void Main()
        {
            string StartDirectory = @"c:\Test\Test1";
            var stream = new FileStream(StartDirectory, FileMode.Create);
            Deserialize(stream);
            Console.WriteLine("List serialized");
            Console.ReadKey();
            
        }

        

        static ListNode GetNodeAt(int index)
        {
            int counter = 0;
            for (ListNode currentNode = Head; currentNode.Next != null; currentNode = currentNode.Next)
            {
                if (counter == index)
                    return currentNode;
                counter++;
            }
            return new ListNode();
        }


        static void Serialize(Stream s)
        {
            Dictionary<ListNode, int> dictionary = new Dictionary<ListNode, int>();
            int id = 0;
            for (ListNode currentNode = Head; currentNode != null; currentNode = currentNode.Next)
            {
                dictionary.Add(currentNode, id);
                id++;
            }
            using (BinaryWriter writer = new BinaryWriter(s))
            {
                for (ListNode currentNode = Head; currentNode != null; currentNode = currentNode.Next)
                {
                    writer.Write(currentNode.Data);
                    writer.Write(dictionary[currentNode.Random]);
                }
            }
            Console.WriteLine("List serialized");

        }

        static void Deserialize(Stream s)
        {
            Dictionary<int, Tuple<String, int>> dictionary = new Dictionary<int, Tuple<String, int>>();
            int counter = 0;
            using (BinaryReader reader = new BinaryReader(s))
            {
                while (reader.PeekChar() != -1)
                {
                    String data = reader.ReadString();
                    int randomId = reader.ReadInt32();
                    dictionary.Add(counter, new Tuple<String, int>(data, randomId));
                    counter++;
                }
                Console.WriteLine("File readed");
            }
            Count = counter;
            Head = new ListNode();
            ListNode current = Head;
            for (int i = 0; i < Count; i++)
            {
                current.Data = dictionary.ElementAt(i).Value.Item1;
                current.Next = new ListNode();
                if (i != Count - 1)
                {
                    current.Next.Previous = current;
                    current = current.Next;
                }
                else
                {
                    Tail = current;
                }
            }
            counter = 0;
            for (ListNode currentNode = Head; currentNode.Next != null; currentNode = currentNode.Next)
            {
                currentNode.Random = GetNodeAt(dictionary.ElementAt(counter).Value.Item2);
                counter++;
            }
            Console.WriteLine("List deserialized");
        }
    }
}

        public class ListNode
        {
            public ListNode Previous;
            public ListNode Next;
            public ListNode Random;
            public string Data = "1";
        }

        

      
