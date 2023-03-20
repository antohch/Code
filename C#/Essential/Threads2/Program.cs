﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.InteropServices;


namespace Threads2
{
    internal class Program
    {
        static void WriteSecond()
        {
            Thread thread = Thread.CurrentThread;
            thread.Name = "Secondary";
            Console.WriteLine("ID поток {0}: {1}", thread.Name, thread.GetHashCode());
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(new String(' ', 15) + thread.Name + " " + i);
                Thread.Sleep(1000);
            }
        }
        static void Main(string[] args)
        {
            Thread primaryThread = Thread.CurrentThread;
            primaryThread.Name = "Primary";
            Console.WriteLine("ID поток {0}: {1}", primaryThread.Name, primaryThread.GetHashCode());
            Thread secondaryThread = new Thread(WriteSecond);
            secondaryThread.Start();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(primaryThread.Name + " " + i);
                Thread.Sleep(1500);
            }
        }
    }
}
