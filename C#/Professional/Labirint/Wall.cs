﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirint
{
    internal class Wall : MapSite
    {
        public Wall() { }
        public override void Enter()
        {
            Console.WriteLine("Wall");
        }
    }
}
