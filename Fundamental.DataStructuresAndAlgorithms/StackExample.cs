using System;
using System.Diagnostics;

namespace Fundamental.DataStructuresAndAlgorithms
{
    public static class StackExample
    {
        
        public static void Run()
        {
            var stack = new System.Collections.Stack();
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            for (var i = 0; i < Program.Count; i++)
            {
                stack.Push($"object {i + 1}");
            }
            stopWatch.Stop();
            Console.WriteLine($"Stack push {Program.Count} object in {stopWatch.ElapsedMilliseconds}ms");
            
            stopWatch.Restart();
            for (var i = 0; i < stack.Count; i++)
            {
                Console.Write("\r Stack read {0} object ", i + 1);
            }

            stopWatch.Stop();
            Console.WriteLine();
            Console.WriteLine($"Stack read {Program.Count} object in {stopWatch.ElapsedMilliseconds}ms");


            var gStack = new System.Collections.Generic.Stack<GenericClass>();
            stopWatch.Restart();
            for (var i = 0; i < Program.Count; i++)
            {
                gStack.Push(new GenericClass
                {
                    Boo = i + 1,
                    Foo = $"object {i + 1}"
                });
            }
            stopWatch.Stop();
            Console.WriteLine($"Generic stack push {Program.Count} object in {stopWatch.ElapsedMilliseconds}ms");
            
            stopWatch.Restart();
            foreach (var genericClass in gStack)
            {
                Console.Write("\r Generic stack read {0} object ",genericClass.Foo);
            }
            stopWatch.Stop();
            Console.WriteLine();
            Console.WriteLine($"Generic stack read {Program.Count} object in {stopWatch.ElapsedMilliseconds}ms");
        }

    }
}