﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Anonim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var instance = new { Name = "Alex", Age = 27, Id = new { Number = 123} };
            Console.WriteLine("Name = {0}, Age = {1}, ID = {2}", instance.Name, instance.Age, instance.Id.Number);
            Type type = instance.GetType();
            Console.WriteLine(type.ToString());
            Console.ReadKey();
        }
    }
}
