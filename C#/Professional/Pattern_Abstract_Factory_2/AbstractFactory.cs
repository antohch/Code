﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Abstract_Factory_2
{
    abstract class AbstractFactory
    {
        public abstract AbstractBottle CreatBottle();

        public abstract AbstractWater CreatWater();
        
    }
}
