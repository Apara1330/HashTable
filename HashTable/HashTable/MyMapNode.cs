using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class MyMapNode<K, V>
    {
        public struct KeyValue<k, v>//creating struct
        {
            public k Key { get; set; }
            public v Value { get; set; }
        }
        private readonly int size;
        private readonly LinkedList<KeyValue<K, V>>[] items;
        public MyMapNode(int size)
        {
            this.size = size;
            this.items = new LinkedList<KeyValue<K, V>>[size];
        }
        protected int GetArrayPosition(K key)//to get position
        {
            int position = key.GetHashCode() % size;
            return Math.Abs(position);
        }
        public LinkedList<KeyValue<K, V>> GetArrayAndLinkedListPosition(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            return linkedList;
        }
        public V Get(K key)//to get the specific key
        {
            var linkedList = GetArrayAndLinkedListPosition(key);
            foreach (KeyValue<K, V> item in linkedList)
            {
                if (item.Key.Equals(key))
                {
                    return item.Value;
                }
            }
            return default(V);
        }
        public bool Exists(K key)//to find if the key is existing or not
        {
            var linkedList = GetArrayAndLinkedListPosition(key);
            foreach (KeyValue<K, V> item in linkedList)
            {
                if (item.Key.Equals(key))
                {
                    return true;
                }
            }
            return false;
        }

               
        protected LinkedList<KeyValue<K, V>> GetLinkedList(int position)//to get the linked list. 
        {
            LinkedList<KeyValue<K, V>> linkedList = items[position];
            if (linkedList == null)
            {
                linkedList = new LinkedList<KeyValue<K, V>>();
                items[position] = linkedList;
            }
            return linkedList;
        }
                
        public void Display()// to displays this instance.
        {
            foreach (var linkedlist in items)
            {
                if (linkedlist != null)
                {
                    foreach (var element in linkedlist)
                    {
                        string res = element.ToString();
                        if (res != null)
                            Console.WriteLine(element.Key + "  " + element.Value);
                    }
                }
            }
        }
        public void Add(K key, V value) //to Adds the specific key value

        {
            var linkedList = GetArrayAndLinkedListPosition(key);
            KeyValue<K, V> item = new KeyValue<K, V>() { Key = key, Value = value };
            if (linkedList.Count != 0)
            {
                foreach (KeyValue<K, V> item1 in linkedList)
                {
                    if (item1.Key.Equals(key))
                    {
                        Remove(key);
                        break;
                    }
                }
            }
            linkedList.AddLast(item);
        }
        public void Remove(K key) //to remove the specific key.

        {
            var linkedList = GetArrayAndLinkedListPosition(key);
            bool itemFound = false;
            KeyValue<K, V> foundItem = default(KeyValue<K, V>);
            foreach (KeyValue<K, V> item in linkedList)
            {
                if (item.Key.Equals(key))
                {
                    itemFound = true;
                    foundItem = item;
                }
            }
            if (itemFound)
            {
                linkedList.Remove(foundItem);
            }
        }
    }
}
