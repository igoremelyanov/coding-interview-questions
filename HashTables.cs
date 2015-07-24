using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace DevTarining
{
    [TestFixture]
    public class HashTables
    {
        ////// Want to use my class
        public class MyHashTableClass
        {
            public Hashtable _myHashtable = new Hashtable();
            public string _Value;

            public Hashtable GetHashTable()
            {
                _myHashtable.Add("NAtasha1", 1);  // kinda collision
                _myHashtable.Add("Natasha", 1);   // collision
                _myHashtable.Add("Galya", 2);
                _myHashtable.Add("Olena", 3);
                _myHashtable.Add("Igor", 4);
                _myHashtable.Add("Igor1", 5);
                _myHashtable.Add("Igor2", 6);
                return _myHashtable;
            }

            public Hashtable RemoveValue(string value)
            {
                _myHashtable.Remove(value);
                return _myHashtable;
            }

        }

        [Test]
        public void Can_create_and_find_values_in_hashtable_get_from_myClass()
        {
            MyHashTableClass myHashtableObject = new MyHashTableClass();

            myHashtableObject.GetHashTable();
            Console.WriteLine("{0}, {1}", myHashtableObject._myHashtable["Natasha"], myHashtableObject._myHashtable.ContainsKey("Natasha"));
            Console.WriteLine(myHashtableObject._myHashtable["Igor"]);
        }

        [Test]
        public void Can_remove_value()
        {
            MyHashTableClass myHashtableObject = new MyHashTableClass();
            myHashtableObject.GetHashTable();

            myHashtableObject.RemoveValue("Galya");
            Assert.IsNull(myHashtableObject._myHashtable["Galya"], "Value not removed for some reason");
        }

        [Test]
        public void Can_find_doubling_collisions_in_hashtable()
        {
            // 1 Creating Hash Table
            MyHashTableClass myHashtableObject = new MyHashTableClass();
            //2 Creating a buffer HashTAble
            myHashtableObject.GetHashTable();
            //2 Count how many records is there
            int n = myHashtableObject._myHashtable.Count;
            //3 Looking for Values(Indexes) with same Key 

            //var collection = myHashtableObject._myHashtable.Keys;
            ICollection hashKeys = myHashtableObject._myHashtable.Keys;
            
            foreach (var hashkey1 in hashKeys)
            {
                //Console.WriteLine(hashkey1);
                Console.WriteLine("{0}   {1}", hashkey1, myHashtableObject._myHashtable[hashkey1]);
                 int count = 0;
                 foreach (var hashkey2 in hashKeys)
                 {
                     Console.WriteLine("{0}   {1}", hashkey2, myHashtableObject._myHashtable[hashkey2]);
                     string key1 = myHashtableObject._myHashtable[hashkey1].ToString();
                     string key2 = myHashtableObject._myHashtable[hashkey2].ToString();
                    if (key1 == key2)
                    {
                        count++;
                    }
                     if (count >= 2)
                     {
                         Console.WriteLine("We ve got doubling with hashkey {0}" , myHashtableObject._myHashtable[hashkey2]);
                     }

                 }
            }

            //for (int i = 0; i <= n; i++ )
            //{
            //    Console.WriteLine(myHashtableObject._myHashtable[i]);

            //    //string value = myHashtableObject._myHashtable[i].ToString();
            //    //Console.WriteLine(value);
            //    //for (int j =i+1; j <= n; j++)
            //    //{

            //    //}

            //}
            
        }





        ///////// my Class
        
        ///////////////////actual Example from Internet//////////////////////
        private static Hashtable GetHashtable()
        {
            // Create and return new Hashtable.
            Hashtable hashtable = new Hashtable();
            hashtable.Add("Area", 1000);
            hashtable.Add("Perimeter", 55);
            hashtable.Add("Mortgage", 540);
            hashtable.Add("Igor", 540);
            hashtable.Add("Igor1", 540);
            hashtable.Add("Igor2", 541);
            return hashtable;
        }
        
        [Test]
        public void Can_create_and_find_values_in_hashtable_from_method()
        {
            Hashtable hashtable = GetHashtable();
            // See if the Hashtable contains this key.
            Console.WriteLine(hashtable.ContainsKey("Perimeter"));
            // Test the Contains method. It works the same way.
            Console.WriteLine(hashtable.Contains("Area"));
            // Get value of Area with indexer.
            int value = (int)hashtable["Area"];
            // Write the value of Area.
            Console.WriteLine(value);

            Console.WriteLine((int)hashtable["Igor"]);
            Console.WriteLine((int)hashtable["Igor1"]);
            Console.WriteLine((int)hashtable["Igor2"]);
        }
       /////////////////////////////////////////
    }
}
