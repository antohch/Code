﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TPL_3
{
    internal class Program
    {
        static void MyTask(object arg)
        {
            for (int i = 0; i< 80; i++) 
            { 
                Thread.Sleep(25);
                Console.Write(arg as string);
            }
        }
        static void Main(string[] args)
        {
            Action<object> myTask = MyTask;
            Task task = new Task(myTask, ".");
            task.Start();
            Console.WriteLine("\n[{0}]", task.IsCompleted);
            task.Wait();


            Console.WriteLine("\n[{0}]", task.AsyncState as string);
            Console.WriteLine("\n[{0}]", task.IsCompleted);

            Console.ReadKey();
        }
    }
}
