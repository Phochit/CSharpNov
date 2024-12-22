using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day5;

namespace Day4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // Collection, Loop

            // Array

            // [] {} <> ()
            int count = 5;
            int[] nums = new int[count]; // index(0 to 4) - rank(length)=5 , if n, index ( 0 to n-1 )
            nums[3] = 12;
            nums[count - 4] = 10;
            nums[2] = 65;
            nums[0 * 1] = 74;
            nums[16 / 4] = 36;

            //int n = 0;
            //ITC: if(n<5)
            //{
            //    Console.WriteLine(nums[n]); //74
            //    n++;
            //    goto ITC;
            //}

            // for,foreach,while,do-while

            // for(initialize;condition;increment)
            // {}

            // Data Structure

            int[] nums2 = { 12, 13, 67, 87, 94, 52, 41, 76 };
            int len = nums2.Length;
            for (int n = 0; n < len; n++)
            {
                Console.WriteLine(nums2[n]);
            }
            Console.WriteLine();
            // ArrayList
            ArrayList mydata = new ArrayList(); // Object Instantiate
            mydata.Add(10);
            mydata.Add("sdafds"); //
            mydata.Add(10.36);
            mydata.Add(DateTime.Now);
            mydata.Add('a');

            // foreach(itemType nm in enumerableObject)

            foreach (var res in mydata)
            {
                Console.WriteLine(res);
            }

            Console.WriteLine();
            // Stack (LIFO)
            // insert,save,add, assign

            Stack st = new Stack();
            Stack<string> st2 = new Stack<string>();

            st.Push(15);
            st.Push(1.23);
            st.Push(DateTime.Now);
            st.Pop();

            foreach (var res in st)
                Console.WriteLine(res);

            // Queue (FIFO)
            Queue q = new Queue();

            q.Enqueue("Hello");
            q.Enqueue(78.23);
            q.Dequeue();

            // Dictionary, List, HashSet, LinkedList

            // 5 - 1 to 5 
            // 1 x 1 = 1
            // 1 x 2 = 2
            // 1 x 12 = 12

            // 2 x 1

            
        }
    }
}
