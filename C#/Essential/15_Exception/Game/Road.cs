﻿using System;
using System.Threading;

namespace _15_Exception
{
    class Road
    {
        private int left = 0;
        private int top = 0;

        private int speed = 0;
        public int Speed
        {
            set
            {
                if (value != 0)
                    speed = 10000 / value;
                else
                    speed = value;
            }
        }

        public Road(int left = 30, int top = 0)
        {
            this.left = left;
            this.top = top;
            
        }

        public void Movie()
        {
            Thread th = new Thread(DrawStrips);
            th.Start();
            th.IsBackground = true;
            //Thread th2 = new Thread(DrawRoad);
            //th2.Start();
        }
        void DrawRoad()
        {
            while (true)
            {
                Thread.Sleep(this.speed);
                Console.SetCursorPosition(left, top);
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("                        ");
            }
            //Console.ForegroundColor = ConsoleColor.Blue;
            //while(true)
            //{
            //    Console.WriteLine(new string(' ', left + 35));
            //}
        }

        void DrawStrips()
        {
            while (true)
            {
                if (this.speed != 0)
                {
                    for (int c = 0; c < 3; c++)
                    {

                        // Очистка старой полосы
                        for (int j = 0; j < 45; j++)
                        {
                            Console.BackgroundColor = ConsoleColor.Black;

                            Console.SetCursorPosition(left, j);      // Левая полоса
                            Console.Write(" ");

                            Console.SetCursorPosition(left + 35, j); // Правая полоса
                            Console.Write(" ");
                        }

                        // Рисование новой полосы
                        for (int k = 0; k < 15; k++)
                        {
                            Console.BackgroundColor = ConsoleColor.Gray;

                            Console.SetCursorPosition(left, top);        // Левая полоса
                            Console.Write(" ");

                            Console.SetCursorPosition(left + 35, top);   // Правая полоса
                            Console.Write(" ");

                            top = top + 3;
                            Console.BackgroundColor = ConsoleColor.Black;
                        }

                        Thread.Sleep(this.speed);
                    }
                }
            }
        }
    }
}
