﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternMediator
{
    public abstract class Mediator
    {
        public abstract void Send(string message, Colleague colleague);
    }
}