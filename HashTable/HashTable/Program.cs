using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HashTable Program");
            string paragraph = "Paranoids are not paranoid because they are paranoid but because they keep putting thempselves deliberately into paranoid avoidable situations";
            CountWords(paragraph);
            Console.ReadLine();
        }
       
        public static void CountWords(string paragraph) //to count the words.
        {
            MyMapNode<string, int> myMapNode = new MyMapNode<string, int>(6);
            string[] words = paragraph.Split(' ');
            foreach (string word in words)
            {
                if (myMapNode.Exists(word))
                    myMapNode.Add(word.ToLower(), myMapNode.Get(word) + 1);
                else
                    myMapNode.Add(word.ToLower(), 1);
            }
            Console.WriteLine("Displaying after Add operation");
            myMapNode.Display();
        }
    }
}
