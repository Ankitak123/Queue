using System;
using System.Collections;
namespace ImplementQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            //EnQueue

            Console.WriteLine("Example of EnQueue:");
            Queue my_queue = new Queue();

            my_queue.Enqueue("C");
            my_queue.Enqueue("C++");
            my_queue.Enqueue("C#");
            my_queue.Enqueue("Java");
            my_queue.Enqueue("Python");
            my_queue.Enqueue("HTML");

            foreach (var ele in my_queue)
            {
                Console.WriteLine(ele);
            }

            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Example of DeQueue:");
            //DeQueue
            Queue qt = new Queue();
            qt.Enqueue(1);
            qt.Enqueue(2);
            qt.Enqueue(3);

            qt.Dequeue();

            foreach (Object obj in qt)
            {
                Console.WriteLine(obj);
            }
            Console.ReadKey();
        }
    }
}
    
