using System;
using System.Diagnostics;
using System.Linq;

namespace Fundamental.DataStructuresAndAlgorithms
{
    public static class QueueExample
    {
        public static void Run()
        {
            var queue = new System.Collections.Queue();
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            for (var i = 0; i < Program.Count; i++)
            {
                queue.Enqueue($"object {i + 1}");
            }
            stopWatch.Stop();
            Console.WriteLine($"Queue push {Program.Count} object in {stopWatch.ElapsedMilliseconds}ms");
            
            stopWatch.Restart();
            for (var i = 0; i < queue.Count; i++)
            {
                Console.Write("\r Queue read {0} object ", i + 1);
            }

            stopWatch.Stop();
            Console.WriteLine();
            Console.WriteLine($"Queue read {Program.Count} object in {stopWatch.ElapsedMilliseconds}ms");
            
            var gQueue = new System.Collections.Generic.Queue<GenericClass>();
            stopWatch.Restart();
            for (var i = 0; i < Program.Count; i++)
            {
                gQueue.Enqueue(new GenericClass
                {
                    Boo = i + 1,
                    Foo = $"object {i + 1}"
                });
            }
            stopWatch.Stop();
            Console.WriteLine($"Generic queue push {Program.Count} object in {stopWatch.ElapsedMilliseconds}ms");
            
            stopWatch.Restart();
            foreach (var genericClass in gQueue)
            {
                Console.Write("\r Generic queue read {0} ",genericClass.Foo);
            }
            stopWatch.Stop();
            Console.WriteLine();
            Console.WriteLine($"Generic queue read {Program.Count} object in {stopWatch.ElapsedMilliseconds}ms");
            
            stopWatch.Restart();
            for (var i = 0; i < Program.Count; i++)
            {
                var a = gQueue.Peek();
                Console.Write("\r Peek generic queue read index {0} {1}", i, a.Foo);
            }
            stopWatch.Stop();
            Console.WriteLine();
            Console.WriteLine($"Peek (LIFO) generic queue read {Program.Count} object in {stopWatch.ElapsedMilliseconds}ms");
            
            stopWatch.Restart();
            for (var i = 0; i < Program.Count; i++)
            {
                var a = gQueue.Dequeue();
                Console.Write("\r Dequeue generic queue read index {0} {1}", i, a.Foo);
            }
            stopWatch.Stop();
            Console.WriteLine();
            Console.WriteLine($"Dequeue (FIFO) generic queue read {Program.Count} object in {stopWatch.ElapsedMilliseconds}ms");

        }
    }
}