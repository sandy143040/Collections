using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Demo
{
    //List<T> class represents the list of objects which can be accessed with index
    //List is Dynamic
    
    public class ListDemo
    {
        //Creating a list of integers
        List<int> list = new List<int>();
        public void Adding()
        {
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Add(50);
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Count is: " +list.Count);
            Console.WriteLine("List of Capacity: " + list.Capacity);
            list.Add(20);
            list.Add(30);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Count is: " + list.Count);
            Console.WriteLine("List of Capacity: " + list.Capacity);
            Console.WriteLine("Element present: "+ list.Contains(40));
            Console.WriteLine("Remove element: " + list.Remove(20));
            list.RemoveAt(2);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------");
            list.Reverse();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------");
            list.Add(11);
            list.Sort();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------");
            list.Clear();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
