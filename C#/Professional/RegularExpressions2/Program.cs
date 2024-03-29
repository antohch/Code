﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpressions2
{
    internal class Program
    {
        static string Math (Match x)
        {
            Console.WriteLine(x.Value);
            int value = int.Parse (x.Value);
            return (value + 1).ToString ();
            //return "sdf";
        }
        static void Main(string[] args)
        {
            string pattern;
            pattern = @"^\d{1,2}";
            var regex = new Regex(pattern);
            var array = new[] { "test", "123", "test123", "te123st", "34534yyy3454" };
            foreach(String element in array)
            {
                Console.WriteLine(
                    regex.IsMatch(element)
                        ? "Строка \"{0}\" соответствует шаблону \"{1}\""
                        : "Строка \"{0}\" НЕ соответствует шаблону \"{1}\"", element, pattern);
                string str = Regex.Replace(element, pattern, "*");
                Console.WriteLine(str);
               

                Console.WriteLine(new string('-', 50));
            }
            //Console.WriteLine(Regex.Replace("5 is less then 10", @"\d", m => (int.Parse(m.Value)+1).ToString()));
            //MatchEvaluator match = new MatchEvaluator(Math);
            MatchEvaluator match = Math;
            Console.WriteLine(Regex.Replace("5 is less then 10", @"\d+", match));
            Console.ReadKey();
        }
    }
}
