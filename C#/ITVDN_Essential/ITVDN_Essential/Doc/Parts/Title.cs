﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITVDN_Essential.Parts
{
    internal class Title
    {
        string content;
        public string Content { get; set; }
        public void Show()
        {
            Console.WriteLine(Content);
        }
    }
}
