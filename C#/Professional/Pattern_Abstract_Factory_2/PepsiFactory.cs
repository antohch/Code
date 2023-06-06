﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Abstract_Factory_2
{
    internal class PepsiFactory : AbstractFactory
    {
        public override AbstractBottle CreatBottle()
        {
            return new PepsiBottle();
        }

        public override AbstractWater CreatWater()
        {
            return new PepsiWater();
        }
    }
}
