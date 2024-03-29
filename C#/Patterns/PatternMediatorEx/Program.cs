﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternMediatorEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mediator = new ConcreteMediator();
            var farmer = new Farmer(mediator);
            var cannery = new Cannery(mediator);
            var shop = new Shope(mediator);

            mediator.Farmer = farmer;
            mediator.Cannery = cannery; 
            mediator.Shope = shop;

            farmer.GrowTomato();

            Console.ReadKey();
        }
    }
}
