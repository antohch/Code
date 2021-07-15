﻿using System;
using System.Collections.Generic;
using System.Text;

namespace lesson3
{
    class Invoice
    {
        //Title lesson 5 time 28 mins
        public DateTime Date { get; set; }
        public string Number { get; set; } = null;
        public string To { get; set; } = null;
        public string From { get; set; } = null;

        //Body
        public Table Table { get; } = new Table();
        //Footer
        public decimal Total { get => Table.Total; }
        public string StorekeeperSurname { get; set; } = null;
        public string ForwarderSurname { get; set; } = null;
     }
}
