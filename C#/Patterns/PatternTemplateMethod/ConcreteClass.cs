﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternTemplateMethod
{
    public class ConcreteClass : AbstractClass
    {
        public override void PrimitiveOperation1()
        {
            Console.WriteLine("PrimitiveOperation1");
        }

        public override void PrimitiveOperation2()
        {
            Console.WriteLine("PrimitiveOperation2");
        }
    }
}