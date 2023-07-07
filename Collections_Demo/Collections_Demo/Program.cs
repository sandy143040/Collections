using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Demo
{
    internal class Program
    {
        //Collection is a class that means we can create an object
        //can be create or declared instance of a class,so we can add a data in collection
        //collection types - are designed to store, manage similar data
        //We can used to adding, remove, find and sorting data in collection
        //two types: Generic and Non-Generic collections
        //Non-generic - arrayList, HashTable, sortedList, stack and Queue
        //Generic : List, dictionary, sortedlist, stack and queue
        static void Main(string[] args)
        {
            ListDemo listDemo = new ListDemo();
            listDemo.Adding();

            Console.ReadLine();
        }
    }
}
