﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Prototype prototype = new ConcretePrototype1(1);
            Prototype clone = prototype.Clone();

            prototype = new ConcretePrototype2(2);
            clone = prototype.Clone();

            Console.ReadKey();
        }
    }
}
