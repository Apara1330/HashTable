using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    public class Program
    {
        static readonly MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
        //Perform Hash operation.
        public static void HashOperation()
        {
            hash.Add("0", "Paranoids");
            hash.Add("1", "are");
            hash.Add("2", "not");
            hash.Add("3", "paranoid");
            hash.Add("4", "because");
            hash.Add("5", "they");
            hash.Add("6", "are");
            hash.Add("7", "paranoid");
            hash.Add("8", "but");
            hash.Add("9", "because");
            hash.Add("10", "they");
            hash.Add("11", "keep");
            hash.Add("12", "putting");
            hash.Add("13", "themselves");
            hash.Add("14", "deliberately");
            hash.Add("15", "into ");
            hash.Add("16", "paranoid");
            hash.Add("17", "avoidable");
            hash.Add("18", "situations");
            string hash0 = hash.Get("0");
            Console.WriteLine("Oth index value:" + hash0);
            string hash7 = hash.Get("7");
            Console.WriteLine("7th index value:" + hash7);
            hash.Remove(hash7);
            string hash15 = hash.Get("15");
            Console.WriteLine("15th index value:" + hash15);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("HashTable Program");
            HashOperation();
            Console.ReadLine();

        }
       
        
    }
}
