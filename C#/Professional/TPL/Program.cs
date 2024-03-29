﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TPL
{
    internal class Program
    {
        static void MyTask()
        {
            int threadId = Thread.CurrentThread.ManagedThreadId;
            Console.WriteLine("\nMyTask: запущен в потоке № {0}", threadId);

            for(int i = 0; i < 10; i++) 
            {
                Thread.Sleep(200);
                Console.Write("+");
            }
            Console.WriteLine("\nMyTask: завершен в потоке № {0}", threadId);
        }
        static void Main(string[] args)
        {
            int threadId = Thread.CurrentThread.ManagedThreadId;
            Console.WriteLine("Main: запущен в потоке № {0}", threadId);
            Action action = new Action(MyTask);

            Task task = new Task(action);
            //task.RunSynchronously();
            task.Start();

            for(int i = 0; i< 10;i++) 
            {
                Console.Write(". ");
                Thread.Sleep(200);
            }

            Console.WriteLine("\nMain: завершен в потоке № {0}", threadId);
            Console.ReadKey();
        }
    }
}
